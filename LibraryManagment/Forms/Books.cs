using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryManagment.Models;

namespace LibraryManagment.Forms
{
    public partial class Books : Form
    {
        private readonly LibraryEntities db = new LibraryEntities();
        private string[] WhatToShow;
        private int clickedId;
        private int clickedRow;
        public bool AuthorsIsOpen;
        private User User;
        private MainBoard Board;
        public Books(MainBoard board, User user) // Bring user so that only bosses can control the book count
        {
            InitializeComponent();
            Board = board;
            User = user;
            AuthorsIsOpen = false;
            // If the boss enters, enable the change on number of books, and deleting books...
            if (!User.IsBoss)
            {
                LblBookCount.Visible = false;
                NumCount.Visible = false;
                GrbCrud.Height = 327;
                DgvBooks.Height = 325;
            }
            WhatToShow = new string[]
            {
                "Hamısı",
                "Mövcud olanlar",
                "Mövcud olmayanlar"
            };
            FillCmbWhatToShow();
            FillDgvBooks();
            FillCmbAuthors();
            FillCmbFindBook();
        }

        #region Filling Combo Boxes

        // Fill CmbShowBooks to assume which books to show
        private void FillCmbWhatToShow()
        {
            CmbShowBooks.Items.Clear();
            CmbShowBooks.Items.AddRange(WhatToShow);
        }

        //Fill CmbFindBook
        private void FillCmbFindBook()
        {
            CmbFindBook.Items.Clear();
            List<Book> books = new List<Book>();
            // check if any item of CmbFindAuthor was selected or not...
            if (CmbFindAuthor.SelectedIndex != -1)
            {
                int authorId = Convert.ToInt32(CmbFindAuthor.SelectedItem.ToString().Split('-')[0]);
                // Bring the books of the selected author only...
                books = db.Books.Where(b => b.AuthorId == authorId).OrderBy(b => b.Name).ToList();
            }
            else
            {
                // If no author was selected, bring all books...
                books = db.Books.OrderBy(b => b.Name).ToList();
            }
            foreach (Book book in books)
            {
                CmbFindBook.Items.Add(book.Id + "-" + book.Name);
            }
        }

        // Fill CmbAuthors and CmbFindAuthor from database. Make it public to call from Authors form when there is an update...
        public void FillCmbAuthors()
        {
            CmbAuthors.Items.Clear();
            CmbFindAuthor.Items.Clear();
            List<Author> authors = db.Authors.OrderBy(a=> a.Name).ToList();
            foreach (Author author in authors)
            {
                CmbAuthors.Items.Add(author.Id + "-" + author.Name);
                CmbFindAuthor.Items.Add(author.Id + "-" + author.Name);
            }
        }

        #endregion

        // Fill DgvBooks According the item selected from CmbShowBooks
        public void FillDgvBooks()
        {
            DgvBooks.Rows.Clear();
            List<Book> books = new List<Book>();
            // Brings all books...
            if (CmbShowBooks.SelectedItem == null || CmbShowBooks.SelectedIndex == 0)
            {
                    books = db.Books.OrderByDescending(b => b.Name).ToList();
            }
            // Only books that exist...
            if(CmbShowBooks.SelectedIndex == 1)
            {
                books = db.Books.Where(b => b.Count > 0).OrderByDescending(b => b.Name).ToList();
            }
            // Only books that do NOT exist...
            if(CmbShowBooks.SelectedIndex == 2)
            {
                books = db.Books.Where(b => b.Count == 0).OrderByDescending(b => b.Name).ToList();
            }

            foreach (Book book in books)
            {
                // Find how many book(s) is(are) in use currently...
                int BooksInUse = book.Reservations.Where(r => r.TakenBackAt == null).Count();
                DgvBooks.Rows.Add(book.Id, book.Author.Id, book.Name, book.Author.Name, book.Price.ToString("0.00"), BooksInUse + "/" + book.Count);
            }
        }

