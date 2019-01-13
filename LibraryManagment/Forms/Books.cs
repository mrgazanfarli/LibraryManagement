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
        public Books()
        {
            InitializeComponent();
            WhatToShow = new string[]
            {
                "Hamısı",
                "Mövcud olanlar",
                "Mövcud olmayanlar"
            };
            FillCmbWhatToShow();
            FillDgvBooks();
        }

        // Fill CmbShowBooks to assume which books to show

        private void FillCmbWhatToShow()
        {
            CmbShowBooks.Items.Clear();
            CmbShowBooks.Items.AddRange(WhatToShow);
        }

        // Fill DgvBooks According the item selected from CmbShowBooks
        private void FillDgvBooks()
        {
            DgvBooks.Rows.Clear();
            List<Book> books = new List<Book>();
            if (CmbShowBooks.SelectedItem == null || CmbShowBooks.SelectedIndex == 0)
            {
                books = db.Books.OrderByDescending(b=> b.Name).ToList();
            }
            if(CmbShowBooks.SelectedIndex == 1)
            {
                books = db.Books.Where(b => b.Count > 0).OrderByDescending(b => b.Name).ToList();
            }
            if(CmbShowBooks.SelectedIndex == 2)
            {
                books = db.Books.Where(b => b.Count == 0).OrderByDescending(b => b.Name).ToList();
            }

            foreach (Book book in books)
            {
                DgvBooks.Rows.Add(book.Id, book.Name, book.Author, book.Price, book.Count);
            }
        }

        // Reset Text Boxes and numeric up-downs. Set Id and row index 0 and -1
        private void Reset()
        {
            TxtBookName.ResetText();
            TxtAuthor.ResetText();
            NumPrice.Value = 0;
            NumCount.Value = 0;
            clickedId = 0;
            clickedRow = -1;
            BtnDeleteBook.Visible = false;
            BtnUpdateBook.Visible = false;
        }

        // Fill all values and get clicked row (and Id) when the row header is clicked
        private void DgvBooks_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Do not give an error when the row index not found (clicking the last empty row in Dgv)
            try
            {
                // Take the clicked row in order to update the row when deleting, updating (no need to call FillDgvBooks() again)
                clickedId = Convert.ToInt32(DgvBooks.Rows[e.RowIndex].Cells[0].Value.ToString());
                clickedRow = e.RowIndex;
                TxtBookName.Text = DgvBooks.Rows[e.RowIndex].Cells[1].Value.ToString();
                TxtAuthor.Text = DgvBooks.Rows[e.RowIndex].Cells[2].Value.ToString();
                NumPrice.Value = Convert.ToDecimal(DgvBooks.Rows[e.RowIndex].Cells[3].Value.ToString());
                NumCount.Value = Convert.ToDecimal(DgvBooks.Rows[e.RowIndex].Cells[4].Value.ToString());
            }
            catch
            {
                Exception ClickedLastRow = new KeyNotFoundException();
                Reset();
            }
            BtnUpdateBook.Visible = true;
            BtnDeleteBook.Visible = true;
        }

        // Check if the book parameters are correct or not, and the add the book to database, and bring it to the DgvBooks
        private void BtnAddBook_Click(object sender, EventArgs e)
        {
            // Check for empty places
            if (string.IsNullOrEmpty(TxtBookName.Text) || string.IsNullOrEmpty(TxtAuthor.Text))
            {
                MessageBox.Show("Kitab və müəllif adı boş ola bilməz");
                return;
            }
            // Check if the book exists or not
            if (db.Books.Any(b => b.Name == TxtBookName.Text && b.Author == TxtAuthor.Text))
            {
                MessageBox.Show("Bu kitab artıq mövcuddur. Əlavə etmək üçün sayını artıra bilərsiniz...");
                return;
            }

            Book book = new Book
            {
                Name = TxtBookName.Text,
                Author = TxtAuthor.Text,
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
            DgvBooks.Rows.Add(book.Id, book.Name, book.Author, book.Price, book.Count);
            MessageBox.Show("Kitab əlavə olundu!");
            Reset();
        }

        // Check the empty places and update the book
        private void BtnUpdateBook_Click(object sender, EventArgs e)
        {
            // Check for empty places
            if (string.IsNullOrEmpty(TxtBookName.Text) || string.IsNullOrEmpty(TxtAuthor.Text))
            {
                MessageBox.Show("Kitab və müəllif adı boş ola bilməz");
                return;
            }
            // Check if the book exists or not
            if (db.Books.Any(b => b.Name == TxtBookName.Text && b.Author == TxtAuthor.Text))
            {
                MessageBox.Show("Bu kitab artıq mövcuddur. Əlavə etmək üçün sayını artıra bilərsiniz...");
                return;
            }

            Book book = db.Books.Find(clickedId);
            book.Name = TxtBookName.Text;
            book.Author = TxtAuthor.Text;
            book.Price = NumPrice.Value;
            book.Count = Convert.ToInt32(NumCount.Value);
            db.SaveChanges();
            // Update the data grid view
            DgvBooks.Rows[clickedRow].Cells[1].Value = book.Name;
            DgvBooks.Rows[clickedRow].Cells[2].Value = book.Author;
            DgvBooks.Rows[clickedRow].Cells[3].Value = book.Price;
            DgvBooks.Rows[clickedRow].Cells[4].Value = book.Count;
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

        private void CmbShowBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillDgvBooks();
        }

        private void Books_Click(object sender, EventArgs e)
        {
            Reset();
        }
    }
}
