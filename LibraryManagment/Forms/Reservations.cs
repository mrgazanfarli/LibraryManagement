using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryManagment.Models;
using LibraryManagment.Forms;

namespace LibraryManagment.Forms
{
    public partial class Reservations : Form
    {
        private readonly LibraryEntities db = new LibraryEntities();
        private int ClickedRow;
        private Color ErrorColor = Color.FromArgb(255, 54, 0);
        private Color SuccessColor = Color.FromArgb(131, 255, 0);
        private string[] WhatToSearch;
        private int ClickedId;
        public Reservations()
        {
            InitializeComponent();
            WhatToSearch = new string[]
            {
                "Oxucuya görə",
                "Kitaba görə",
                "Verdi",
                "Aldı"
            };
            FillCmbSearch();
            FillDgvReservations();
        }
        // Fill Search options (CmbSearch)...
        private void FillCmbSearch()
        {
            CmbSearch.Items.Clear();
            CmbSearch.Items.AddRange(WhatToSearch);
        }

        // Fill DgvReservations
        private void FillDgvReservations()
        {
            DgvReservations.Rows.Clear();

            List<Reservation> reservs = new List<Reservation>();
            if (CmbSearch.SelectedIndex == -1)
            {
                // If NO search option is selected, bring all reservation data...
                reservs = db.Reservations.OrderByDescending(r => r.GivenAt).ToList();
            }
            if (!string.IsNullOrEmpty(TxtClientNumber.Text))
            {
                // If client number is written, find the client's ID, and bring reservations only of that client...
                int ClientId = db.Clients.First(c => c.ClientNumber == TxtClientNumber.Text).Id;
                reservs = db.Reservations.Where(r => r.ClientId == ClientId).OrderBy(r => r.Client.Name).ToList();
            }
            if (CmbBooks.SelectedIndex != -1)
            {
                // If any book is selected, take the book's ID, and bring reservations only related to this book...
                int BookId = Convert.ToInt32(CmbBooks.SelectedItem.ToString().Split('-')[0]);
                reservs = db.Reservations.Where(r => r.BookId == BookId).OrderBy(r => r.Client.Name).ToList();
            }
            if (CmbUsers.SelectedIndex != -1)
            {
                // If any is user selected, find the user's ID first...
                int UserId = Convert.ToInt32(CmbUsers.SelectedItem.ToString().Split('-')[0]);

                // and then, determine if this user gave or took books...
                if(CmbSearch.SelectedIndex == 2)
                {
                    reservs = db.Reservations.Where(r => r.GivenBy == UserId).OrderBy(r => r.Client.Name).ToList();
                }
                // If user took the books, selected index will be 3...
                if(CmbSearch.SelectedIndex == 3)
                {
                    reservs = db.Reservations.Where(r => r.TakenBackBy == UserId).OrderBy(r => r.Client.Name).ToList();
                }
            }

            // After determining what the reservs contains, bring the data to the data grid view...
            foreach (Reservation reservation in reservs)
            {
                if(reservation.TakenBackAt == null)
                {
                    DgvReservations.Rows.Add(reservation.Id, reservation.Client.Name + " " + reservation.Client.Surname, reservation.Book.Author.Name, reservation.Book.Name, reservation.Interval + " gün", reservation.User.Name + " " + reservation.User.Surname, reservation.GivenAt.ToString("dd.MM.yyyy"));
                }
                else
                {
                    DgvReservations.Rows.Add(reservation.Id, reservation.Client.Name + " " + reservation.Client.Surname, reservation.Book.Author.Name, reservation.Book.Name, reservation.Interval + " gün", reservation.User.Name + " " + reservation.User.Surname, reservation.GivenAt.ToString("dd.MM.yyyy"), reservation.User1.Name + " " + reservation.User1.Surname, reservation.TakenBackAt?.ToString("dd.MM.yyyy"), reservation.Penalty?.ToString("0.00") + " AZN", reservation.Case.Status, reservation.Comment);
                }
            }
        }

        #region Fill Combo Boxes

        // Fill CmbAuthors...
        private void FillCmbAuthors()
        {
            CmbAuthors.Items.Clear();
            List<Author> authors = db.Authors.OrderBy(a => a.Name).ToList();
            foreach (Author author in authors)
            {
                CmbAuthors.Items.Add(author.Id + "-" + author.Name);
            }
        }

