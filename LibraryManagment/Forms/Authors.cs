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
    public partial class Authors : Form
    {
        private readonly LibraryEntities db = new LibraryEntities();
        private int ClickedId;
        private int ClickedRow;
        private Books Books;
        public Authors(Books books)
        {
            InitializeComponent();
            Books = books;
            FillDgvAuthors();
        }

        // Fill data grid view
        private void FillDgvAuthors()
        {
            DgvAuthors.Rows.Clear();
            List<Author> authors = db.Authors.OrderBy(a => a.Name).ToList();
            foreach (Author a in authors)
            {
                DgvAuthors.Rows.Add(a.Id, a.Name);
            }
        }

        // Bring info on click on header
        private void DgvAuthors_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                TxtName.Text = DgvAuthors.Rows[e.RowIndex].Cells[1].Value.ToString();
                BtnDelete.Visible = true;
                BtnUpdate.Visible = true;
                ClickedRow = e.RowIndex;
                ClickedId = Convert.ToInt32(DgvAuthors.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            catch
            {
                Reset();
            }
        }

        // Take all values back to their start point
        private void Reset()
        {
            BtnDelete.Visible = false;
            BtnUpdate.Visible = false;
            TxtName.ResetText();
            ClickedRow = -1;
            ClickedId = 0;
        }

        private void Authors_Click(object sender, EventArgs e)
        {
            Reset();
        }

        // Add an author
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            // Keep no empty place
            if (string.IsNullOrEmpty(TxtName.Text))
            {
                MessageBox.Show("Ad boş ola bilməz!");
                return;
            }
            // Do not create the same author again
            if(db.Authors.Any(a=>a.Name == TxtName.Text))
            {
                MessageBox.Show("Müəllif artıq mövcuddur!");
                return;
            }
            // If all OK, create the author
            Author author = new Author
            {
                Name = TxtName.Text
            };
            db.Authors.Add(author);
            db.SaveChanges();
            DgvAuthors.Rows.Add(author.Id, author.Name);
            MessageBox.Show("Müəllif əlavə olundu...");
            Reset();
        }

        // Update an existing author
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            // Keep no empty place
            if (string.IsNullOrEmpty(TxtName.Text))
            {
                MessageBox.Show("Ad boş ola bilməz!");
                return;
            }
            // Do not create the same author again
            if (db.Authors.Any(a => a.Name == TxtName.Text && a.Id != ClickedId))
            {
                MessageBox.Show("Müəllif artıq mövcuddur!");
                return;
            }
            Author author = db.Authors.Find(ClickedId);
            author.Name = TxtName.Text;
            db.SaveChanges();
            DgvAuthors.Rows[ClickedRow].Cells[1].Value = author.Name;
            MessageBox.Show("Kitab yeniləndi...");
            Reset();
        }

        // Delete an author
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Müəllif silinsin? Bu zaman ona aid kitablar da silinəcək!", "Sil", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
            {
                Author author = db.Authors.Find(ClickedId);
                db.Authors.Remove(author);
                db.SaveChanges();
                DgvAuthors.Rows.RemoveAt(ClickedRow);
                MessageBox.Show("Müəllif silindi...");
                Reset();
                Books.FillDgvBooks();
            }
        }

        // Set the authors closed to prevent it opening twice or more...
        private void Authors_FormClosed(object sender, FormClosedEventArgs e)
        {
            Books.AuthorsIsOpen = false;
            Books.FillCmbAuthors();
        }
    }
}
