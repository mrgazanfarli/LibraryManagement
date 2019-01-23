using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using ClosedXML.Excel;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryManagment.Models;
using LibraryManagment.Forms;

namespace LibraryManagment.Forms
{
    public partial class Reservations : Form
    {
        private LibraryEntities db = new LibraryEntities();
        protected internal int ClickedRow;
        protected internal int ClickedId;
        private User User;
        private Color ErrorColor;
        private Color SuccessColor;
        private string[] WhatToSearch;
        private string[] WhichDates;
        private MainBoard MainBoard;
        public Reservations(MainBoard mainBoard, User user)
        {
            InitializeComponent();
            User = user;
            MainBoard = mainBoard;
            WhatToSearch = new string[]
            {
                "Oxucuya görə",
                "Kitaba görə",
                "Verdi",
                "Aldı",
                "Vaxta görə"
            };
            WhichDates = new string[]
            {
                "Verilib",
                "Alınıb"
            };
            ErrorColor = Color.FromArgb(255, 54, 0);
            SuccessColor = Color.FromArgb(234, 156, 10);
            FillCmbSearch();
            FillDgvReservations();
        }
        
        // Fill DgvReservations
        protected internal void FillDgvReservations()
        {
            DgvReservations.Rows.Clear();

            // Do it to prevent errors coming from cached data of database...
            db = new LibraryEntities();

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
                reservs = db.Reservations.Where(r => r.ClientId == ClientId).OrderByDescending(r => r.GivenAt).ToList();
            }
            if (CmbBooks.SelectedIndex != -1)
            {
                // If any book is selected, take the book's ID, and bring reservations only related to this book...
                int BookId = Convert.ToInt32(CmbBooks.SelectedItem.ToString().Split('-')[0]);
                reservs = db.Reservations.Where(r => r.BookId == BookId).OrderByDescending(r => r.GivenAt).ToList();
            }
            if (CmbUsers.SelectedIndex != -1)
            {
                // If any is user selected, find the user's ID first...
                int UserId = Convert.ToInt32(CmbUsers.SelectedItem.ToString().Split('-')[0]);

                // and then, determine if this user gave or took books...
                if(CmbSearch.SelectedIndex == 2)
                {
                    reservs = db.Reservations.Where(r => r.GivenBy == UserId).OrderByDescending(r => r.GivenAt).ToList();
                }
                // If user took the books, selected index will be 3...
                if(CmbSearch.SelectedIndex == 3)
                {
                    reservs = db.Reservations.Where(r => r.TakenBackBy == UserId).OrderByDescending(r => r.GivenAt).ToList();
                }
            }
            if(CmbWhichDates.SelectedIndex != -1)
            {
                // When it is required to bring data according to the giving date of books...
                if(CmbWhichDates.SelectedIndex == 0)
                {
                    MessageBox.Show(DtpTo.Value.ToString());
                    reservs = db.Reservations.Where(r => r.GivenAt >= DtpFrom.Value && r.GivenAt <= DtpTo.Value).OrderByDescending(r => r.GivenAt).ToList();
                }
                // When it is required to bring data according to the taking back date of books...
                if (CmbWhichDates.SelectedIndex == 1)
                {
                    reservs = db.Reservations.Where(r => r.TakenBackAt != null && r.TakenBackAt >= DtpFrom.Value && r.TakenBackAt <= DtpTo.Value).OrderByDescending(r => r.GivenAt).ToList();
                }
            }
            // After determining what the reservs contains, bring the data to the data grid view...
            foreach (Reservation reservation in reservs)
            {
                if(reservation.TakenBackAt == null)
                {
                    DgvReservations.Rows.Add(reservation.Id, reservation.Client.Name + " " + reservation.Client.Surname, reservation.Client.ClientNumber, reservation.Book.Author.Name, reservation.Book.Name, reservation.Interval + " gün", reservation.User.Name + " " + reservation.User.Surname, reservation.GivenAt.ToString("dd.MM.yyyy"));
                }
                else
                {
                    DgvReservations.Rows.Add(reservation.Id, reservation.Client.Name + " " + reservation.Client.Surname, reservation.Client.ClientNumber, reservation.Book.Author.Name, reservation.Book.Name, reservation.Interval + " gün", reservation.User.Name + " " + reservation.User.Surname, reservation.GivenAt.ToString("dd.MM.yyyy"), reservation.User1.Name + " " + reservation.User1.Surname, reservation.TakenBackAt?.ToString("dd.MM.yyyy"), reservation.Penalty == null ? "0 AZN" : reservation.Penalty?.ToString("0.00") + " AZN", reservation.Case.Status);
                }
            }
        }

