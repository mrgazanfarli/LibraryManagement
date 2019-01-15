namespace LibraryManagment
{
    partial class MainBoard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainBoard));
            this.PnlMain = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.LblExit = new System.Windows.Forms.Label();
            this.LblUsers = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LblAdd = new System.Windows.Forms.Label();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnLogout = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnUsers = new System.Windows.Forms.Button();
            this.BtnClients = new System.Windows.Forms.Button();
            this.BtnBooks = new System.Windows.Forms.Button();
            this.PnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlMain
            // 
            resources.ApplyResources(this.PnlMain, "PnlMain");
            this.PnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(189)))), ((int)(((byte)(64)))));
            this.PnlMain.Controls.Add(this.LblAdd);
            this.PnlMain.Controls.Add(this.BtnAdd);
            this.PnlMain.Controls.Add(this.label3);
            this.PnlMain.Controls.Add(this.BtnLogout);
            this.PnlMain.Controls.Add(this.LblExit);
            this.PnlMain.Controls.Add(this.BtnExit);
            this.PnlMain.Controls.Add(this.LblUsers);
            this.PnlMain.Controls.Add(this.BtnUsers);
            this.PnlMain.Controls.Add(this.label2);
            this.PnlMain.Controls.Add(this.BtnClients);
            this.PnlMain.Controls.Add(this.label1);
            this.PnlMain.Controls.Add(this.BtnBooks);
            this.PnlMain.Name = "PnlMain";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(211)))));
            this.label3.Name = "label3";
            this.label3.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // LblExit
            // 
            resources.ApplyResources(this.LblExit, "LblExit");
            this.LblExit.BackColor = System.Drawing.Color.Transparent;
            this.LblExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LblExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(211)))));
            this.LblExit.Name = "LblExit";
            this.LblExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // LblUsers
            // 
            resources.ApplyResources(this.LblUsers, "LblUsers");
            this.LblUsers.BackColor = System.Drawing.Color.Transparent;
            this.LblUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LblUsers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(211)))));
            this.LblUsers.Name = "LblUsers";
            this.LblUsers.Click += new System.EventHandler(this.BtnUsers_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(211)))));
            this.label2.Name = "label2";
            this.label2.Click += new System.EventHandler(this.BtnClients_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(211)))));
            this.label1.Name = "label1";
            this.label1.Click += new System.EventHandler(this.BtnBooks_Click);
            // 
            // LblAdd
            // 
            resources.ApplyResources(this.LblAdd, "LblAdd");
            this.LblAdd.BackColor = System.Drawing.Color.Transparent;
            this.LblAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LblAdd.ForeColor = System.Drawing.Color.Snow;
            this.LblAdd.Name = "LblAdd";
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.BtnAdd, "BtnAdd");
            this.BtnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAdd.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.BtnAdd.FlatAppearance.BorderSize = 0;
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnLogout
            // 
            resources.ApplyResources(this.BtnLogout, "BtnLogout");
            this.BtnLogout.BackColor = System.Drawing.Color.Transparent;
            this.BtnLogout.BackgroundImage = global::LibraryManagment.Properties.Resources.Logout;
            this.BtnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLogout.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.BtnLogout.FlatAppearance.BorderSize = 0;
            this.BtnLogout.Name = "BtnLogout";
            this.BtnLogout.UseVisualStyleBackColor = false;
            this.BtnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // BtnExit
            // 
            resources.ApplyResources(this.BtnExit, "BtnExit");
            this.BtnExit.BackColor = System.Drawing.Color.Snow;
            this.BtnExit.BackgroundImage = global::LibraryManagment.Properties.Resources.Door;
            this.BtnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnExit.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.BtnExit.FlatAppearance.BorderSize = 0;
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnUsers
            // 
            this.BtnUsers.BackColor = System.Drawing.Color.Snow;
            resources.ApplyResources(this.BtnUsers, "BtnUsers");
            this.BtnUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnUsers.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.BtnUsers.FlatAppearance.BorderSize = 0;
            this.BtnUsers.Name = "BtnUsers";
            this.BtnUsers.UseVisualStyleBackColor = false;
            this.BtnUsers.Click += new System.EventHandler(this.BtnUsers_Click);
            // 
            // BtnClients
            // 
            this.BtnClients.BackColor = System.Drawing.Color.Snow;
            this.BtnClients.BackgroundImage = global::LibraryManagment.Properties.Resources.Readers;
            resources.ApplyResources(this.BtnClients, "BtnClients");
            this.BtnClients.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClients.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.BtnClients.FlatAppearance.BorderSize = 0;
            this.BtnClients.Name = "BtnClients";
            this.BtnClients.UseVisualStyleBackColor = false;
            this.BtnClients.Click += new System.EventHandler(this.BtnClients_Click);
            // 
            // BtnBooks
            // 
            this.BtnBooks.BackColor = System.Drawing.Color.Snow;
            this.BtnBooks.BackgroundImage = global::LibraryManagment.Properties.Resources.bookshelf;
            resources.ApplyResources(this.BtnBooks, "BtnBooks");
            this.BtnBooks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBooks.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.BtnBooks.FlatAppearance.BorderSize = 0;
            this.BtnBooks.Name = "BtnBooks";
            this.BtnBooks.UseVisualStyleBackColor = false;
            this.BtnBooks.Click += new System.EventHandler(this.BtnBooks_Click);
            // 
            // MainBoard
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.Controls.Add(this.PnlMain);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.MaximizeBox = false;
            this.Name = "MainBoard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainBoard_FormClosed);
            this.PnlMain.ResumeLayout(false);
            this.PnlMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PnlMain;
        private System.Windows.Forms.Button BtnBooks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnClients;
        private System.Windows.Forms.Button BtnUsers;
        private System.Windows.Forms.Label LblUsers;
        private System.Windows.Forms.Label LblExit;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnLogout;
        private System.Windows.Forms.Label LblAdd;
        private System.Windows.Forms.Button BtnAdd;
    }
}

