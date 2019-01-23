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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainBoard));
            this.PnlMain = new System.Windows.Forms.Panel();
            this.LblReservations = new System.Windows.Forms.Label();
            this.LblAdd = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LblExit = new System.Windows.Forms.Label();
            this.LblUsers = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnReservations = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnLogout = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnUsers = new System.Windows.Forms.Button();
            this.BtnClients = new System.Windows.Forms.Button();
            this.BtnBooks = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.PnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlMain
            // 
            this.PnlMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PnlMain.AutoSize = true;
            this.PnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(189)))), ((int)(((byte)(64)))));
            this.PnlMain.Controls.Add(this.LblReservations);
            this.PnlMain.Controls.Add(this.BtnReservations);
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
            this.PnlMain.Location = new System.Drawing.Point(0, 0);
            this.PnlMain.Name = "PnlMain";
            this.PnlMain.Size = new System.Drawing.Size(957, 100);
            this.PnlMain.TabIndex = 0;
            // 
            // LblReservations
            // 
            this.LblReservations.AutoSize = true;
            this.LblReservations.BackColor = System.Drawing.Color.Transparent;
            this.LblReservations.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LblReservations.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.LblReservations.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(211)))));
            this.LblReservations.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LblReservations.Location = new System.Drawing.Point(362, 79);
            this.LblReservations.Name = "LblReservations";
            this.LblReservations.Size = new System.Drawing.Size(91, 18);
            this.LblReservations.TabIndex = 15;
            this.LblReservations.Text = "Məlumatlar";
            this.LblReservations.AutoSizeChanged += new System.EventHandler(this.BtnReservations_Click);
            // 
            // LblAdd
            // 
            this.LblAdd.AutoSize = true;
            this.LblAdd.BackColor = System.Drawing.Color.Transparent;
            this.LblAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LblAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.LblAdd.ForeColor = System.Drawing.Color.Snow;
            this.LblAdd.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LblAdd.Location = new System.Drawing.Point(490, 79);
            this.LblAdd.Name = "LblAdd";
            this.LblAdd.Size = new System.Drawing.Size(76, 18);
            this.LblAdd.TabIndex = 11;
            this.LblAdd.Text = "Kitab Ver";
            this.LblAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(211)))));
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(753, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "Çıxış";
            this.label3.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // LblExit
            // 
            this.LblExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblExit.AutoSize = true;
            this.LblExit.BackColor = System.Drawing.Color.Transparent;
            this.LblExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LblExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.LblExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(211)))));
            this.LblExit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LblExit.Location = new System.Drawing.Point(866, 79);
            this.LblExit.Name = "LblExit";
            this.LblExit.Size = new System.Drawing.Size(50, 18);
            this.LblExit.TabIndex = 7;
            this.LblExit.Text = "Bağla";
            this.LblExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // LblUsers
            // 
            this.LblUsers.AutoSize = true;
            this.LblUsers.BackColor = System.Drawing.Color.Transparent;
            this.LblUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LblUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.LblUsers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(211)))));
            this.LblUsers.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LblUsers.Location = new System.Drawing.Point(266, 79);
            this.LblUsers.Name = "LblUsers";
            this.LblUsers.Size = new System.Drawing.Size(53, 18);
            this.LblUsers.TabIndex = 5;
            this.LblUsers.Text = "İşçilər";
            this.LblUsers.Click += new System.EventHandler(this.BtnUsers_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(211)))));
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(143, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Oxucular";
            this.label2.Click += new System.EventHandler(this.BtnClients_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(211)))));
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(33, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kitablar";
            this.label1.Click += new System.EventHandler(this.BtnBooks_Click);
            // 
            // BtnReservations
            // 
            this.BtnReservations.BackColor = System.Drawing.Color.Transparent;
            this.BtnReservations.BackgroundImage = global::LibraryManagment.Properties.Resources.database__2_;
            this.BtnReservations.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnReservations.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnReservations.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.BtnReservations.FlatAppearance.BorderSize = 0;
            this.BtnReservations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReservations.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnReservations.Location = new System.Drawing.Point(371, 5);
            this.BtnReservations.Name = "BtnReservations";
            this.BtnReservations.Size = new System.Drawing.Size(72, 72);
            this.BtnReservations.TabIndex = 14;
            this.BtnReservations.UseVisualStyleBackColor = false;
            this.BtnReservations.Click += new System.EventHandler(this.BtnReservations_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.Color.Transparent;
            this.BtnAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnAdd.BackgroundImage")));
            this.BtnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAdd.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.BtnAdd.FlatAppearance.BorderSize = 0;
            this.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdd.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnAdd.Location = new System.Drawing.Point(493, 6);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(68, 68);
            this.BtnAdd.TabIndex = 1;
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnLogout
            // 
            this.BtnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnLogout.BackColor = System.Drawing.Color.Transparent;
            this.BtnLogout.BackgroundImage = global::LibraryManagment.Properties.Resources.Logout1;
            this.BtnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLogout.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.BtnLogout.FlatAppearance.BorderSize = 0;
            this.BtnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogout.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnLogout.Location = new System.Drawing.Point(741, 5);
            this.BtnLogout.Name = "BtnLogout";
            this.BtnLogout.Size = new System.Drawing.Size(72, 72);
            this.BtnLogout.TabIndex = 5;
            this.BtnLogout.UseVisualStyleBackColor = false;
            this.BtnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnExit.BackColor = System.Drawing.Color.Transparent;
            this.BtnExit.BackgroundImage = global::LibraryManagment.Properties.Resources.Exit;
            this.BtnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnExit.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.BtnExit.FlatAppearance.BorderSize = 0;
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnExit.Location = new System.Drawing.Point(855, 5);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(72, 72);
            this.BtnExit.TabIndex = 6;
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnUsers
            // 
            this.BtnUsers.BackColor = System.Drawing.Color.Snow;
            this.BtnUsers.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnUsers.BackgroundImage")));
            this.BtnUsers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnUsers.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.BtnUsers.FlatAppearance.BorderSize = 0;
            this.BtnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUsers.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnUsers.Location = new System.Drawing.Point(256, 5);
            this.BtnUsers.Name = "BtnUsers";
            this.BtnUsers.Size = new System.Drawing.Size(72, 72);
            this.BtnUsers.TabIndex = 4;
            this.BtnUsers.UseVisualStyleBackColor = false;
            this.BtnUsers.Click += new System.EventHandler(this.BtnUsers_Click);
            // 
            // BtnClients
            // 
            this.BtnClients.BackColor = System.Drawing.Color.Snow;
            this.BtnClients.BackgroundImage = global::LibraryManagment.Properties.Resources.Readers;
            this.BtnClients.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnClients.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClients.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.BtnClients.FlatAppearance.BorderSize = 0;
            this.BtnClients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClients.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnClients.Location = new System.Drawing.Point(144, 5);
            this.BtnClients.Name = "BtnClients";
            this.BtnClients.Size = new System.Drawing.Size(72, 72);
            this.BtnClients.TabIndex = 3;
            this.BtnClients.UseVisualStyleBackColor = false;
            this.BtnClients.Click += new System.EventHandler(this.BtnClients_Click);
            // 
            // BtnBooks
            // 
            this.BtnBooks.BackColor = System.Drawing.Color.Snow;
            this.BtnBooks.BackgroundImage = global::LibraryManagment.Properties.Resources.bookshelf;
            this.BtnBooks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnBooks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBooks.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.BtnBooks.FlatAppearance.BorderSize = 0;
            this.BtnBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBooks.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnBooks.Location = new System.Drawing.Point(29, 5);
            this.BtnBooks.Name = "BtnBooks";
            this.BtnBooks.Size = new System.Drawing.Size(72, 72);
            this.BtnBooks.TabIndex = 2;
            this.BtnBooks.UseVisualStyleBackColor = false;
            this.BtnBooks.Click += new System.EventHandler(this.BtnBooks_Click);
            // 
            // MainBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(958, 412);
            this.Controls.Add(this.PnlMain);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainBoard";
            this.Text = "1";
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnLogout;
        private System.Windows.Forms.Label LblAdd;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Label LblExit;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Label LblReservations;
        private System.Windows.Forms.Button BtnReservations;
        private System.Windows.Forms.Timer timer1;
    }
}

