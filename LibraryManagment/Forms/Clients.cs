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
using System.Globalization;

namespace LibraryManagment.Forms
{
    public partial class Clients : Form
    {
        private readonly LibraryEntities db = new LibraryEntities();
        private int clickedId;
        private int clickedRow;
        private User User;
        private CultureInfo CultureInfo;
        private string[] CmbItems;
        private MainBoard Board;
        public Clients(User user, MainBoard board)
        {
            InitializeComponent();
            User = user;
            Board = board;
            CmbItems = new string[]
            {
                "Hamısı",
                "Borclular",
                "Borclu olmayanlar"
            };
            FillDgvClients();
            FillCmbShowClients();
            CultureInfo = new System.Globalization.CultureInfo("az-AZ");
        }

        // Generating a random client number...
        private string GenerateClientNumber()
        {
            string ClientNumber;
            do
            {
                Random rnd = new Random();
                ClientNumber = DateTime.Now.ToString("yy") + DateTime.Now.Millisecond * 47 + rnd.Next(10, 99);
                if (ClientNumber.Length > 7)
                {
                    while (ClientNumber.Length > 7)
                    {
                        ClientNumber = ClientNumber.Remove(ClientNumber.Length - 1);
                    }
                }
                if (ClientNumber.Length < 7)
                {
                    while (ClientNumber.Length != 7)
                    {
                        Random r = new Random();
                        ClientNumber += r.Next(1, 10);
                    }
                }
            }
            while (db.Clients.Any(c => c.ClientNumber == ClientNumber));
            return ClientNumber;
        }

        // Fill combo box clients...
        private void FillCmbShowClients()
        {
            CmbShowClients.Items.Clear();
            CmbShowClients.Items.AddRange(CmbItems);
        }

        // Fill data grid view...
        private void FillDgvClients()
        {
            DgvClients.Rows.Clear();
            List<Client> clients = new List<Client>();
            if (CmbShowClients.SelectedItem == null || CmbShowClients.SelectedIndex == 0)
            {
                clients = db.Clients.OrderByDescending(c => c.Surname).ToList();
            }
            if (CmbShowClients.SelectedIndex == 1)
            {
                // Select those who have at least one book that was taken but not given back yet...
                clients = db.Clients.Where(c => c.Reservations.Any(r => r.TakenBackAt == null && r.GivenAt != null)).ToList();
            }
            if (CmbShowClients.SelectedIndex == 2)
            {
                // Select those who did not take a book or gave back all books that was taken (takenbackat is not null in this case)...
                clients = db.Clients.Where(c => c.Reservations.Count() == 0 || !c.Reservations.Any(r => r.GivenAt != null && r.TakenBackAt == null)).ToList(); 
            }

            foreach (Client client in clients)
            {
                DgvClients.Rows.Add(client.Id, client.Name, client.Surname, client.Phone, client.ClientNumber, client.User.Name + " " + client.User.Surname, client.CreatedAt.ToString("dd.MM.yyyy"), client.Reservations.Where(r => r.TakenBackAt == null).Count() + "/" + client.BookLimit);
            }
        }

        // Resets all values to default...
        private void Reset()
        {
            TxtName.ResetText();
            TxtSurname.ResetText();
            TxtPhone.ResetText();
            BtnDeleteClient.Visible = false;
            BtnUpdateClient.Visible = false;
            NumBookLimit.Value = 3;
            clickedId = 0;
            clickedRow = -1;
        }

        // Take all values on click...
        private void DgvClients_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Do not give an error when the row index not found (clicking the last empty row in Dgv)
            try
            {
                // Take the clicked row in order to update the row when deleting, updating (no need to call FillDgvClients() again)
                clickedId = Convert.ToInt32(DgvClients.Rows[e.RowIndex].Cells[0].Value.ToString());
                clickedRow = e.RowIndex;
                TxtName.Text = DgvClients.Rows[e.RowIndex].Cells[1].Value.ToString();
                TxtSurname.Text = DgvClients.Rows[e.RowIndex].Cells[2].Value.ToString();
                TxtPhone.Text = DgvClients.Rows[e.RowIndex].Cells[3].Value.ToString();
                NumBookLimit.Value = Convert.ToDecimal(DgvClients.Rows[e.RowIndex].Cells[7].Value.ToString().Split('/')[1]);
                BtnDeleteClient.Visible = true;
                BtnUpdateClient.Visible = true;
            }
            catch
            {
                Reset();
            }
        }