        // Reset Text Boxes and numeric up-downs. Set Id and row index 0 and -1
        private void Reset()
        {
            TxtBookName.ResetText();
            CmbAuthors.ResetText();
            NumPrice.Value = 0;
            NumCount.Value = 0;
            clickedId = 0;
            clickedRow = -1;
            CmbFindAuthor.SelectedIndex = -1;
            CmbFindBook.SelectedIndex = -1;
            FillCmbFindBook();
            BtnDeleteBook.Visible = false;
            BtnUpdateBook.Visible = false;
        }

        #region Selected index changed events of Combo Boxes
        // Show the books according to the selected item in CmbShowBooks
        private void CmbShowBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillDgvBooks();
        }

        // Actions done on selecting author...
        private void CmbFindAuthor_SelectedIndexChanged(object sender, EventArgs e)
        {
            // prevent the real-time error...
            if (CmbFindAuthor.SelectedIndex != -1)
            {
                DgvBooks.Rows.Clear();
                CmbFindBook.Items.Clear();
                // find which author is selected...
                int authorId = Convert.ToInt32(CmbFindAuthor.SelectedItem.ToString().Split('-')[0]);
                // get the books of the selected author...
                List<Book> books = db.Books.Where(b => b.AuthorId == authorId).ToList();
                foreach (Book book in books)
                {
                    DgvBooks.Rows.Add(book.Id, book.Author.Id, book.Name, book.Author.Name, book.Price, book.Count);
                    // Do not let to select a book of a different author...
                    CmbFindBook.Items.Add(book.Id + "-" + book.Name);
                }
                CmbFindBook.ResetText();
            }
        }

