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

namespace LibraryManagment.Forms
{
    public partial class AddReservation : Form
    {
        private readonly LibraryEntities db = new LibraryEntities();
        private User User;
        private Reservations Reservations;
        public AddReservation(User user)
        {
            InitializeComponent();
            FillCmbAuthors();
            FillCmbBooks();
            User = user;
        }
        public AddReservation (User user, Reservations reservations)
        {
            InitializeComponent();
            FillCmbAuthors();
            FillCmbBooks();
            User = user;
            Reservations = reservations;
        }

        // Bring authors to CMB
        private void FillCmbAuthors()
        {
            CmbAuthors.Items.Clear();
            List<Author> authors = db.Authors.ToList();
            foreach (Author author in authors)
            {
                CmbAuthors.Items.Add(author.Id + "-" + author.Name);
            }
        }

        // Bring books according to authors
        private void FillCmbBooks()
        {
            CmbBooks.Items.Clear();
            List<Book> books;
            if(CmbAuthors.SelectedIndex != -1)
            {
                int authorId = Convert.ToInt32(CmbAuthors.SelectedItem.ToString().Split('-')[0]); // Find which author is selected
                books = db.Books.Where(b => b.AuthorId == authorId).ToList();
            }
            else
            {
                books = db.Books.ToList();
            }
            foreach (Book book in books)
            {
                CmbBooks.Items.Add(book.Id + "-" + book.Name);
            }
        }

        // Change book according to the selected author
        private void CmbAuthors_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillCmbBooks();
            try
            {
                CmbBooks.SelectedIndex = 0;
            }
            catch
            {
                CmbBooks.SelectedIndex = -1;
            }
        }

        // Bring the client details as the textbox is being changed...
        private void TxtClientNumber_TextChanged(object sender, EventArgs e)
        {
            // Bring the details of an existing client...
            if (db.Clients.Any(c => c.ClientNumber == TxtClientNumber.Text))
            {
                LblClientNotFound.Visible = false;
                Client cl = db.Clients.First(c => c.ClientNumber == TxtClientNumber.Text);
                GrbClientDetails.Visible = true;
                TxtClientName.Text = cl.Name;
                TxtClientSurname.Text = cl.Surname;
                TxtClientPhone.Text = cl.Phone;
            }
            else
            {
                // Alarm that the user does NOT exist...
                GrbClientDetails.Visible = false;
                LblClientNotFound.Visible = true;
            }
        }

        // Bring all values to default
        private void Reset()
        {
            TxtClientNumber.ResetText();
            CmbAuthors.ResetText();
            CmbBooks.ResetText();
            NumInterval.Value = 30;
        }

        // Add new book reservation
        private void BtnReserv_Click(object sender, EventArgs e)
        {
            // Do not allow empty places
            if(string.IsNullOrEmpty(TxtClientNumber.Text) || CmbBooks.SelectedIndex == -1 || (NumInterval.Value == 0 || string.IsNullOrEmpty(NumInterval.Value.ToString())))
            {
                MessageBox.Show("Ulduzlu hissələr boş olmamalıdır!");
                return;
            }

            // Check if the client exists or not
            if (!db.Clients.Any(c => c.ClientNumber == TxtClientNumber.Text))
            {
                MessageBox.Show("Oxucu tapılmadı! Nömrəni düzgün daxil edin...");
                return;
            }
        
            // Get the client's and book's IDs
            int clientId = db.Clients.First(c => c.ClientNumber == TxtClientNumber.Text).Id;
            int bookId = Convert.ToInt32(CmbBooks.SelectedItem.ToString().Split('-')[0]);

            // Get the number of books that the client currently owns...
            int ClientBooks = db.Clients.Find(clientId).Reservations.Where(r => r.TakenBackAt == null).Count();

            // Check if the client reached the book limit or not...
            if (ClientBooks >= db.Clients.Find(clientId).BookLimit)
            {
                MessageBox.Show("Oxucu artıq kitab limitinə çatıb!");
                Reset();
                return;
            }

            // Check if the client has already got the same book or not...
            if (db.Clients.Find(clientId).Reservations.Any(r => r.BookId == bookId && r.TakenBackAt == null))
            {
                DialogResult r = MessageBox.Show("Oxucu artıq bu kitabdan istifadə edir. Eyni kitab yenidən verilsin?", "Xəbərdarlıq", MessageBoxButtons.YesNo);
                if (r == DialogResult.No)
                {
                    Reset();
                    return;
                }
            }

            // Check if the book exists or not
            // Firstly, find how many books exists. Subtact the reserved books from the total number of books, and check if it is zero or not...
            int? BookCount = db.Books.Find(bookId).Count - db.Reservations.Where(r => r.BookId == bookId && r.TakenBackAt == null).Count();

            if (db.Books.Find(bookId).Count == 0 || BookCount <= 0)
            {
                MessageBox.Show("Kitab artıq tükənib!", "Xəbərdarlıq");
                return;
            }

            Reservation reserv = new Reservation
            {
                ClientId = clientId,
                BookId = bookId,
                Interval = Convert.ToInt32(NumInterval.Value),
                GivenBy = User.Id,
                GivenAt = DateTime.Now
            };
            db.Reservations.Add(reserv);
            db.SaveChanges();
            MessageBox.Show("Əlavə edildi...");
            Reset();
            this.Close();
        }

        // Fill Data Grid View if the form is opened from the Reservations form...
        private void AddReservation_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(Reservations != null)
            Reservations.FillDgvReservations();
        }
    }
}
