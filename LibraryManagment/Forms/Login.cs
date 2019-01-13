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
    public partial class Login : Form
    {
        private readonly LibraryEntities db = new LibraryEntities();
        public Login()
        {
            InitializeComponent();
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
                return;
            }
            else
            {
                int UserId = db.Users.First(u => u.Username == TxtUsername.Text).Id;
                MainBoard form = new MainBoard(UserId);
                form.Show();
                this.Hide();
            }
        }
    }
}
