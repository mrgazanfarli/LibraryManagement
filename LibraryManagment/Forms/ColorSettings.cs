using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagment.Forms
{
    public partial class ColorSettings : Form
    {
        private MainBoard MainBoard;
        private Color MainBoardBackColor;
        private Color NavPanelColor;
        private Color LateBookPanelColor;
        private Color LateBookColor;

        public ColorSettings(MainBoard mainBoard)
        {
            InitializeComponent();
            MainBoard = mainBoard;
            SetColors();
        }

        // Firstly, set the colors of the elements in MainBoard...
        private void SetColors()
        {
            BtnMainBoardBackColor.BackColor = MainBoard.BackColor;
            MainBoardBackColor = MainBoard.BackColor;
            BtnNavigationPanelColor.BackColor = MainBoard.PnlNavigation.BackColor;
            NavPanelColor = MainBoard.PnlNavigation.BackColor;
            if (MainBoard.CreatedLateBooksPanel)
            {
                // Find the dynamically created panel...
                BtnLateBooksPanelColor.BackColor = ((Panel)MainBoard.Controls.Find("MainPanel", true)[0]).BackColor;
                LateBookPanelColor = BtnLateBooksPanelColor.BackColor;
            }
        }

        #region Get Back colors of the form and panels...

        private void BtnMainBoardBackColor_Click(object sender, EventArgs e)
        {
            DialogResult r = ClrMainBoardBack.ShowDialog();
            if (r == DialogResult.OK)
            {
                MainBoardBackColor = ClrMainBoardBack.Color;
                BtnMainBoardBackColor.BackColor = MainBoardBackColor;
            }
        }

        private void BtnLateBooksPanelColor_Click(object sender, EventArgs e)
        {
            DialogResult r = ClrLateBooksPanel.ShowDialog();
            if (r == DialogResult.OK)
            {
                LateBookPanelColor = ClrLateBooksPanel.Color;
                BtnLateBooksPanelColor.BackColor = LateBookPanelColor;
            }
        }

        private void BtnNavigationPanelColor_Click(object sender, EventArgs e)
        {
            DialogResult r = ClrNavigationPanel.ShowDialog();
            if (r == DialogResult.OK)
            {
                NavPanelColor = ClrNavigationPanel.Color;
                BtnNavigationPanelColor.BackColor = NavPanelColor;
            }
        }

        private void BtnLateBookColor_Click(object sender, EventArgs e)
        {
            DialogResult r = ClrLateBook.ShowDialog();
            if (r == DialogResult.OK)
            {
                LateBookColor = ClrLateBook.Color;
                BtnLateBookColor.BackColor = LateBookColor;
            }
        }

        #endregion

        // On save, change all the colors, no matter if there was a change or not...
        private void BtnSave_Click(object sender, EventArgs e)
        {
            MainBoard.BackColor = MainBoardBackColor;
            MainBoard.PnlNavigation.BackColor = NavPanelColor;
            // Again find the panel and label which were created dynamically...
            Panel LateBooksPanel = (Panel)MainBoard.Controls.Find("MainPanel", true)[0];
            Label MainLabelOfLateBooksPanel = (Label)MainBoard.Controls.Find("LateBooksLabel", true)[0];
            MainLabelOfLateBooksPanel.ForeColor = LateBookPanelColor;
            LateBooksPanel.BackColor = LateBookPanelColor;
            foreach (Panel panel in LateBooksPanel.Controls.OfType <Panel>())
            {
                panel.BackColor = LateBookColor;
            }
            this.Close();
        }

        private void BtnDiscard_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