        #region CRUD of Clients...

        // When a client is added, validations are done and some other parameters are created...
        private void BtnAddClient_Click(object sender, EventArgs e)
        {
            // Check for empty places
            if (string.IsNullOrEmpty(TxtName.Text) || string.IsNullOrEmpty(TxtSurname.Text) || string.IsNullOrEmpty(TxtPhone.Text))
            {
                MessageBox.Show("Boş yer buraxmayın!");
                return;
            }

            Client cl = new Client
            {
                Name = TxtName.Text,
                Surname = TxtSurname.Text,
                Phone = TxtPhone.Text,
                WhoRegistered = User.Id,
                CreatedAt = DateTime.Now,
                ClientNumber = GenerateClientNumber(),
                BookLimit = Convert.ToInt32(NumBookLimit.Value),
            };
            db.Clients.Add(cl);
            db.SaveChanges();
            // Add new user to DgvUsers
            DgvClients.Rows.Add(cl.Id, cl.Name, cl.Surname, cl.Phone, cl.ClientNumber, db.Users.Find(cl.WhoRegistered).Name + " " + db.Users.Find(cl.WhoRegistered).Surname, cl.CreatedAt.ToString("dd.MM.yyyy"), cl.Reservations.Where(r => r.TakenBackAt == null).Count() + "/" + cl.BookLimit);
            MessageBox.Show("Oxucu əlavə olundu!");
            Reset();
        }

        // The same validations as in adding are done when updating a client's data
        private void BtnUpdateClient_Click(object sender, EventArgs e)
        {
            // Again check for empty places
            if (string.IsNullOrEmpty(TxtName.Text) || string.IsNullOrEmpty(TxtSurname.Text) || string.IsNullOrEmpty(TxtPhone.Text) || NumBookLimit.Value == 0)
            {
                MessageBox.Show("Boş yer buraxmayın!");
                return;
            }
            Client cl = db.Clients.Find(clickedId);
            cl.Name = TxtName.Text;
            cl.Surname = TxtSurname.Text;
            cl.Phone = TxtPhone.Text;
            cl.BookLimit = Convert.ToInt32(NumBookLimit.Value);
            db.SaveChanges();
            // Now update the Data Grid View
            DgvClients.Rows[clickedRow].Cells[1].Value = cl.Name;
            DgvClients.Rows[clickedRow].Cells[2].Value = cl.Surname;
            DgvClients.Rows[clickedRow].Cells[3].Value = cl.Phone;
            DgvClients.Rows[clickedRow].Cells[7].Value = cl.Reservations.Where(r => r.TakenBackAt == null).Count() + "/" + cl.BookLimit;
            // Finished
            MessageBox.Show("Oxucu məlumatları yeniləndi...");
            Reset();
        }

        private void BtnDeleteClient_Click(object sender, EventArgs e)
        {
            // First confirm user's request
            DialogResult r = MessageBox.Show("Oxucunu silməyə əminsinizmi? Bu zaman bu oxucu haqqında bütün məlumatlar silinəcək", "Sil", MessageBoxButtons.YesNo);
            // If he/she confirms, start deleting
            if (r == DialogResult.Yes)
            {
                Client cl = db.Clients.Find(clickedId);
                db.Clients.Remove(cl);
                db.SaveChanges();
                // Update DGV
                DgvClients.Rows.RemoveAt(clickedRow);
                // Finished
                MessageBox.Show("Oxucu silindi");
                Reset();
            }
        }

        #endregion

        private void CmbShowClients_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillDgvClients();
        }

        private void Clients_Click(object sender, EventArgs e)
        {
            Reset();
        }

        // Declare this form to be closed (see more in MainBoard.cs)
        private void Clients_FormClosed(object sender, FormClosedEventArgs e)
        {
            Board.ClientIsOpen = false;
            Board.CreateLateBooksPanels();
        }

        private void BtnGetBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
