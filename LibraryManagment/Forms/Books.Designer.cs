namespace LibraryManagment.Forms
{
    partial class Books
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
            this.label1 = new System.Windows.Forms.Label();
            this.CmbShowBooks = new System.Windows.Forms.ComboBox();
            this.DgvBooks = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GrbCrud = new System.Windows.Forms.GroupBox();
            this.CmbAuthors = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnUpdateBook = new System.Windows.Forms.Button();
            this.BtnDeleteBook = new System.Windows.Forms.Button();
            this.BtnAddBook = new System.Windows.Forms.Button();
            this.NumCount = new System.Windows.Forms.NumericUpDown();
            this.LblBookCount = new System.Windows.Forms.Label();
            this.NumPrice = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtBookName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnAuthors = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvBooks)).BeginInit();
            this.GrbCrud.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Göstər:";
            // 
            // CmbShowBooks
            // 
            this.CmbShowBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbShowBooks.FormattingEnabled = true;
            this.CmbShowBooks.Location = new System.Drawing.Point(89, 9);
            this.CmbShowBooks.Name = "CmbShowBooks";
            this.CmbShowBooks.Size = new System.Drawing.Size(181, 26);
            this.CmbShowBooks.TabIndex = 8;
            this.CmbShowBooks.SelectedIndexChanged += new System.EventHandler(this.CmbShowBooks_SelectedIndexChanged);
            // 
            // DgvBooks
            // 
            this.DgvBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column6,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.DgvBooks.Location = new System.Drawing.Point(15, 70);
            this.DgvBooks.Name = "DgvBooks";
            this.DgvBooks.Size = new System.Drawing.Size(467, 369);
            this.DgvBooks.TabIndex = 2;
            this.DgvBooks.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvBooks_RowHeaderMouseClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "AuthorId";
            this.Column6.Name = "Column6";
            this.Column6.Visible = false;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Adı";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Müəllif";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Qiymət";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Sayı";
            this.Column5.Name = "Column5";
            // 
            // GrbCrud
            // 
            this.GrbCrud.Controls.Add(this.CmbAuthors);
            this.GrbCrud.Controls.Add(this.label6);
            this.GrbCrud.Controls.Add(this.BtnUpdateBook);
            this.GrbCrud.Controls.Add(this.BtnDeleteBook);
            this.GrbCrud.Controls.Add(this.BtnAddBook);
            this.GrbCrud.Controls.Add(this.NumCount);
            this.GrbCrud.Controls.Add(this.LblBookCount);
            this.GrbCrud.Controls.Add(this.NumPrice);
            this.GrbCrud.Controls.Add(this.label4);
            this.GrbCrud.Controls.Add(this.label3);
            this.GrbCrud.Controls.Add(this.TxtBookName);
            this.GrbCrud.Controls.Add(this.label2);
            this.GrbCrud.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrbCrud.Location = new System.Drawing.Point(529, 70);
            this.GrbCrud.Name = "GrbCrud";
            this.GrbCrud.Size = new System.Drawing.Size(243, 369);
            this.GrbCrud.TabIndex = 3;
            this.GrbCrud.TabStop = false;
            this.GrbCrud.Text = "Kitab";
            // 
            // CmbAuthors
            // 
            this.CmbAuthors.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbAuthors.FormattingEnabled = true;
            this.CmbAuthors.Location = new System.Drawing.Point(10, 108);
            this.CmbAuthors.Name = "CmbAuthors";
            this.CmbAuthors.Size = new System.Drawing.Size(224, 26);
            this.CmbAuthors.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(69, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 15);
            this.label6.TabIndex = 4;
            // 
            // BtnUpdateBook
            // 
            this.BtnUpdateBook.Location = new System.Drawing.Point(10, 254);
            this.BtnUpdateBook.Name = "BtnUpdateBook";
            this.BtnUpdateBook.Size = new System.Drawing.Size(224, 30);
            this.BtnUpdateBook.TabIndex = 6;
            this.BtnUpdateBook.Text = "Dəyişdir";
            this.BtnUpdateBook.UseVisualStyleBackColor = true;
            this.BtnUpdateBook.Visible = false;
            this.BtnUpdateBook.Click += new System.EventHandler(this.BtnUpdateBook_Click);
            // 
            // BtnDeleteBook
            // 
            this.BtnDeleteBook.Location = new System.Drawing.Point(10, 326);
            this.BtnDeleteBook.Name = "BtnDeleteBook";
            this.BtnDeleteBook.Size = new System.Drawing.Size(224, 30);
            this.BtnDeleteBook.TabIndex = 7;
            this.BtnDeleteBook.Text = "Sil";
            this.BtnDeleteBook.UseVisualStyleBackColor = true;
            this.BtnDeleteBook.Visible = false;
            this.BtnDeleteBook.Click += new System.EventHandler(this.BtnDeleteBook_Click);
            // 
            // BtnAddBook
            // 
            this.BtnAddBook.Location = new System.Drawing.Point(10, 290);
            this.BtnAddBook.Name = "BtnAddBook";
            this.BtnAddBook.Size = new System.Drawing.Size(224, 30);
            this.BtnAddBook.TabIndex = 5;
            this.BtnAddBook.Text = "Əlavə et";
            this.BtnAddBook.UseVisualStyleBackColor = true;
            this.BtnAddBook.Click += new System.EventHandler(this.BtnAddBook_Click);
            // 
            // NumCount
            // 
            this.NumCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumCount.Location = new System.Drawing.Point(10, 224);
            this.NumCount.Name = "NumCount";
            this.NumCount.Size = new System.Drawing.Size(224, 24);
            this.NumCount.TabIndex = 4;
            // 
            // LblBookCount
            // 
            this.LblBookCount.AutoSize = true;
            this.LblBookCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBookCount.Location = new System.Drawing.Point(7, 199);
            this.LblBookCount.Name = "LblBookCount";
            this.LblBookCount.Size = new System.Drawing.Size(36, 18);
            this.LblBookCount.TabIndex = 6;
            this.LblBookCount.Text = "Sayı";
            // 
            // NumPrice
            // 
            this.NumPrice.DecimalPlaces = 2;
            this.NumPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumPrice.Location = new System.Drawing.Point(10, 172);
            this.NumPrice.Name = "NumPrice";
            this.NumPrice.Size = new System.Drawing.Size(224, 24);
            this.NumPrice.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Qiymət";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Müəllif";
            // 
            // TxtBookName
            // 
            this.TxtBookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBookName.Location = new System.Drawing.Point(10, 50);
            this.TxtBookName.MaxLength = 150;
            this.TxtBookName.Name = "TxtBookName";
            this.TxtBookName.Size = new System.Drawing.Size(224, 24);
            this.TxtBookName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Adı";
            // 
            // BtnAuthors
            // 
            this.BtnAuthors.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnAuthors.Location = new System.Drawing.Point(302, 9);
            this.BtnAuthors.Name = "BtnAuthors";
            this.BtnAuthors.Size = new System.Drawing.Size(180, 26);
            this.BtnAuthors.TabIndex = 9;
            this.BtnAuthors.Text = "Müəlliflər";
            this.BtnAuthors.UseVisualStyleBackColor = true;
            this.BtnAuthors.Click += new System.EventHandler(this.BtnAuthors_Click);
            // 
            // Books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 481);
            this.Controls.Add(this.BtnAuthors);
            this.Controls.Add(this.GrbCrud);
            this.Controls.Add(this.DgvBooks);
            this.Controls.Add(this.CmbShowBooks);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Books";
            this.Text = "Kitablar";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Books_FormClosed);
            this.Click += new System.EventHandler(this.Books_Click);
            ((System.ComponentModel.ISupportInitialize)(this.DgvBooks)).EndInit();
            this.GrbCrud.ResumeLayout(false);
            this.GrbCrud.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CmbShowBooks;
        private System.Windows.Forms.DataGridView DgvBooks;
        private System.Windows.Forms.GroupBox GrbCrud;
        private System.Windows.Forms.Button BtnUpdateBook;
        private System.Windows.Forms.Button BtnDeleteBook;
        private System.Windows.Forms.Button BtnAddBook;
        private System.Windows.Forms.NumericUpDown NumCount;
        private System.Windows.Forms.Label LblBookCount;
        private System.Windows.Forms.NumericUpDown NumPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtBookName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CmbAuthors;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button BtnAuthors;
    }
}