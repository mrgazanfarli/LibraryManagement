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
using LibraryManagment.Forms;

namespace LibraryManagment.Forms
{
    public partial class ReturnLostBook : Form
    {
        private readonly LibraryEntities db = new LibraryEntities();
        private User User;
        private int ReservId;
        private Reservations Reservations;
        public ReturnLostBook(Reservations reservations, User user, int reservId)
        {
            InitializeComponent();
            User = user;
            ReservId = reservId;
            Reservations = reservations;
        }

        // Enable the Radio Buttons according to the method selected...
        private void Rbtns_CheckedChanged(object sender, EventArgs e)
        {
            LblBookNotReturned.Visible = false;
            if (RbtnBookNotReturned.Checked)
            {
                LblBookNotReturned.Visible = true;
                LblBookNotReturned.Text = (db.Reservations.Find(ReservId).Book.Price*10).ToString("0.00") + " AZN təhvil aldıqdan sonra bitirin";
            }
            if (RbtnBookReturned.Checked)
            {
                LblBookNotReturned.Visible = false;
            }
        }

        // Finish the issue of the lost book...
        private void BtnFinish_Click(object sender, EventArgs e)
        {
            // Find the reservation by ID...
            Reservation res = db.Reservations.Find(ReservId);
            if(!RbtnBookReturned.Checked && !RbtnBookNotReturned.Checked)
            {
                MessageBox.Show("Seçim etmək məcburidir!");
                return;
            }
            if (RbtnBookNotReturned.Checked)
            {
                res.Penalty = res.Book.Price * 10;
                res.Book.Count--;
            }
            res.TakenBackBy = User.Id;
            res.TakenBackAt = DateTime.Now;
            db.SaveChanges();
            MessageBox.Show("Bitirildi...");
            // Update the Data Grid View in Reservations form...
            Reservations.DgvReservations.Rows[Reservations.ClickedRow].Cells[8].Value = res.User1.Name + " " + res.User1.Surname;
            Reservations.DgvReservations.Rows[Reservations.ClickedRow].Cells[9].Value = res.TakenBackAt?.ToString("dd.MM.yyyy");
            Reservations.DgvReservations.Rows[Reservations.ClickedRow].Cells[10].Value = res.Penalty?.ToString("0.00");
            Reservations.DgvReservations.Rows[Reservations.ClickedRow].Cells[11].Value = res.Case.Status;

            this.Close();
        }
    }
}