        #region Fill Combo Boxes

        // Fill Search options (CmbSearch)...
        private void FillCmbSearch()
        {
            CmbSearch.Items.Clear();
            CmbSearch.Items.AddRange(WhatToSearch);
        }

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

        // Fill CmbWhichDates
        private void FillCmbWhichDates()
        {
            CmbWhichDates.Items.Clear();
            CmbWhichDates.Items.AddRange(WhichDates);
        }

        #endregion

        #region Actions on changing the selected indexes of Combo Boxes(methods)

        // Decide which group box to show when the selected index of CmbSearch is changed...
        private void CmbSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Set the selected indexes -1. Because, when the user selects a book, and then selects Client Search option, the CmbBook's selected index remains. In this case, the FillDgvReservations() method gets CONFUSED AND WORKS IN A WRONG WAY...
            CmbBooks.SelectedIndex = -1;
            CmbUsers.SelectedIndex = -1;
            CmbUsers.SelectedIndex = -1;
            CmbWhichDates.SelectedIndex = -1;
            GrbClientNumber.Visible = false;
            GrbBookDetails.Visible = false;
            GrbUsers.Visible = false;
            GrbDateDetails.Visible = false;
            // Fill other combo boxes on each change, because user can make a change in database and the app will give an error in this case...
            if (CmbSearch.SelectedIndex == 0)
            {
                GrbClientNumber.Visible = true;
                TxtClientNumber.Text = null;
            }
            if (CmbSearch.SelectedIndex == 1)
            {
                GrbBookDetails.Visible = true;
                CmbBooks.SelectedIndex = -1;
                CmbAuthors.SelectedIndex = -1;
                FillCmbAuthors();
                FillCmbBooks();
            }
            if (CmbSearch.SelectedIndex == 2 || CmbSearch.SelectedIndex == 3)
            {
                GrbUsers.Visible = true;
                CmbUsers.SelectedIndex = -1;
                FillCmbUsers();
            }
            if (CmbSearch.SelectedIndex == 4)
            {
                GrbDateDetails.Visible = true;
                FillCmbWhichDates();
            }
        }

        // Show only the books of the selected author...
        private void CmbAuthors_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillCmbBooks();
            CmbBooks.ResetText();
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

        // Show DateTimePickers only if the conditions are known...
        private void CmbWhichDates_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbWhichDates.SelectedIndex == -1)
            {
                LblFrom.Visible = false;
                LblTo.Visible = false;
                DtpFrom.Visible = false;
                DtpTo.Visible = false;
            }
            else
            {
                LblFrom.Visible = true;
                LblTo.Visible = true;
                DtpFrom.Visible = true;
                DtpTo.Visible = true;
            }
            // Fill DataGridView because the result can confuse the user...
            FillDgvReservations();
        }

        #endregion

        // Decide what to do with client's number...
        private void TxtClientNumber_TextChanged(object sender, EventArgs e)
        {
            LblError.Text = "Oxucu tapılmadı!";
            LblError.ForeColor = ErrorColor;
            DgvReservations.Rows.Clear();
            if (db.Clients.Any(c => c.ClientNumber == TxtClientNumber.Text))
            {
                Client cl = db.Clients.First(c => c.ClientNumber == TxtClientNumber.Text);
                LblError.Text = cl.Name + " " + cl.Surname;
                LblError.ForeColor = SuccessColor;
            }
            if (LblError.ForeColor == SuccessColor)
            {
                // Only if the client is found, fill Data Grid View. In this case, application does less work...
                FillDgvReservations();
            }
        }

        // Fill data grid view Real-Time when the values of DTPs are changed...
        private void Dtps_ValueChanged(object sender, EventArgs e)
        {
            DtpTo.MinDate = DtpFrom.Value;
            FillDgvReservations();
        }

        // Reset all items to default...
        private void Reset()
        {
            // Reset combo boxes not to confuse the FillDgvReservations method. It considers these combo boxes and TxtClientNumber...
            CmbSearch.SelectedIndex = -1;
            CmbBooks.SelectedIndex = -1;
            CmbAuthors.SelectedIndex = -1;
            CmbUsers.SelectedIndex = -1;
            CmbWhichDates.SelectedIndex = -1;
            TxtClientNumber.ResetText();
            ClickedRow = -1;
            ClickedId = 0;
            // Do not show any group boxes because nothing is selected in CmbSearch...
            GrbUsers.Visible = false;
            GrbBookDetails.Visible = false;
            GrbClientNumber.Visible = false;
            BtnStopReservation.Visible = false;
            BtnDeleteReservation.Visible = false;
            FillDgvReservations();
        }

        // Call Reset() on double click on the form itself...
        private void Reservations_DoubleClick(object sender, EventArgs e)
        {
            Reset();
        }

        // Follow the changes in the size of the form...
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
        }

        // Take all values when the row header is clicked...
        private void DgvReservations_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                ClickedRow = e.RowIndex;
                ClickedId = Convert.ToInt32(DgvReservations.Rows[e.RowIndex].Cells[0].Value.ToString());
                BtnStopReservation.Visible = true;
                BtnDeleteReservation.Visible = true;
                if (db.Reservations.Find(ClickedId).TakenBackAt != null)
                {
                    BtnStopReservation.Enabled = false;
                }
                else
                {
                    BtnStopReservation.Enabled = true;
                }
            }
            catch
            {
                Reset();
            }
        }

        // Automatically give a suggestion to search a reservation with client number (as the form loads)...
        private void Reservations_Load(object sender, EventArgs e)
        {
            CmbSearch.SelectedIndex = 0;
        }

        // Open the AddReservation form and make the search option zero to fill the DgvReservations successfully...
        private void BtnAddReservation_Click(object sender, EventArgs e)
        {
            AddReservation form = new AddReservation(db.Users.Find(1), this);
            CmbSearch.SelectedIndex = -1;
            form.ShowDialog();
        }

        private void BtnStopReservation_Click(object sender, EventArgs e)
        {
            Reservation res = db.Reservations.Find(ClickedId);
            db = new LibraryEntities();
            if (res.TakenBackAt == null && res.LimitToReturn != null && res.LimitToReturn != 0)
            {
                ReturnLostBook returnLost = new ReturnLostBook(this, User, ClickedId);
                returnLost.Show();
                return;
            }
            StopReservation form = new StopReservation(this, User, ClickedId);
            form.ShowDialog();
        }

        // Delete the reservations after confirmation of the user...
        private void BtnDeleteReservation_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Sifarişi silməyə əminsinizmi?", "Sifarişin silinməsi", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
            {
                Reservation reserv = db.Reservations.Find(ClickedId);
                db.Reservations.Remove(reserv);
                db.SaveChanges();
                MessageBox.Show("Sifariş silindi!");
                DgvReservations.Rows.RemoveAt(ClickedRow);
            }
        }

        // Create the DataGridView in Excel...
        private void BtnExportToExcel_Click(object sender, EventArgs e)
        {
            string ExcelFilePath;
            // Open Dialog...
            DialogResult r = FbdGetExcelFilePath.ShowDialog();
            if (r == DialogResult.OK)
            {
                ExcelFilePath = FbdGetExcelFilePath.SelectedPath;

                var WorkBook = new XLWorkbook();

                var ws = WorkBook.Worksheets.Add("Vereq 1");

                // This integer will determine the index of column...
                int d = 1;

                // Get each cell in each row...
                for (int i = 0; i < DgvReservations.Rows.Count; i++)
                {
                    for (int j = 1; j < DgvReservations.Columns.Count; j++)
                    {
                        // Set value and alignment...
                        ws.Cell(i + 2, j).Value = DgvReservations.Rows[i].Cells[j].Value;
                        ws.Cell(i + 2, j).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
                        ws.Cell(i + 2, j).Style.Alignment.SetVertical(XLAlignmentVerticalValues.Center);
                    }
                }

                // Set Columns...
                foreach (DataGridViewColumn col in DgvReservations.Columns)
                {
                    // Do NOT set Id values...
                    if (col.HeaderText != "Id")
                    {
                        // Set the values and styles...
                        ws.Cell(1, d).Value = col.HeaderText;
                        ws.Cell(1, d).Style.Font.FontSize = 13;
                        ws.Cell(1, d).Style.Fill.BackgroundColor = XLColor.ForestGreen;
                        ws.Cell(1, d).Style.Font.FontColor = XLColor.White;
                        ws.Column(d).AdjustToContents();
                        d++;
                    }
                }
                // Create the file...
                string FileName = @"\Kitabxana.xlsx";
                try
                {
                    // Try because it can give an error on saving if the Excel file is open...
                    WorkBook.SaveAs(ExcelFilePath + FileName);
                    MessageBox.Show("Excel faylı yaradıldı (dəyişdirildi)...");
                }
                catch
                {
                    MessageBox.Show("Açıq Excel faylını bağlayıb, yenidən cəhd edin!");
                    return;
                }
            }
            

        }

        private void Reservations_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainBoard.ReservationsIsOpen = false;
        }
    }
}
