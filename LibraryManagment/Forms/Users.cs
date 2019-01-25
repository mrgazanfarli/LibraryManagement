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
        private bool ShowPassword;
        private string[] CmbItems;
        private MainBoard Board;
        private User EnteredUser;
        public Users(MainBoard board, User enteredUser)
        {
            InitializeComponent();
            Board = board;
            EnteredUser = enteredUser;
            ShowPassword = false;
            CmbItems = new string[]
            {
                "Hamısı",
                "İdarəçilər",
                "İdarəçi olmayanlar"
            };
            FillCmbUsersShown();
            FillDgvUsers();
        }

        // Fill Combo Box of users...
        private void FillCmbUsersShown()
        {
            CmbUsersShown.Items.Clear();
            CmbUsersShown.Items.AddRange(CmbItems);
        }

        // Fill DataGridView taking into account the selection of the user...
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

        #region CRUD of Users...

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
            // Do not allow spaces in usernames...
            if(TxtUsername.Text.Contains(' '))
            {
                MessageBox.Show("İstifadəçi adında boşluq istifadə etməyin!");
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
            // Do not allow spaces in usernames...
            if (TxtUsername.Text.Contains(' '))
            {
                MessageBox.Show("İstifadəçi adında boşluq istifadə etməyin!");
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
            if(clickedId == EnteredUser.Id)
            {
                MessageBox.Show("Yenidən giriş edin...");
                foreach (Form form in Application.OpenForms)
                {
                    form.Hide();
                }
                Login login = new Login();
                login.Show();
                return;
            }
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

        // Delete selected user...
        private void BtnDeleteUser_Click(object sender, EventArgs e)

        {
            // First assume that the user exactly wants to delete
            DialogResult r = MessageBox.Show("İstifadəçini silməyə əminsiniz? Bu zaman istifadəçi haqqında bütün məlumatlar silinəcək", "Sil", MessageBoxButtons.YesNo);
            // and then, start to delete
            if (r == DialogResult.Yes)
            {
                User user = db.Users.Find(clickedId);
                // First manually remove all reservations related to this user. Because user (only one) is nullable, and returns an error on deleting...
                List<Reservation> reservs = db.Reservations.Where(re => re.User.Id == user.Id || re.User1.Id == user.Id).ToList();
                foreach (Reservation res in reservs)
                {
                    db.Reservations.Remove(res);
                }
                // Then delete the user itself...
                db.Users.Remove(user);
                db.SaveChanges();
                // Update DGV
                DgvUsers.Rows.RemoveAt(clickedRow);
                // Done with DGV
                MessageBox.Show("İstifadəçi silindi...");
                Reset();
            }

        }

        #endregion

        // Fill DataGridView according to the CmbUsersShown
        private void CmbUsersShown_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillDgvUsers();
        }

        // Reset values on click of the form itself...
        private void Users_Click(object sender, EventArgs e)
        {
            Reset();
        }

        // Declare this form to be closed. See the reason in MainBoard.cs
        private void Users_FormClosed(object sender, FormClosedEventArgs e)
        {
            Board.UserIsOpen = false;
            Board.CreateLateBooksPanels();
        }

        // Function of showing password...
        private void BtnShowPassword_Click(object sender, EventArgs e)
        {
            if (!ShowPassword)
            {
                TxtPassword.UseSystemPasswordChar = false;
                BtnShowPassword.BackgroundImage = Properties.Resources.EyeOrange;
                ShowPassword = true;
            }
            else
            {
                TxtPassword.UseSystemPasswordChar = true;
                BtnShowPassword.BackgroundImage = Properties.Resources.Eye;
                ShowPassword = false;
            }
        }

        private void BtnGetBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
