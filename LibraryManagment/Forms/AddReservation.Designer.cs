namespace LibraryManagment.Forms
{
    partial class AddReservation
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtClientNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CmbAuthors = new System.Windows.Forms.ComboBox();
            this.CmbBooks = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NumInterval = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnReserv = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.GrbClientDetails = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtClientName = new System.Windows.Forms.TextBox();
            this.TxtClientSurname = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtClientPhone = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.LblClientNotFound = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumInterval)).BeginInit();
            this.GrbClientDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.BtnReserv);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.NumInterval);
            this.groupBox1.Controls.Add(this.CmbBooks);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.CmbAuthors);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TxtClientNumber);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(255, 303);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(7, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Oxucu nömrəsi*";
            // 
            // TxtClientNumber
            // 
            this.TxtClientNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TxtClientNumber.Location = new System.Drawing.Point(10, 33);
            this.TxtClientNumber.Name = "TxtClientNumber";
            this.TxtClientNumber.Size = new System.Drawing.Size(224, 24);
            this.TxtClientNumber.TabIndex = 2;
            this.TxtClientNumber.TextChanged += new System.EventHandler(this.TxtClientNumber_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(7, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Müəllif";
            // 
            // CmbAuthors
            // 
            this.CmbAuthors.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CmbAuthors.FormattingEnabled = true;
            this.CmbAuthors.Location = new System.Drawing.Point(10, 91);
            this.CmbAuthors.Name = "CmbAuthors";
            this.CmbAuthors.Size = new System.Drawing.Size(224, 26);
            this.CmbAuthors.TabIndex = 4;
            this.CmbAuthors.SelectedIndexChanged += new System.EventHandler(this.CmbAuthors_SelectedIndexChanged);
            // 
            // CmbBooks
            // 
            this.CmbBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CmbBooks.FormattingEnabled = true;
            this.CmbBooks.Location = new System.Drawing.Point(10, 147);
            this.CmbBooks.Name = "CmbBooks";
            this.CmbBooks.Size = new System.Drawing.Size(224, 26);
            this.CmbBooks.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(7, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Kitab*";
            // 
            // NumInterval
            // 
            this.NumInterval.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumInterval.Location = new System.Drawing.Point(10, 206);
            this.NumInterval.Name = "NumInterval";
            this.NumInterval.Size = new System.Drawing.Size(224, 24);
            this.NumInterval.TabIndex = 7;
            this.NumInterval.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(7, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Müddət (gün)*";
            // 
            // BtnReserv
            // 
            this.BtnReserv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnReserv.Location = new System.Drawing.Point(10, 258);
            this.BtnReserv.Name = "BtnReserv";
            this.BtnReserv.Size = new System.Drawing.Size(224, 33);
            this.BtnReserv.TabIndex = 9;
            this.BtnReserv.Text = "Əlavə et";
            this.BtnReserv.UseVisualStyleBackColor = true;
            this.BtnReserv.Click += new System.EventHandler(this.BtnReserv_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(193, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "(!) Boş qoyularsa, 30 gün qeyd ediləcək";
            // 
            // GrbClientDetails
            // 
            this.GrbClientDetails.Controls.Add(this.TxtClientPhone);
            this.GrbClientDetails.Controls.Add(this.label8);
            this.GrbClientDetails.Controls.Add(this.TxtClientSurname);
            this.GrbClientDetails.Controls.Add(this.label7);
            this.GrbClientDetails.Controls.Add(this.TxtClientName);
            this.GrbClientDetails.Controls.Add(this.label6);
            this.GrbClientDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GrbClientDetails.Location = new System.Drawing.Point(277, 19);
            this.GrbClientDetails.Name = "GrbClientDetails";
            this.GrbClientDetails.Size = new System.Drawing.Size(228, 168);
            this.GrbClientDetails.TabIndex = 1;
            this.GrbClientDetails.TabStop = false;
            this.GrbClientDetails.Text = "Oxucu";
            this.GrbClientDetails.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Enabled = false;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(7, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Adı";
            // 
            // TxtClientName
            // 
            this.TxtClientName.Enabled = false;
            this.TxtClientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TxtClientName.Location = new System.Drawing.Point(10, 43);
            this.TxtClientName.Name = "TxtClientName";
            this.TxtClientName.Size = new System.Drawing.Size(212, 21);
            this.TxtClientName.TabIndex = 1;
            // 
            // TxtClientSurname
            // 
            this.TxtClientSurname.Enabled = false;
            this.TxtClientSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TxtClientSurname.Location = new System.Drawing.Point(10, 87);
            this.TxtClientSurname.Name = "TxtClientSurname";
            this.TxtClientSurname.Size = new System.Drawing.Size(212, 21);
            this.TxtClientSurname.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Enabled = false;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(7, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 15);
            this.label7.TabIndex = 2;
            this.label7.Text = "Soyadı";
            // 
            // TxtClientPhone
            // 
            this.TxtClientPhone.Enabled = false;
            this.TxtClientPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TxtClientPhone.Location = new System.Drawing.Point(10, 139);
            this.TxtClientPhone.Name = "TxtClientPhone";
            this.TxtClientPhone.Size = new System.Drawing.Size(212, 21);
            this.TxtClientPhone.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Enabled = false;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(7, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 15);
            this.label8.TabIndex = 4;
            this.label8.Text = "Telefon";
            // 
            // LblClientNotFound
            // 
            this.LblClientNotFound.AutoSize = true;
            this.LblClientNotFound.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblClientNotFound.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(53)))), ((int)(((byte)(0)))));
            this.LblClientNotFound.Location = new System.Drawing.Point(273, 46);
            this.LblClientNotFound.Name = "LblClientNotFound";
            this.LblClientNotFound.Size = new System.Drawing.Size(171, 20);
            this.LblClientNotFound.TabIndex = 12;
            this.LblClientNotFound.Text = "İstifadəçi mövcud deyil!";
            this.LblClientNotFound.Visible = false;
            // 
            // AddReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 321);
            this.Controls.Add(this.LblClientNotFound);
            this.Controls.Add(this.GrbClientDetails);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "AddReservation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Kitab verilməsi";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumInterval)).EndInit();
            this.GrbClientDetails.ResumeLayout(false);
            this.GrbClientDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtClientNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CmbAuthors;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CmbBooks;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown NumInterval;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnReserv;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox GrbClientDetails;
        private System.Windows.Forms.TextBox TxtClientPhone;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtClientSurname;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtClientName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LblClientNotFound;
    }
}