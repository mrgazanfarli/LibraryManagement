namespace LibraryManagment.Forms
{
    partial class Users
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Users));
            this.DgvUsers = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnShowPassword = new System.Windows.Forms.Button();
            this.TxtPhone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnAddUser = new System.Windows.Forms.Button();
            this.BtnDeleteUser = new System.Windows.Forms.Button();
            this.BtnUpdateUser = new System.Windows.Forms.Button();
            this.LblValidation = new System.Windows.Forms.Label();
            this.RbtnNotBoss = new System.Windows.Forms.RadioButton();
            this.RbtnIsBoss = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtUsername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtSurname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.CmbUsersShown = new System.Windows.Forms.ComboBox();
            this.BtnGetBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvUsers)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgvUsers
            // 
            this.DgvUsers.AllowUserToAddRows = false;
            this.DgvUsers.AllowUserToDeleteRows = false;
            this.DgvUsers.AllowUserToOrderColumns = true;
            this.DgvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvUsers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(188)))), ((int)(((byte)(92)))));
            this.DgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.DgvUsers.Location = new System.Drawing.Point(16, 69);
            this.DgvUsers.Name = "DgvUsers";
            this.DgvUsers.ReadOnly = true;
            this.DgvUsers.Size = new System.Drawing.Size(615, 439);
            this.DgvUsers.TabIndex = 0;
            this.DgvUsers.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvUsers_RowHeaderMouseClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Ad";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Soyad";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Istifadəçi adı";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Şifrə";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.FillWeight = 70F;
            this.Column6.HeaderText = "İdarəçidir";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.FillWeight = 120F;
            this.Column7.HeaderText = "Telefon";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnShowPassword);
            this.groupBox1.Controls.Add(this.TxtPhone);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.BtnAddUser);
            this.groupBox1.Controls.Add(this.BtnDeleteUser);
            this.groupBox1.Controls.Add(this.BtnUpdateUser);
            this.groupBox1.Controls.Add(this.LblValidation);
            this.groupBox1.Controls.Add(this.RbtnNotBoss);
            this.groupBox1.Controls.Add(this.RbtnIsBoss);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.TxtPassword);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TxtUsername);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TxtSurname);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TxtName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(637, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 439);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İstifadəçi";
            // 
            // BtnShowPassword
            // 
            this.BtnShowPassword.BackColor = System.Drawing.Color.Transparent;
            this.BtnShowPassword.BackgroundImage = global::LibraryManagment.Properties.Resources.Eye;
            this.BtnShowPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnShowPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnShowPassword.FlatAppearance.BorderSize = 0;
            this.BtnShowPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnShowPassword.Location = new System.Drawing.Point(223, 273);
            this.BtnShowPassword.Name = "BtnShowPassword";
            this.BtnShowPassword.Size = new System.Drawing.Size(25, 24);
            this.BtnShowPassword.TabIndex = 15;
            this.BtnShowPassword.UseVisualStyleBackColor = false;
            this.BtnShowPassword.Click += new System.EventHandler(this.BtnShowPassword_Click);
            // 
            // TxtPhone
            // 
            this.TxtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPhone.Location = new System.Drawing.Point(9, 151);
            this.TxtPhone.Name = "TxtPhone";
            this.TxtPhone.Size = new System.Drawing.Size(241, 24);
            this.TxtPhone.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 18);
            this.label6.TabIndex = 14;
            this.label6.Text = "Telefon";
            // 
            // BtnAddUser
            // 
            this.BtnAddUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(142)))), ((int)(((byte)(0)))));
            this.BtnAddUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAddUser.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddUser.ForeColor = System.Drawing.Color.Azure;
            this.BtnAddUser.Location = new System.Drawing.Point(9, 367);
            this.BtnAddUser.Name = "BtnAddUser";
            this.BtnAddUser.Size = new System.Drawing.Size(238, 30);
            this.BtnAddUser.TabIndex = 8;
            this.BtnAddUser.Text = " Əlavə et";
            this.BtnAddUser.UseVisualStyleBackColor = false;
            this.BtnAddUser.Click += new System.EventHandler(this.BtnAddUser_Click);
            // 
            // BtnDeleteUser
            // 
            this.BtnDeleteUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(142)))), ((int)(((byte)(0)))));
            this.BtnDeleteUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDeleteUser.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnDeleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDeleteUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDeleteUser.ForeColor = System.Drawing.Color.Azure;
            this.BtnDeleteUser.Location = new System.Drawing.Point(9, 401);
            this.BtnDeleteUser.Name = "BtnDeleteUser";
            this.BtnDeleteUser.Size = new System.Drawing.Size(238, 30);
            this.BtnDeleteUser.TabIndex = 10;
            this.BtnDeleteUser.Text = "Sil";
            this.BtnDeleteUser.UseVisualStyleBackColor = false;
            this.BtnDeleteUser.Visible = false;
            this.BtnDeleteUser.Click += new System.EventHandler(this.BtnDeleteUser_Click);
            // 
            // BtnUpdateUser
            // 
            this.BtnUpdateUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(142)))), ((int)(((byte)(0)))));
            this.BtnUpdateUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnUpdateUser.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnUpdateUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUpdateUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdateUser.ForeColor = System.Drawing.Color.Azure;
            this.BtnUpdateUser.Location = new System.Drawing.Point(9, 334);
            this.BtnUpdateUser.Name = "BtnUpdateUser";
            this.BtnUpdateUser.Size = new System.Drawing.Size(238, 30);
            this.BtnUpdateUser.TabIndex = 9;
            this.BtnUpdateUser.Text = "Dəyişdir";
            this.BtnUpdateUser.UseVisualStyleBackColor = false;
            this.BtnUpdateUser.Visible = false;
            this.BtnUpdateUser.Click += new System.EventHandler(this.BtnUpdateUser_Click);
            // 
            // LblValidation
            // 
            this.LblValidation.AutoSize = true;
            this.LblValidation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.LblValidation.Location = new System.Drawing.Point(12, 239);
            this.LblValidation.Name = "LblValidation";
            this.LblValidation.Size = new System.Drawing.Size(0, 15);
            this.LblValidation.TabIndex = 12;
            // 
            // RbtnNotBoss
            // 
            this.RbtnNotBoss.AutoSize = true;
            this.RbtnNotBoss.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbtnNotBoss.Location = new System.Drawing.Point(145, 299);
            this.RbtnNotBoss.Name = "RbtnNotBoss";
            this.RbtnNotBoss.Size = new System.Drawing.Size(102, 22);
            this.RbtnNotBoss.TabIndex = 7;
            this.RbtnNotBoss.TabStop = true;
            this.RbtnNotBoss.Text = "İdarəçi deyil";
            this.RbtnNotBoss.UseVisualStyleBackColor = true;
            // 
            // RbtnIsBoss
            // 
            this.RbtnIsBoss.AutoSize = true;
            this.RbtnIsBoss.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbtnIsBoss.Location = new System.Drawing.Point(9, 299);
            this.RbtnIsBoss.Name = "RbtnIsBoss";
            this.RbtnIsBoss.Size = new System.Drawing.Size(85, 22);
            this.RbtnIsBoss.TabIndex = 6;
            this.RbtnIsBoss.TabStop = true;
            this.RbtnIsBoss.Text = "İdarəçidir";
            this.RbtnIsBoss.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 18);
            this.label5.TabIndex = 8;
            // 
            // TxtPassword
            // 
            this.TxtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPassword.Location = new System.Drawing.Point(9, 249);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(241, 24);
            this.TxtPassword.TabIndex = 5;
            this.TxtPassword.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Şifrə";
            // 
            // TxtUsername
            // 
            this.TxtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUsername.Location = new System.Drawing.Point(9, 199);
            this.TxtUsername.Name = "TxtUsername";
            this.TxtUsername.Size = new System.Drawing.Size(241, 24);
            this.TxtUsername.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "İstifadəçi adı";
            // 
            // TxtSurname
            // 
            this.TxtSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSurname.Location = new System.Drawing.Point(9, 99);
            this.TxtSurname.Name = "TxtSurname";
            this.TxtSurname.Size = new System.Drawing.Size(241, 24);
            this.TxtSurname.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Soyad";
            // 
            // TxtName
            // 
            this.TxtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtName.Location = new System.Drawing.Point(9, 49);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(241, 24);
            this.TxtName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Göstər:";
            // 
            // CmbUsersShown
            // 
            this.CmbUsersShown.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbUsersShown.FormattingEnabled = true;
            this.CmbUsersShown.Location = new System.Drawing.Point(90, 21);
            this.CmbUsersShown.Name = "CmbUsersShown";
            this.CmbUsersShown.Size = new System.Drawing.Size(183, 26);
            this.CmbUsersShown.TabIndex = 11;
            this.CmbUsersShown.SelectedIndexChanged += new System.EventHandler(this.CmbUsersShown_SelectedIndexChanged);
            // 
            // BtnGetBack
            // 
            this.BtnGetBack.BackColor = System.Drawing.Color.Transparent;
            this.BtnGetBack.BackgroundImage = global::LibraryManagment.Properties.Resources.back;
            this.BtnGetBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnGetBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGetBack.FlatAppearance.BorderSize = 0;
            this.BtnGetBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGetBack.Location = new System.Drawing.Point(1288, 12);
            this.BtnGetBack.Name = "BtnGetBack";
            this.BtnGetBack.Size = new System.Drawing.Size(70, 70);
            this.BtnGetBack.TabIndex = 12;
            this.BtnGetBack.UseVisualStyleBackColor = false;
            this.BtnGetBack.Click += new System.EventHandler(this.BtnGetBack_Click);
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 528);
            this.ControlBox = false;
            this.Controls.Add(this.BtnGetBack);
            this.Controls.Add(this.CmbUsersShown);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DgvUsers);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Users";
            this.Text = "İşçilər";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Users_FormClosed);
            this.Click += new System.EventHandler(this.Users_Click);
            ((System.ComponentModel.ISupportInitialize)(this.DgvUsers)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvUsers;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RbtnNotBoss;
        private System.Windows.Forms.RadioButton RbtnIsBoss;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtUsername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtSurname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblValidation;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CmbUsersShown;
        private System.Windows.Forms.Button BtnDeleteUser;
        private System.Windows.Forms.Button BtnUpdateUser;
        private System.Windows.Forms.Button BtnAddUser;
        private System.Windows.Forms.TextBox TxtPhone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Button BtnShowPassword;
        private System.Windows.Forms.Button BtnGetBack;
    }
}