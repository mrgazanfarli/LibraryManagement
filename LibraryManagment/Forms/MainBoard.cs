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
        private LibraryEntities db = new LibraryEntities();
        private User User; // Take the user who logged in
        protected internal bool BookIsOpen;
        protected internal bool ClientIsOpen;
        protected internal bool UserIsOpen;
        protected internal bool ReservationsIsOpen;
        public MainBoard(User user)
        {
            InitializeComponent();
            BookIsOpen = false;
            ClientIsOpen = false;
            ReservationsIsOpen = false;
            UserIsOpen = false;
            User = user;
            // if the user is boss, let him/her to see the CRUD of workers(users), and Data of Reservations...
            if (!User.IsBoss)
            {
                BtnReservations.Visible = false;
                LblReservations.Visible = false;
                BtnUsers.Visible = false;
                LblUsers.Visible = false;
                BtnAdd.Location = new Point(256, 5);
                LblAdd.Location = new Point(254, 79);
            }
            CreateLateBooksPanels();
        }

        #region Opening Main Forms on click of buttons...

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
            Users form = new Users(this, User);

            if (!UserIsOpen) // If Users form is not opened, open it.
            {
                form.Show();
                UserIsOpen = true; // Users is already opened
                return;
            }
            else
            {
                foreach (Form f in Application.OpenForms) // If Users is not opened, find the opened Users form
                {
                    if (f.GetType() == form.GetType())
                    {
                        f.BringToFront(); // Show the opened form
                        return;
                    }
                }
            }
        }

        private void BtnReservations_Click(object sender, EventArgs e)
        {
            Reservations form = new Reservations(this, User);

            if (!ReservationsIsOpen) // If Reservations form is not opened, open it.
            {
                form.Show();
                ReservationsIsOpen = true; // Reservations is already opened
                return;
            }
            else
            {
                foreach (Form f in Application.OpenForms) // If Reservations is not opened, find the opened Reservations form
                {
                    if (f.GetType() == form.GetType())
                    {
                        f.BringToFront(); // Show the opened form
                        return;
                    }
                }
            }
        }

        #endregion

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

        // Prevent the application from running in the background after it is closed
        private void MainBoard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        // Create panels dynamically...
        protected internal void CreateLateBooksPanels()
        {
            db = new LibraryEntities();
            // Create the list of late reservations...
            List<Reservation> LateReservations = new List<Reservation>();
            // Take the unreturned book reservations...
            List<Reservation> UnreturnedReservations = db.Reservations.Where(r => r.TakenBackAt == null && r.LimitToReturn == null).ToList();
            // Select the late reservations...
            foreach (Reservation reservation in UnreturnedReservations)
            {
                if (reservation.GivenAt.AddDays(Convert.ToDouble(reservation.Interval)) < DateTime.Now)
                {
                    LateReservations.Add(reservation);
                }
            }
            // Get number of late reservations...
            double NumberOfUnreturnedBooks = LateReservations.Count();
            // Determine the size of the main panel... Each subpanel takes 96pt...
            int MainPanelYSize = Convert.ToInt32(Math.Ceiling(NumberOfUnreturnedBooks / 5) * 96 + 16);
            
            // Check if the panel already exists or not... If it does, remove it...
            foreach (Panel item in this.Controls)
            {
                if(item.Name == "MainPanel")
                {
                    this.Controls.Remove(item);
                }
            }
            // Create main Panel...
            Panel MainPanel = new Panel
            {
                Size = new Size(1228, MainPanelYSize),
                Location = new Point(80, 154),
                BackColor = Color.FromArgb(82, 90, 39),
                Name = "MainPanel"
            };
            this.Controls.Add(MainPanel);

            // Set initial locations and number of panels created...
            int XLocation = 20;
            int YLocation = 16;
            int PanelCount = 0;

            foreach (Reservation res in UnreturnedReservations)
            {
                // Create a panel for each of the late reservations...
                Panel panel = new Panel
                {
                    Size = new Size(220, 80),
                    Location = new Point(XLocation, YLocation),
                    Name = res.Id.ToString(),
                    BackColor = Color.FromArgb(82, 90, 39),
                    Cursor = Cursors.Hand
                };
                panel.Click += OpenLateReservation;
                // Create picture box of the subpanel...
                PictureBox pic = new PictureBox
                {
                    Name = res.Id.ToString(),
                    Size = new Size(67, 67),
                    Location = new Point(4, 5),
                    Image = Properties.Resources.notebook__1_,
                    Cursor = Cursors.Hand
                };
                pic.Click += OpenLateReservation;
                panel.Controls.Add(pic);

                #region Create Labels of the subpanel...
                Label lbl = new Label
                {
                    Name = res.Id.ToString(),
                    AutoSize = false,
                    Size = new Size(142, 18),
                    Text = res.Client.Name,
                    Location = new Point(76, 6),
                    ForeColor = Color.White,
                    Cursor = Cursors.Hand
                };
                lbl.Click += OpenLateReservation;
                panel.Controls.Add(lbl);

                Label lbl1 = new Label
                {
                    Name = res.Id.ToString(),
                    AutoSize = false,
                    Size = new Size(142, 18),
                    Text = res.Client.Surname,
                    Location = new Point(76, 24),
                    ForeColor = Color.White,
                    Cursor = Cursors.Hand
                };
                lbl1.Click += OpenLateReservation;
                panel.Controls.Add(lbl1);

                Label lbl2 = new Label
                {
                    Name = res.Id.ToString(),
                    AutoSize = false,
                    Size = new Size(142, 18),
                    Text = res.Book.Name,
                    Location = new Point(76, 41),
                    ForeColor = Color.White,
                    Cursor = Cursors.Hand
                };
                lbl2.Click += OpenLateReservation;
                panel.Controls.Add(lbl2);

                Label lbl3 = new Label
                {
                    Name = res.Id.ToString(),
                    AutoSize = false,
                    Size = new Size(142, 18),
                    Text = "Gecikir: " + -Math.Floor(res.GivenAt.AddDays(Convert.ToDouble(res.Interval)).Subtract(DateTime.Now).TotalDays) + " gün",
                    Location = new Point(76, 59),
                    ForeColor = Color.White,
                    Cursor = Cursors.Hand
                };
                lbl3.Click += OpenLateReservation;
                panel.Controls.Add(lbl3);

                #endregion

                // After creating the subpanel, add it to the main panel...
                MainPanel.Controls.Add(panel);
                // Take into account the sizes...
                PanelCount++;
                if (PanelCount % 5 == 0)
                {
                    XLocation = 20;
                    YLocation += 96;
                }
                else
                {
                    XLocation += 240;
                }
            }
        }


        // Create the event when clicking the late reservation panel...
        private void OpenLateReservation(object sender, EventArgs e)
        {
            Panel pnl = new Panel();
            Label lbl = new Label();
            PictureBox picbox = new PictureBox();
            int ReservId;
            if(sender.GetType() == pnl.GetType())
            {
                Panel clicked = sender as Panel;
                ReservId = Convert.ToInt32(clicked.Name);
                StopReservation form = new StopReservation(this, User, ReservId);
                form.ShowDialog();
            }
            if (sender.GetType() == lbl.GetType())
            {
                Label clicked = sender as Label;
                ReservId = Convert.ToInt32(clicked.Name);
                StopReservation form = new StopReservation(this, User, ReservId);
                form.ShowDialog();
            }
            if (sender.GetType() == picbox.GetType())
            {
                PictureBox clicked = sender as PictureBox;
                ReservId = Convert.ToInt32(clicked.Name);
                StopReservation form = new StopReservation(this, User, ReservId);
                form.ShowDialog();
            }
        }

        // Set Penalties for reservations automatically...
        private void TmrSetPenalties_Tick(object sender, EventArgs e)
        {
            db = new LibraryEntities();
            // Take all untaken books...
            List<Reservation> reservs = db.Reservations.Where(r => r.TakenBackAt == null).ToList();
            foreach (Reservation reservation in reservs)
            {
                if (reservation.GivenAt.AddDays(Convert.ToDouble(reservation.Interval)) < DateTime.Now)
                {
                    // Set penalty for each delaying days...
                    TimeSpan diff = -reservation.GivenAt.AddDays(Convert.ToDouble(reservation.Interval)).Subtract(DateTime.Now);
                    reservation.Penalty = reservation.Book.Price * 0.1M * Convert.ToDecimal(diff.TotalDays);
                    db.SaveChanges();
                }
            }
        }
    }
}