        // Actions done on selecting book...
        private void CmbFindBook_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbFindBook.SelectedIndex != -1)
            {
                // find which book is selected...
                int bookId = Convert.ToInt32(CmbFindBook.SelectedItem.ToString().Split('-')[0]);
                DgvBooks.Rows.Clear();
                // bring this book's info...
                Book book = db.Books.Find(bookId);
                DgvBooks.Rows.Add(book.Id, book.Author.Id, book.Name, book.Author.Name, book.Price, book.Count);
                CmbFindAuthor.SelectedItem = book.Author.Id + "-" + book.Author.Name;
            }
        }

        #endregion

        // Fill all values and get clicked row (and Id) when the row header is clicked
        private void DgvBooks_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Do not give an error when the row index not found (clicking the last empty row in Dgv)
            try
            {
                // Take the clicked row in order to update the row when deleting, updating (no need to call FillDgvBooks() again)
                clickedId = Convert.ToInt32(DgvBooks.Rows[e.RowIndex].Cells[0].Value.ToString());
                clickedRow = e.RowIndex;
                TxtBookName.Text = DgvBooks.Rows[e.RowIndex].Cells[2].Value.ToString();
                CmbAuthors.SelectedItem = DgvBooks.Rows[e.RowIndex].Cells[1].Value.ToString() + "-" + DgvBooks.Rows[e.RowIndex].Cells[3].Value;
                NumPrice.Value = Convert.ToDecimal(DgvBooks.Rows[e.RowIndex].Cells[4].Value.ToString());
                NumCount.Value = Convert.ToDecimal(DgvBooks.Rows[e.RowIndex].Cells[5].Value.ToString().Split('/')[1]);
                BtnUpdateBook.Visible = true;
                if (User.IsBoss)
                {
                    BtnDeleteBook.Visible = true;
                }
            }
            catch
            {
                // When the DGV is not filled, the row click will return an error because the empty row has no index
                Reset();
            }
        }

        #region CRUD of books...

        // Check if the book parameters are correct or not, and the add the book to database, and bring it to the DgvBooks
        private void BtnAddBook_Click(object sender, EventArgs e)
        {
            // Check for empty places
            if (string.IsNullOrEmpty(TxtBookName.Text) || CmbAuthors.SelectedIndex == -1)
            {
                MessageBox.Show("Kitab və müəllif adı boş ola bilməz");
                return;
            }
            // Take the selected author:
            int SelectedAuthorId = Convert.ToInt32(CmbAuthors.SelectedItem.ToString().Split('-')[0]);

            // Check if the book exists or not
            if (db.Books.Any(b => b.Name == TxtBookName.Text && b.AuthorId == SelectedAuthorId))
            {
                MessageBox.Show("Bu kitab artıq mövcuddur. Əlavə etmək üçün sayını artıra bilərsiniz...");
                return;
            }

            Book book = new Book
            {
                Name = TxtBookName.Text,
                AuthorId = SelectedAuthorId,
                Price = NumPrice.Value,
                Count = Convert.ToInt32(NumCount.Value)
            };

            //Second method to check:
            
            //ValidationContext context = new ValidationContext(book);
            //var list = new List<ValidationResult>();
            //bool isValid = Validator.TryValidateObject(book, context, list);
            //if (isValid)
            //{
            //    MessageBox.Show("valid");
            //    return;
            //}
            //else
            //{
            //    foreach (var item in list)
            //    {
            //        label6.Text += item.ErrorMessage;
            //    }
            //    return;
            //}

            db.Books.Add(book);
            db.SaveChanges();
            DgvBooks.Rows.Add(book.Id, book.AuthorId, book.Name, book.Author.Name, book.Price, "0/" + book.Count);
            MessageBox.Show("Kitab əlavə olundu!");
            Reset();
        }

        // Check the empty places and update the book
        private void BtnUpdateBook_Click(object sender, EventArgs e)
        {
            // Check for empty places
            if (string.IsNullOrEmpty(TxtBookName.Text) || CmbAuthors.SelectedIndex == -1)
            {
                MessageBox.Show("Kitab və müəllif adı boş ola bilməz");
                return;
            }
            // Assume which author is taken from Combo Box
            int SelectedAuthorId = Convert.ToInt32(CmbAuthors.SelectedItem.ToString().Split('-')[0]);

            Book book = db.Books.Find(clickedId);
            book.Name = TxtBookName.Text;
            book.AuthorId = SelectedAuthorId;
            book.Price = NumPrice.Value;
            book.Count = Convert.ToInt32(NumCount.Value);
            db.SaveChanges();
            // Update the data grid view
            // Find how many book(s) is(are) in use currently...
            int BooksInUse = book.Reservations.Where(r => r.TakenBackAt == null).Count();

            DgvBooks.Rows[clickedRow].Cells[1].Value = book.AuthorId;
            DgvBooks.Rows[clickedRow].Cells[2].Value = book.Name;
            DgvBooks.Rows[clickedRow].Cells[3].Value = book.Author.Name;
            DgvBooks.Rows[clickedRow].Cells[4].Value = book.Price;
            DgvBooks.Rows[clickedRow].Cells[5].Value = BooksInUse + "/" + book.Count;
            // Got done with data grid view
            MessageBox.Show("Kitab dəyişdirildi");
            Reset();
        }

        // take the book with ID and delete it
        private void BtnDeleteBook_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Kitabı silməyə əminsiniz? Bu zaman kitab haqqında bütün məlumatlar silinəcək", "Kitab silmə", MessageBoxButtons.YesNo);
            if(r == DialogResult.Yes)
            {
                Book book = db.Books.Find(clickedId);
                db.Books.Remove(book);
                db.SaveChanges();
                // update the DgvBooks
                DgvBooks.Rows.RemoveAt(clickedRow);
                // Done with dgv
                MessageBox.Show("Kitab silindi!");
                Reset();
            }
        }

        #endregion

        // Empty the inputs
        private void Books_Click(object sender, EventArgs e)
        {
            Reset();
        }

        // This method makes the Books form open again when it is closed before (see the MainBoard form to get info)
        private void Books_FormClosed(object sender, FormClosedEventArgs e)
        {
            Board.BookIsOpen = false;
        }

        // Get the CRUD of authors...
        private void BtnAuthors_Click(object sender, EventArgs e)
        {
            Authors form = new Authors(this);
            if (!AuthorsIsOpen)
            {
                form.ShowDialog();
                return;
            }
        }
    }
}
