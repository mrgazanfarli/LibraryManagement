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

namespace LibraryManagment
{
    public partial class MainBoard : Form
    {
        private readonly LibraryEntities db = new LibraryEntities();
        private int UserId;
        public MainBoard(int userId)
        {
            InitializeComponent();
            UserId = userId;
        }

        private void MainBoard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