        // Fill CmbBooks according to the selected author...
        private void FillCmbBooks()
        {
            CmbBooks.Items.Clear();
            List<Book> books = new List<Book>();
            if(CmbAuthors.SelectedIndex != -1)
            {
                int AuthorId = Convert.ToInt32(CmbAuthors.SelectedItem.ToString().Split('-')[0]);
                books = db.Books.Where(b => b.AuthorId == AuthorId).OrderBy(b => b.Name).ToList();
            }
            else
            {
                books = db.Books.OrderBy(b => b.Name).ToList();
            }
            // Fill Combo Box...
            foreach (Book book in books)
            {
                CmbBooks.Items.Add(book.Id + "-" + book.Name);
            }
        }

        // Bring users to CmbUsers...
        private void FillCmbUsers()
        {
            CmbUsers.Items.Clear();
            List<User> users = db.Users.OrderBy(u => u.Name).ToList();
            foreach (User user in users)
            {
                CmbUsers.Items.Add(user.Id + "-" + user.Name + " " + user.Surname);
            }
        }
        #endregion

        // Reset all items to default...
        private void Reset()
        {
            // Reset combo boxes not to confuse the FillDgvReservations method. It considers these combo boxes and TxtClientNumber...
            CmbSearch.SelectedIndex = -1;
            CmbBooks.SelectedIndex = -1;
            CmbAuthors.SelectedIndex = -1;
            CmbUsers.SelectedIndex = -1;
            TxtClientNumber.ResetText();
            // Do not show any group boxes because nothing is selected in CmbSearch...
            GrbUsers.Visible = false;
            GrbBookDetails.Visible = false;
            GrbClientNumber.Visible = false;
            FillDgvReservations();
        }

        // Decide which group box to show when the selected index of CmbSearch is changed...
        private void CmbSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            GrbClientNumber.Visible = false;
            GrbBookDetails.Visible = false;
            GrbUsers.Visible = false;
            // Fill other combo boxes on each change, because user can make a change in database and the app will give an error in this case...
            if(CmbSearch.SelectedIndex == 0)
            {
                GrbClientNumber.Visible = true;
            }
            if (CmbSearch.SelectedIndex == 1)
            {
                GrbBookDetails.Visible = true;
                CmbBooks.SelectedIndex = -1;
                CmbAuthors.SelectedIndex = -1;
                FillCmbAuthors();
                FillCmbBooks();
            }
            if(CmbSearch.SelectedIndex == 2 || CmbSearch.SelectedIndex == 3)
            {
                GrbUsers.Visible = true;
                CmbUsers.SelectedIndex = -1;
                FillCmbUsers();
            }
        }

        private void Reservations_Resize(object sender, EventArgs e)
        {
            // If the form is minimized and some changes are occured in other forms, there can be an error. Prevent it by setting the comboboxes to zero state...
            if(WindowState == FormWindowState.Minimized)
            {
                CmbSearch.SelectedIndex = -1;
                CmbBooks.SelectedIndex = -1;
                CmbAuthors.SelectedIndex = -1;
                CmbUsers.SelectedIndex = -1;
            }
            if(WindowState == FormWindowState.Maximized)
            {
                
            }
        }

        private void Reservations_DoubleClick(object sender, EventArgs e)
        {
            Reset();
        }

        // Show only the books of the selected author...
        private void CmbAuthors_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillCmbBooks();
        }

        // Show only selected book's data...
        private void CmbBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillDgvReservations();
        }

        // Bring selected user's data...
        private void CmbUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillDgvReservations();
        }

        // Decide what to do with client's number...
        private void TxtClientNumber_TextChanged(object sender, EventArgs e)
        {
            LblError.Text = "Oxucu tapılmadı!";
            LblError.ForeColor = ErrorColor;
            DgvReservations.Rows.Clear();
            if(db.Clients.Any(c=>c.ClientNumber == TxtClientNumber.Text))
            {
                Client cl = db.Clients.First(c => c.ClientNumber == TxtClientNumber.Text);
                LblError.Text = cl.Name + " " + cl.Surname;
                LblError.ForeColor = SuccessColor;
            }
            if(LblError.ForeColor == SuccessColor)
            {
                // Only if the client is found, fill Data Grid View. In this case, application does less work...
                FillDgvReservations();
            }
        }
    }
}
