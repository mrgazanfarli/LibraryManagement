namespace LibraryManagment.Forms
{
    partial class Reservations
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reservations));
            this.DgvReservations = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.CmbSearch = new System.Windows.Forms.ComboBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GrbClientNumber = new System.Windows.Forms.GroupBox();
            this.TxtClientNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.GrbBookDetails = new System.Windows.Forms.GroupBox();
            this.CmbAuthors = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CmbBooks = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.GrbUsers = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CmbUsers = new System.Windows.Forms.ComboBox();
            this.LblError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvReservations)).BeginInit();
            this.GrbClientNumber.SuspendLayout();
            this.GrbBookDetails.SuspendLayout();
            this.GrbUsers.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgvReservations
            // 
            this.DgvReservations.AllowUserToAddRows = false;
            this.DgvReservations.AllowUserToDeleteRows = false;
            this.DgvReservations.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvReservations.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.DgvReservations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvReservations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column12,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11});
            this.DgvReservations.Location = new System.Drawing.Point(12, 103);
            this.DgvReservations.Name = "DgvReservations";
            this.DgvReservations.Size = new System.Drawing.Size(1346, 263);
            this.DgvReservations.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Axtar";
            // 
            // CmbSearch
            // 
            this.CmbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CmbSearch.FormattingEnabled = true;
            this.CmbSearch.Location = new System.Drawing.Point(12, 43);
            this.CmbSearch.Name = "CmbSearch";
            this.CmbSearch.Size = new System.Drawing.Size(132, 24);
            this.CmbSearch.TabIndex = 2;
            this.CmbSearch.SelectedIndexChanged += new System.EventHandler(this.CmbSearch_SelectedIndexChanged);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Oxucu";
            this.Column2.Name = "Column2";
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Müəllif";
            this.Column12.Name = "Column12";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Kitab";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.FillWeight = 70F;
            this.Column4.HeaderText = "Müddət";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Verib";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Verilmə vaxtı";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Alıb";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Alınma vaxtı";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.FillWeight = 70F;
            this.Column9.HeaderText = "Cərimə";
            this.Column9.Name = "Column9";
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Kitabın durumu";
            this.Column10.Name = "Column10";
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Şərh";
            this.Column11.Name = "Column11";
            // 
            // GrbClientNumber
            // 
            this.GrbClientNumber.Controls.Add(this.LblError);
            this.GrbClientNumber.Controls.Add(this.TxtClientNumber);
            this.GrbClientNumber.Controls.Add(this.label2);
            this.GrbClientNumber.Location = new System.Drawing.Point(173, 5);
            this.GrbClientNumber.Name = "GrbClientNumber";
            this.GrbClientNumber.Size = new System.Drawing.Size(216, 92);
            this.GrbClientNumber.TabIndex = 9;
            this.GrbClientNumber.TabStop = false;
            this.GrbClientNumber.Visible = false;
            // 
            // TxtClientNumber
            // 
            this.TxtClientNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TxtClientNumber.Location = new System.Drawing.Point(6, 41);
            this.TxtClientNumber.Name = "TxtClientNumber";
            this.TxtClientNumber.Size = new System.Drawing.Size(188, 23);
            this.TxtClientNumber.TabIndex = 10;
            this.TxtClientNumber.TextChanged += new System.EventHandler(this.TxtClientNumber_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(3, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Oxucu nömrəsi:";
            // 
            // GrbBookDetails
            // 
            this.GrbBookDetails.Controls.Add(this.CmbBooks);
            this.GrbBookDetails.Controls.Add(this.label4);
            this.GrbBookDetails.Controls.Add(this.CmbAuthors);
            this.GrbBookDetails.Controls.Add(this.label3);
            this.GrbBookDetails.Location = new System.Drawing.Point(172, 17);
            this.GrbBookDetails.Name = "GrbBookDetails";
            this.GrbBookDetails.Size = new System.Drawing.Size(417, 74);
            this.GrbBookDetails.TabIndex = 12;
            this.GrbBookDetails.TabStop = false;
            this.GrbBookDetails.Visible = false;
            // 
            // CmbAuthors
            // 
            this.CmbAuthors.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CmbAuthors.FormattingEnabled = true;
            this.CmbAuthors.Location = new System.Drawing.Point(6, 36);
            this.CmbAuthors.Name = "CmbAuthors";
            this.CmbAuthors.Size = new System.Drawing.Size(179, 24);
            this.CmbAuthors.TabIndex = 1;
            this.CmbAuthors.SelectedIndexChanged += new System.EventHandler(this.CmbAuthors_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(3, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Müəllif";
            // 
            // CmbBooks
            // 
            this.CmbBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CmbBooks.FormattingEnabled = true;
            this.CmbBooks.Location = new System.Drawing.Point(224, 36);
            this.CmbBooks.Name = "CmbBooks";
            this.CmbBooks.Size = new System.Drawing.Size(187, 24);
            this.CmbBooks.TabIndex = 3;
            this.CmbBooks.SelectedIndexChanged += new System.EventHandler(this.CmbBooks_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(221, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Kitab";
            // 
            // GrbUsers
            // 
            this.GrbUsers.Controls.Add(this.CmbUsers);
            this.GrbUsers.Controls.Add(this.label5);
            this.GrbUsers.Location = new System.Drawing.Point(169, 16);
            this.GrbUsers.Name = "GrbUsers";
            this.GrbUsers.Size = new System.Drawing.Size(231, 74);
            this.GrbUsers.TabIndex = 4;
            this.GrbUsers.TabStop = false;
            this.GrbUsers.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(7, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "İşçi";
            // 
            // CmbUsers
            // 
            this.CmbUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CmbUsers.FormattingEnabled = true;
            this.CmbUsers.Location = new System.Drawing.Point(10, 38);
            this.CmbUsers.Name = "CmbUsers";
            this.CmbUsers.Size = new System.Drawing.Size(208, 24);
            this.CmbUsers.TabIndex = 1;
            this.CmbUsers.SelectedIndexChanged += new System.EventHandler(this.CmbUsers_SelectedIndexChanged);
            // 
            // LblError
            // 
            this.LblError.AutoSize = true;
            this.LblError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(54)))), ((int)(((byte)(0)))));
            this.LblError.Location = new System.Drawing.Point(7, 72);
            this.LblError.Name = "LblError";
            this.LblError.Size = new System.Drawing.Size(0, 13);
            this.LblError.TabIndex = 11;
            // 
            // Reservations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 450);
            this.Controls.Add(this.GrbUsers);
            this.Controls.Add(this.GrbBookDetails);
            this.Controls.Add(this.GrbClientNumber);
            this.Controls.Add(this.CmbSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DgvReservations);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Reservations";
            this.Text = "Kitab Verilişi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.DoubleClick += new System.EventHandler(this.Reservations_DoubleClick);
            this.Resize += new System.EventHandler(this.Reservations_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.DgvReservations)).EndInit();
            this.GrbClientNumber.ResumeLayout(false);
            this.GrbClientNumber.PerformLayout();
            this.GrbBookDetails.ResumeLayout(false);
            this.GrbBookDetails.PerformLayout();
            this.GrbUsers.ResumeLayout(false);
            this.GrbUsers.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvReservations;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CmbSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.GroupBox GrbClientNumber;
        private System.Windows.Forms.TextBox TxtClientNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox GrbBookDetails;
        private System.Windows.Forms.ComboBox CmbBooks;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CmbAuthors;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox GrbUsers;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CmbUsers;
        private System.Windows.Forms.Label LblError;
    }
}