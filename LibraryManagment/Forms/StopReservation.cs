﻿using System;
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
    public partial class StopReservation : Form
    {
        private readonly LibraryEntities db = new LibraryEntities();
        private int ReservationId;
        private User User;
        private Reservation Reservation;
        public StopReservation(User user, int reservationId)
        {
            InitializeComponent();
            ReservationId = reservationId;
            User = user;
            Reservation = db.Reservations.Find(ReservationId);
            FillCmbBookStatusAndNumPenalty();
        }

        // Firstly, fill Combo Box and NumericUpDown from the statuses in the database...
        private void FillCmbBookStatusAndNumPenalty()
        {
            // Filling CmbBookStatus...
            List<Case> cases = db.Cases.ToList();
            CmbBookStatus.Items.Clear();
            foreach (Case c in cases)
            {
                CmbBookStatus.Items.Add(c.Id + "-" + c.Status);
            }

            // Filling NumPayment...
            if(Reservation.Penalty != null)
            {
                NumPenalty.Value = Convert.ToDecimal(Reservation.Penalty);
            }
            
        }

        // Decide what to do when different radio buttons are checked...
        private void RbtnNoOptions_CheckedChanged(object sender, EventArgs e)
        {
            NumPenalty.Enabled = false;
            LblLimitToReturn.Enabled = false;
            NumLimitToReturn.Enabled = false;
            if (RbtnGiveChance.Checked)
            {
                // Enable the items to set the days to return the book...
                LblLimitToReturn.Enabled = true;
                NumLimitToReturn.Enabled = true;
            }
            if (RbtnSetPayment.Checked)
            {
                // Enable the NumericUpDown to set paymeny for lost or damaged books...
                NumPenalty.Enabled = true;
            }
        }

        private void CmbBookStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            RbtnSetPayment.Enabled = false;
            RbtnNoOptions.Enabled = false;
            RbtnGiveChance.Enabled = false;
            // Reset the penalty value...
            if(Reservation.Penalty != null)
            {
                NumPenalty.Value = Convert.ToDecimal(Reservation.Penalty);
            }
            else
            {
                NumPenalty.Value = 0;
            }
            if (CmbBookStatus.SelectedIndex != -1 && CmbBookStatus.SelectedIndex != 0)
            {
                RbtnGiveChance.Enabled = true;
                RbtnNoOptions.Enabled = true;
                RbtnSetPayment.Enabled = true;
            }
            // If book was lost, then set the 10 times of book's price as a penalty and do not apply other penalties...
            if(CmbBookStatus.SelectedIndex == 3)
            {
                NumPenalty.Value = Reservation.Book.Price * 10;
                TxtComment.Text = "İtirilib!";
            }
            else
            {
                TxtComment.Text = "Normaldır.";
            }
        }

        // Decide what to do when the selected conditions are applied...
        private void BtnEndReservation_Click(object sender, EventArgs e)
        {
            if(CmbBookStatus.SelectedIndex == -1 || (RbtnGiveChance.Checked && NumLimitToReturn.Value == 0) || (RbtnSetPayment.Checked && NumPenalty.Value == 0) || string.IsNullOrEmpty(TxtComment.Text))
            {
                MessageBox.Show("Boş sahə buraxmayın!");
                return;
            }
            Reservation.Penalty = NumPenalty.Value;
            Reservation.BookStatus = Convert.ToInt32(CmbBookStatus.SelectedItem.ToString().Split('-')[0]);
            Reservation.Comment = TxtComment.Text;
            Reservation.TakenBackBy = User.Id;
            if(NumLimitToReturn.Value != 0)
            {
                Reservation.LimitToReturn = Convert.ToInt32(NumLimitToReturn.Value);
            }
            else
            {
                Reservation.TakenBackAt = DateTime.Now;
            }
            db.SaveChanges();
            MessageBox.Show("Kitab qaytarıldı...");
            this.Close();
        }
    }
}
