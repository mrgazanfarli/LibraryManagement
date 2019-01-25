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
            this.PnlNavigation = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnResetColors = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnColorSettings = new System.Windows.Forms.Button();
            this.LblReservations = new System.Windows.Forms.Label();
            this.BtnReservations = new System.Windows.Forms.Button();
            this.LblAdd = new System.Windows.Forms.Label();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnLogout = new System.Windows.Forms.Button();
            this.LblExit = new System.Windows.Forms.Label();
            this.BtnExit = new System.Windows.Forms.Button();
            this.LblUsers = new System.Windows.Forms.Label();
            this.BtnUsers = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnClients = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnBooks = new System.Windows.Forms.Button();
            this.TmrSetPenalties = new System.Windows.Forms.Timer(this.components);
            this.PnlNavigation.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlNavigation
            // 
            this.PnlNavigation.AutoSize = true;
            this.PnlNavigation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(189)))), ((int)(((byte)(64)))));
            this.PnlNavigation.Controls.Add(this.label5);
            this.PnlNavigation.Controls.Add(this.BtnResetColors);
            this.PnlNavigation.Controls.Add(this.label4);
            this.PnlNavigation.Controls.Add(this.BtnColorSettings);
            this.PnlNavigation.Controls.Add(this.LblReservations);
            this.PnlNavigation.Controls.Add(this.BtnReservations);
            this.PnlNavigation.Controls.Add(this.LblAdd);
            this.PnlNavigation.Controls.Add(this.BtnAdd);
            this.PnlNavigation.Controls.Add(this.label3);
            this.PnlNavigation.Controls.Add(this.BtnLogout);
            this.PnlNavigation.Controls.Add(this.LblExit);
            this.PnlNavigation.Controls.Add(this.BtnExit);
            this.PnlNavigation.Controls.Add(this.LblUsers);
            this.PnlNavigation.Controls.Add(this.BtnUsers);
            this.PnlNavigation.Controls.Add(this.label2);
            this.PnlNavigation.Controls.Add(this.BtnClients);
            this.PnlNavigation.Controls.Add(this.label1);
            this.PnlNavigation.Controls.Add(this.BtnBooks);
            this.PnlNavigation.Location = new System.Drawing.Point(0, 0);
            this.PnlNavigation.Name = "PnlNavigation";
            this.PnlNavigation.Size = new System.Drawing.Size(1370, 105);
            this.PnlNavigation.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Snow;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(780, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 18);
            this.label5.TabIndex = 19;
            this.label5.Text = "Rəngləri sıfırla";
            this.label5.Click += new System.EventHandler(this.BtnResetColors_Click);
            // 
            // BtnResetColors
            // 
            this.BtnResetColors.BackColor = System.Drawing.Color.Transparent;
            this.BtnResetColors.BackgroundImage = global::LibraryManagment.Properties.Resources.ResetColors;
            this.BtnResetColors.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnResetColors.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnResetColors.FlatAppearance.BorderSize = 0;
            this.BtnResetColors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnResetColors.Location = new System.Drawing.Point(804, 5);
            this.BtnResetColors.Name = "BtnResetColors";
            this.BtnResetColors.Size = new System.Drawing.Size(68, 68);
            this.BtnResetColors.TabIndex = 18;
            this.BtnResetColors.UseVisualStyleBackColor = false;
            this.BtnResetColors.Click += new System.EventHandler(this.BtnResetColors_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Snow;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(958, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 18);
            this.label4.TabIndex = 17;
            this.label4.Text = "Rənglər";
            this.label4.Click += new System.EventHandler(this.BtnColorSettings_Click);
            // 
            // BtnColorSettings
            // 
            this.BtnColorSettings.BackColor = System.Drawing.Color.Transparent;
            this.BtnColorSettings.BackgroundImage = global::LibraryManagment.Properties.Resources.ColorSettings;
            this.BtnColorSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnColorSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnColorSettings.FlatAppearance.BorderSize = 0;
            this.BtnColorSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnColorSettings.Location = new System.Drawing.Point(955, 5);
            this.BtnColorSettings.Name = "BtnColorSettings";
            this.BtnColorSettings.Size = new System.Drawing.Size(68, 68);
            this.BtnColorSettings.TabIndex = 16;
            this.BtnColorSettings.UseVisualStyleBackColor = false;
            this.BtnColorSettings.Click += new System.EventHandler(this.BtnColorSettings_Click);
            // 
            // LblReservations
            // 
            this.LblReservations.AutoSize = true;
            this.LblReservations.BackColor = System.Drawing.Color.Transparent;
            this.LblReservations.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LblReservations.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.LblReservations.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(211)))));
            this.LblReservations.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LblReservations.Location = new System.Drawing.Point(497, 79);
            this.LblReservations.Name = "LblReservations";
            this.LblReservations.Size = new System.Drawing.Size(91, 18);
            this.LblReservations.TabIndex = 15;
            this.LblReservations.Text = "Məlumatlar";
            this.LblReservations.AutoSizeChanged += new System.EventHandler(this.BtnReservations_Click);
            // 
            // BtnReservations
            // 
            this.BtnReservations.BackColor = System.Drawing.Color.Transparent;
            this.BtnReservations.BackgroundImage = global::LibraryManagment.Properties.Resources.Database;
            this.BtnReservations.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnReservations.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnReservations.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.BtnReservations.FlatAppearance.BorderSize = 0;
            this.BtnReservations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReservations.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnReservations.Location = new System.Drawing.Point(506, 5);
            this.BtnReservations.Name = "BtnReservations";
            this.BtnReservations.Size = new System.Drawing.Size(72, 72);
            this.BtnReservations.TabIndex = 14;
            this.BtnReservations.UseVisualStyleBackColor = false;
            this.BtnReservations.Click += new System.EventHandler(this.BtnReservations_Click);
            // 
            // LblAdd
            // 
            this.LblAdd.AutoSize = true;
            this.LblAdd.BackColor = System.Drawing.Color.Transparent;
            this.LblAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LblAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.LblAdd.ForeColor = System.Drawing.Color.Snow;
            this.LblAdd.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LblAdd.Location = new System.Drawing.Point(653, 79);
            this.LblAdd.Name = "LblAdd";
            this.LblAdd.Size = new System.Drawing.Size(76, 18);
            this.LblAdd.TabIndex = 11;
            this.LblAdd.Text = "Kitab Ver";
            this.LblAdd.Click += new System.EventHandler(this.BtnAdd_Click);
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
            this.BtnAdd.Location = new System.Drawing.Point(656, 6);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(68, 68);
            this.BtnAdd.TabIndex = 1;
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
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
            this.label3.Location = new System.Drawing.Point(1107, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "Çıxış";
            this.label3.Click += new System.EventHandler(this.BtnLogout_Click);
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
            this.BtnLogout.Location = new System.Drawing.Point(1095, 5);
            this.BtnLogout.Name = "BtnLogout";
            this.BtnLogout.Size = new System.Drawing.Size(72, 72);
            this.BtnLogout.TabIndex = 5;
            this.BtnLogout.UseVisualStyleBackColor = false;
            this.BtnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
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
            this.LblExit.Location = new System.Drawing.Point(1251, 79);
            this.LblExit.Name = "LblExit";
            this.LblExit.Size = new System.Drawing.Size(50, 18);
            this.LblExit.TabIndex = 7;
            this.LblExit.Text = "Bağla";
            this.LblExit.Click += new System.EventHandler(this.BtnExit_Click);
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
            this.BtnExit.Location = new System.Drawing.Point(1244, 5);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(72, 72);
            this.BtnExit.TabIndex = 6;
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // LblUsers
            // 
            this.LblUsers.AutoSize = true;
            this.LblUsers.BackColor = System.Drawing.Color.Transparent;
            this.LblUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LblUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.LblUsers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(211)))));
            this.LblUsers.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LblUsers.Location = new System.Drawing.Point(368, 80);
            this.LblUsers.Name = "LblUsers";
            this.LblUsers.Size = new System.Drawing.Size(53, 18);
            this.LblUsers.TabIndex = 5;
            this.LblUsers.Text = "İşçilər";
            this.LblUsers.Click += new System.EventHandler(this.BtnUsers_Click);
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
            this.BtnUsers.Location = new System.Drawing.Point(356, 5);
            this.BtnUsers.Name = "BtnUsers";
            this.BtnUsers.Size = new System.Drawing.Size(72, 72);
            this.BtnUsers.TabIndex = 4;
            this.BtnUsers.UseVisualStyleBackColor = false;
            this.BtnUsers.Click += new System.EventHandler(this.BtnUsers_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(211)))));
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(205, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Oxucular";
            this.label2.Click += new System.EventHandler(this.BtnClients_Click);
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
            this.BtnClients.Location = new System.Drawing.Point(206, 5);
            this.BtnClients.Name = "BtnClients";
            this.BtnClients.Size = new System.Drawing.Size(72, 72);
            this.BtnClients.TabIndex = 3;
            this.BtnClients.UseVisualStyleBackColor = false;
            this.BtnClients.Click += new System.EventHandler(this.BtnClients_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(211)))));
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(60, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kitablar";
            this.label1.Click += new System.EventHandler(this.BtnBooks_Click);
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
            this.BtnBooks.Location = new System.Drawing.Point(56, 5);
            this.BtnBooks.Name = "BtnBooks";
            this.BtnBooks.Size = new System.Drawing.Size(72, 72);
            this.BtnBooks.TabIndex = 2;
            this.BtnBooks.UseVisualStyleBackColor = false;
            this.BtnBooks.Click += new System.EventHandler(this.BtnBooks_Click);
            // 
            // TmrSetPenalties
            // 
            this.TmrSetPenalties.Interval = 1800000;
            this.TmrSetPenalties.Tick += new System.EventHandler(this.TmrSetPenalties_Tick);
            // 
            // MainBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.PnlNavigation);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainBoard";
            this.Text = "Kitabxana";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainBoard_FormClosed);
            this.PnlNavigation.ResumeLayout(false);
            this.PnlNavigation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.Timer TmrSetPenalties;
        private System.Windows.Forms.Button BtnColorSettings;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnResetColors;
        protected internal System.Windows.Forms.Panel PnlNavigation;
    }
}

