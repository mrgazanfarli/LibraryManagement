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
    public partial class Users : Form
    {
        private readonly LibraryEntities db = new LibraryEntities();
        private int clickedId;
        private int clickedRow;
        private string[] CmbItems;
        public Users()
        {
            InitializeComponent();
            CmbItems = new string[]
            {
                "Hamısı",
                "İdarəçilər",
                "İdarəçi olmayanlar"
            };
            FillCmbUsersShown();
            FillDgvUsers();
        }
        private void FillCmbUsersShown()
        {
            CmbUsersShown.Items.Clear();
            CmbUsersShown.Items.AddRange(CmbItems);
        }

        private void FillDgvUsers()
        {
            DgvUsers.Rows.Clear();
            List<User> users = new List<User>();
            if (CmbUsersShown.SelectedItem == null || CmbUsersShown.SelectedIndex == 0)
            {
                users = db.Users.OrderByDescending(u => u.Name).ToList();
            }
            if (CmbUsersShown.SelectedIndex == 1)
            {
                users = db.Users.Where(u => u.IsBoss).OrderByDescending(u => u.Name).ToList();
            }
            if (CmbUsersShown.SelectedIndex == 2)
            {
                users = db.Users.Where(u => !u.IsBoss).OrderByDescending(u => u.Name).ToList();
            }

            foreach (User user in users)
            {
                DgvUsers.Rows.Add(user.Id, user.Name, user.Surname, user.Username, user.Password, user.IsBoss ? "Bəli" : "Xeyr", user.Phone);
            }
        }

        // Reset Text Boxes and radio buttons. Set Id and row index 0 and -1
        private void Reset()
        {
            TxtName.ResetText();
            TxtSurname.ResetText();
            TxtUsername.ResetText();
            TxtPassword.ResetText();
            TxtPhone.ResetText();
            RbtnIsBoss.Checked = false;
            RbtnNotBoss.Checked = false;
            BtnDeleteUser.Visible = false;
            BtnUpdateUser.Visible = false;
            clickedId = 0;
            clickedRow = -1;
        }

        // Fill all values and get clicked row (and Id) when the row header is clicked
        private void DgvUsers_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Do not give an error when the row index not found (clicking the last empty row in Dgv)
            try
            {
                // Take the clicked row in order to update the row when deleting, updating (no need to call FillDgvUsers() again)
                clickedId = Convert.ToInt32(DgvUsers.Rows[e.RowIndex].Cells[0].Value.ToString());
                clickedRow = e.RowIndex;
                TxtName.Text = DgvUsers.Rows[e.RowIndex].Cells[1].Value.ToString();
                TxtSurname.Text = DgvUsers.Rows[e.RowIndex].Cells[2].Value.ToString();
                TxtUsername.Text = DgvUsers.Rows[e.RowIndex].Cells[3].Value.ToString();
                TxtPassword.Text = DgvUsers.Rows[e.RowIndex].Cells[4].Value.ToString();
                if (DgvUsers.Rows[e.RowIndex].Cells[5].Value.ToString() == "Bəli")
                {
                    RbtnIsBoss.Checked = true;
                }
                if(DgvUsers.Rows[e.RowIndex].Cells[5].Value.ToString() == "Xeyr")
                {
                    RbtnNotBoss.Checked = true;
                }
                TxtPhone.Text = DgvUsers.Rows[e.RowIndex].Cells[6].Value.ToString();
            }
            catch
            {
                Exception ClickedLastRow = new KeyNotFoundException();
                Reset();
            }
            BtnUpdateUser.Visible = true;
            BtnDeleteUser.Visible = true;
        }

        // Check if the user details are correct or not, and the add the user to database, and bring it to the DgvUsers
        private void BtnAddUser_Click(object sender, EventArgs e)
        {
            // Check for empty places
            if (string.IsNullOrEmpty(TxtName.Text) || string.IsNullOrEmpty(TxtSurname.Text) || string.IsNullOrEmpty(TxtUsername.Text) || string.IsNullOrEmpty(TxtPassword.Text) || string.IsNullOrEmpty(TxtPhone.Text) || (!RbtnIsBoss.Checked && !RbtnNotBoss.Checked))
            {
                MessageBox.Show("Boş yer buraxmayın!");
                return;
            }
            // Do not allow the username to be repeated
            if (db.Users.Any(u => u.Username == TxtUsername.Text))
            {
                MessageBox.Show("İstifadəçi adı artıq mövcuddur!");
                TxtUsername.ResetText();
                return;
            }

            User user = new User
            {
                Name = TxtName.Text,
                Surname = TxtSurname.Text,
                Username = TxtUsername.Text,
                Password = TxtPassword.Text,
                IsBoss = RbtnIsBoss.Checked ? true : false,
                Phone = TxtPhone.Text
            };
            db.Users.Add(user);
            db.SaveChanges();
            // Add new user to DgvUsers
            DgvUsers.Rows.Add(user.Id, user.Name, user.Surname, user.Username, user.Password, user.IsBoss ? "Bəli" : "Xeyr", user.Phone);
            MessageBox.Show("İstifadəçi əlavə olundu!");
            Reset();
        }

        // Check if the user details are correct or not, and the update the user in the database, and update the DgvUsers, too
        private void BtnUpdateUser_Click(object sender, EventArgs e)
        {
            // Check for empty places
            if (string.IsNullOrEmpty(TxtName.Text) || string.IsNullOrEmpty(TxtSurname.Text) || string.IsNullOrEmpty(TxtUsername.Text) || string.IsNullOrEmpty(TxtPassword.Text) || (!RbtnIsBoss.Checked && !RbtnNotBoss.Checked))
            {
                MessageBox.Show("Boş yer buraxmayın!");
                return;
            }
            // Do not allow the username to be repeated
            if (db.Users.Any(u => u.Username == TxtUsername.Text && u.Id != clickedId))
            {
                MessageBox.Show("İstifadəçi adı artıq mövcuddur!");
                TxtUsername.ResetText();
                return;
            }
            User user = db.Users.Find(clickedId);
            user.Name = TxtName.Text;
            user.Surname = TxtSurname.Text;
            user.Username = TxtUsername.Text;
            user.Password = TxtPassword.Text;
            user.IsBoss = RbtnIsBoss.Checked ? true : false;
            user.Phone = TxtPhone.Text;
            db.SaveChanges();
            // Update the data grid view
            DgvUsers.Rows[clickedRow].Cells[1].Value = user.Name;
            DgvUsers.Rows[clickedRow].Cells[2].Value = user.Surname;
            DgvUsers.Rows[clickedRow].Cells[3].Value = user.Username;
            DgvUsers.Rows[clickedRow].Cells[4].Value = user.Password;
            DgvUsers.Rows[clickedRow].Cells[5].Value = user.IsBoss ? "Bəli" : "Xeyr";
            DgvUsers.Rows[clickedRow].Cells[6].Value = user.Phone;
            // Finished with Dgv
            MessageBox.Show("İstifadəçi yeniləndi...");
            Reset();
        }

        private void BtnDeleteUser_Click(object sender, EventArgs e)

        {
            // First assume that the user exactly wants to delete
            DialogResult r = MessageBox.Show("İstifadəçini silməyə əminsiniz? Bu zaman istifadəçi haqqında bütün məlumatlar silinəcək", "Sil", MessageBoxButtons.YesNo);
            // and then, start to delete
            if (r == DialogResult.Yes)
            {
                User user = db.Users.Find(clickedId);
                db.Users.Remove(user);
                db.SaveChanges();
                // Update DGV
                DgvUsers.Rows.RemoveAt(clickedRow);
                // Done with DGV
                MessageBox.Show("İstifadəçi silindi...");
                Reset();
            }

        }

        private void CmbUsersShown_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillDgvUsers();
        }

        private void Users_Click(object sender, EventArgs e)
        {
            Reset();
        }
    }
}
