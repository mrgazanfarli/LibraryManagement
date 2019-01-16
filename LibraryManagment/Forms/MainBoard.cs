using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryManagment.Forms;
using LibraryManagment.Models;

namespace LibraryManagment
{
    public partial class MainBoard : Form
    {
        private readonly LibraryEntities db = new LibraryEntities();
        private User User; // Take the user who logged in
        public bool BookIsOpen;
        public bool ClientIsOpen;
        public bool UserIsOpen;
        public MainBoard(User user)
        {
            InitializeComponent();
            BookIsOpen = false;
            ClientIsOpen = false;
            User = user;
            // if the user is boss, let him/her to see the CRUD of workers(users)...
            if (!User.IsBoss)
            {
                BtnUsers.Visible = false;
                LblUsers.Visible = false;
            }
        }

        // Prevent the application from running in the background after it is closed
        private void MainBoard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        // Open Books form
        private void BtnBooks_Click(object sender, EventArgs e)
        {
            //Create a Books form
            Books form = new Books(this, User);

            if (!BookIsOpen) // If Books form is not opened, open it.
            {
                form.Show();
                BookIsOpen = true; // Books is already opened
                return;
            }
            else
            {
                foreach (Form f in Application.OpenForms) // If Books is not opened, find the opened Books form
                {
                    if (f.GetType() == form.GetType())
                    {
                        f.BringToFront(); // Show the opened form
                        f.Activate();
                        return;
                    }
                }
            }
        }

        // Open Clients form
        private void BtnClients_Click(object sender, EventArgs e)
        {
            //Create a Clients form
            Clients form = new Clients(User,this);

            if (!ClientIsOpen) // If Clients form is not opened, open it.
            {
                form.Show();
                ClientIsOpen = true; // Clients is already opened
                return;
            }
            else
            {
                foreach (Form f in Application.OpenForms) // If Clients is not opened, find the opened Books form
                {
                    if (f.GetType() == form.GetType())
                    {
                        f.BringToFront(); // Show the opened form
                        return;
                    }
                }
            }
        }

        // Opening Users form
        private void BtnUsers_Click(object sender, EventArgs e)
        {
            //Create a Users form
            Users form = new Users(this);

            if (!UserIsOpen) // If Users form is not opened, open it.
            {
                form.Show();
                UserIsOpen = true; // Users is already opened
                return;
            }
            else
            {
                foreach (Form f in Application.OpenForms) // If Users is not opened, find the opened Books form
                {
                    if (f.GetType() == form.GetType())
                    {
                        f.BringToFront(); // Show the opened form
                        return;
                    }
                }
            }
        }

        // Exit
        private void BtnExit_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Proqram bağlanılsın?", "Çıxış", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        // Back to login and close all existing forms
        private void BtnLogout_Click(object sender, EventArgs e)
        {
            Login form = new Login();
            foreach (Form f in Application.OpenForms)
            {
                f.Hide();
            }
            form.Show();
        }

        // Give a book
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            AddReservation ReservForm = new AddReservation(User);
            ReservForm.ShowDialog();
        }
    }
}
