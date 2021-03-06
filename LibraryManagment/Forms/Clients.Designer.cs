﻿namespace LibraryManagment.Forms
{
    partial class Clients
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
            this.CmbShowClients = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DgvClients = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.NumBookLimit = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtPhone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnAddClient = new System.Windows.Forms.Button();
            this.BtnDeleteClient = new System.Windows.Forms.Button();
            this.BtnUpdateClient = new System.Windows.Forms.Button();
            this.TxtSurname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnGetBack = new System.Windows.Forms.Button();
            this.BtnColors = new System.Windows.Forms.Button();
            this.ClrBack = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.DgvClients)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumBookLimit)).BeginInit();
            this.SuspendLayout();
            // 
            // CmbShowClients
            // 
            this.CmbShowClients.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbShowClients.FormattingEnabled = true;
            this.CmbShowClients.Location = new System.Drawing.Point(85, 12);
            this.CmbShowClients.Name = "CmbShowClients";
            this.CmbShowClients.Size = new System.Drawing.Size(181, 26);
            this.CmbShowClients.TabIndex = 3;
            this.CmbShowClients.SelectedIndexChanged += new System.EventHandler(this.CmbShowClients_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Göstər:";
            // 
            // DgvClients
            // 
            this.DgvClients.AllowUserToAddRows = false;
            this.DgvClients.AllowUserToDeleteRows = false;
            this.DgvClients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvClients.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(188)))), ((int)(((byte)(92)))));
            this.DgvClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvClients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.DgvClients.Location = new System.Drawing.Point(16, 56);
            this.DgvClients.Name = "DgvClients";
            this.DgvClients.ReadOnly = true;
            this.DgvClients.Size = new System.Drawing.Size(882, 359);
            this.DgvClients.TabIndex = 4;
            this.DgvClients.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvClients_RowHeaderMouseClick);
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
            this.Column2.HeaderText = "Adı";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Soyadı";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Telefon";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Oxucu nömrəsi";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Yaratdı";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Qeydiyyat tarixi";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.FillWeight = 80F;
            this.Column8.HeaderText = "Kitablar/Limit";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NumBookLimit);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TxtPhone);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.BtnAddClient);
            this.groupBox1.Controls.Add(this.BtnDeleteClient);
            this.groupBox1.Controls.Add(this.BtnUpdateClient);
            this.groupBox1.Controls.Add(this.TxtSurname);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TxtName);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(915, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 359);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müştəri";
            // 
            // NumBookLimit
            // 
            this.NumBookLimit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumBookLimit.Location = new System.Drawing.Point(9, 204);
            this.NumBookLimit.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NumBookLimit.Name = "NumBookLimit";
            this.NumBookLimit.Size = new System.Drawing.Size(238, 26);
            this.NumBookLimit.TabIndex = 16;
            this.NumBookLimit.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 18);
            this.label3.TabIndex = 15;
            this.label3.Text = "Kitab limiti";
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
            // BtnAddClient
            // 
            this.BtnAddClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(142)))), ((int)(((byte)(0)))));
            this.BtnAddClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAddClient.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnAddClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddClient.ForeColor = System.Drawing.Color.Azure;
            this.BtnAddClient.Location = new System.Drawing.Point(9, 284);
            this.BtnAddClient.Name = "BtnAddClient";
            this.BtnAddClient.Size = new System.Drawing.Size(238, 30);
            this.BtnAddClient.TabIndex = 8;
            this.BtnAddClient.Text = " Əlavə et";
            this.BtnAddClient.UseVisualStyleBackColor = false;
            this.BtnAddClient.Click += new System.EventHandler(this.BtnAddClient_Click);
            // 
            // BtnDeleteClient
            // 
            this.BtnDeleteClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(142)))), ((int)(((byte)(0)))));
            this.BtnDeleteClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDeleteClient.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnDeleteClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDeleteClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDeleteClient.ForeColor = System.Drawing.Color.Azure;
            this.BtnDeleteClient.Location = new System.Drawing.Point(9, 318);
            this.BtnDeleteClient.Name = "BtnDeleteClient";
            this.BtnDeleteClient.Size = new System.Drawing.Size(238, 30);
            this.BtnDeleteClient.TabIndex = 10;
            this.BtnDeleteClient.Text = "Sil";
            this.BtnDeleteClient.UseVisualStyleBackColor = false;
            this.BtnDeleteClient.Visible = false;
            this.BtnDeleteClient.Click += new System.EventHandler(this.BtnDeleteClient_Click);
            // 
            // BtnUpdateClient
            // 
            this.BtnUpdateClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(142)))), ((int)(((byte)(0)))));
            this.BtnUpdateClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnUpdateClient.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnUpdateClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUpdateClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdateClient.ForeColor = System.Drawing.Color.Azure;
            this.BtnUpdateClient.Location = new System.Drawing.Point(9, 251);
            this.BtnUpdateClient.Name = "BtnUpdateClient";
            this.BtnUpdateClient.Size = new System.Drawing.Size(238, 30);
            this.BtnUpdateClient.TabIndex = 9;
            this.BtnUpdateClient.Text = "Dəyişdir";
            this.BtnUpdateClient.UseVisualStyleBackColor = false;
            this.BtnUpdateClient.Visible = false;
            this.BtnUpdateClient.Click += new System.EventHandler(this.BtnUpdateClient_Click);
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 18);
            this.label7.TabIndex = 0;
            this.label7.Text = "Ad";
            // 
            // BtnGetBack
            // 
            this.BtnGetBack.BackColor = System.Drawing.Color.Transparent;
            this.BtnGetBack.BackgroundImage = global::LibraryManagment.Properties.Resources.back;
            this.BtnGetBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnGetBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGetBack.FlatAppearance.BorderSize = 0;
            this.BtnGetBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGetBack.Location = new System.Drawing.Point(1292, 12);
            this.BtnGetBack.Name = "BtnGetBack";
            this.BtnGetBack.Size = new System.Drawing.Size(70, 70);
            this.BtnGetBack.TabIndex = 12;
            this.BtnGetBack.UseVisualStyleBackColor = false;
            this.BtnGetBack.Click += new System.EventHandler(this.BtnGetBack_Click);
            // 
            // BtnColors
            // 
            this.BtnColors.BackColor = System.Drawing.Color.Transparent;
            this.BtnColors.BackgroundImage = global::LibraryManagment.Properties.Resources.ColorSettings;
            this.BtnColors.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnColors.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnColors.FlatAppearance.BorderSize = 0;
            this.BtnColors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnColors.Location = new System.Drawing.Point(1209, 12);
            this.BtnColors.Name = "BtnColors";
            this.BtnColors.Size = new System.Drawing.Size(68, 68);
            this.BtnColors.TabIndex = 18;
            this.BtnColors.UseVisualStyleBackColor = false;
            this.BtnColors.Click += new System.EventHandler(this.BtnColors_Click);
            // 
            // Clients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 452);
            this.ControlBox = false;
            this.Controls.Add(this.BtnColors);
            this.Controls.Add(this.BtnGetBack);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DgvClients);
            this.Controls.Add(this.CmbShowClients);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Clients";
            this.Text = "Clients";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Clients_FormClosed);
            this.Click += new System.EventHandler(this.Clients_Click);
            ((System.ComponentModel.ISupportInitialize)(this.DgvClients)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumBookLimit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CmbShowClients;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DgvClients;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtPhone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnAddClient;
        private System.Windows.Forms.Button BtnDeleteClient;
        private System.Windows.Forms.Button BtnUpdateClient;
        private System.Windows.Forms.TextBox TxtSurname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown NumBookLimit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.Button BtnGetBack;
        private System.Windows.Forms.Button BtnColors;
        private System.Windows.Forms.ColorDialog ClrBack;
    }
}