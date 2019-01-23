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
using LibraryManagment.Properties;

namespace LibraryManagment.Forms
{
    public partial class Login : Form
    {
        private readonly LibraryEntities db = new LibraryEntities();
        public Login()
        {
            InitializeComponent();
            TxtUsername.Text = "mrgazanfarli";
            TxtPassword.Text = "123";
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(TxtUsername.Text) || string.IsNullOrEmpty(TxtPassword.Text))
            {
                MessageBox.Show("Boş xana buraxmayın");
                return;
            }
            if(!db.Users.Any(u=> u.Username == TxtUsername.Text && u.Password == TxtPassword.Text))
            {
                MessageBox.Show("İstifadəçi adı və ya şifrə düzgün deyil!");
                PicLogin.Image = Resources.enter;
                return;
            }
            else
            {
                User User = db.Users.First(u => u.Username == TxtUsername.Text);
                MainBoard form = new MainBoard(User);
                form.Show();
                this.Hide();
            }
        }

        // Prevent the app running background when the user logs out and closes this form...
        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
