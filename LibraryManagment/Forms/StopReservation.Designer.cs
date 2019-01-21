namespace LibraryManagment.Forms
{
    partial class StopReservation
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
            this.NumPenalty = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.CmbBookStatus = new System.Windows.Forms.ComboBox();
            this.TxtComment = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnEndReservation = new System.Windows.Forms.Button();
            this.LblLimitToReturn = new System.Windows.Forms.Label();
            this.NumLimitToReturn = new System.Windows.Forms.NumericUpDown();
            this.RbtnGiveChance = new System.Windows.Forms.RadioButton();
            this.RbtnSetPayment = new System.Windows.Forms.RadioButton();
            this.RbtnNoOptions = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.NumPenalty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumLimitToReturn)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cərimə";
            // 
            // NumPenalty
            // 
            this.NumPenalty.DecimalPlaces = 2;
            this.NumPenalty.Enabled = false;
            this.NumPenalty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumPenalty.Location = new System.Drawing.Point(16, 36);
            this.NumPenalty.Name = "NumPenalty";
            this.NumPenalty.Size = new System.Drawing.Size(204, 23);
            this.NumPenalty.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(13, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kitabın vəziyyəti";
            // 
            // CmbBookStatus
            // 
            this.CmbBookStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CmbBookStatus.FormattingEnabled = true;
            this.CmbBookStatus.Location = new System.Drawing.Point(16, 99);
            this.CmbBookStatus.Name = "CmbBookStatus";
            this.CmbBookStatus.Size = new System.Drawing.Size(204, 24);
            this.CmbBookStatus.TabIndex = 3;
            this.CmbBookStatus.SelectedIndexChanged += new System.EventHandler(this.CmbBookStatus_SelectedIndexChanged);
            // 
            // TxtComment
            // 
            this.TxtComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TxtComment.Location = new System.Drawing.Point(16, 183);
            this.TxtComment.Name = "TxtComment";
            this.TxtComment.Size = new System.Drawing.Size(204, 96);
            this.TxtComment.TabIndex = 4;
            this.TxtComment.Text = "Normaldır.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(13, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Rəy";
            // 
            // BtnEndReservation
            // 
            this.BtnEndReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnEndReservation.Location = new System.Drawing.Point(16, 347);
            this.BtnEndReservation.Name = "BtnEndReservation";
            this.BtnEndReservation.Size = new System.Drawing.Size(204, 31);
            this.BtnEndReservation.TabIndex = 6;
            this.BtnEndReservation.Text = "Bitir";
            this.BtnEndReservation.UseVisualStyleBackColor = true;
            this.BtnEndReservation.Click += new System.EventHandler(this.BtnEndReservation_Click);
            // 
            // LblLimitToReturn
            // 
            this.LblLimitToReturn.AutoSize = true;
            this.LblLimitToReturn.Enabled = false;
            this.LblLimitToReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblLimitToReturn.Location = new System.Drawing.Point(12, 290);
            this.LblLimitToReturn.Name = "LblLimitToReturn";
            this.LblLimitToReturn.Size = new System.Drawing.Size(88, 17);
            this.LblLimitToReturn.TabIndex = 7;
            this.LblLimitToReturn.Text = "Möhlət (gün)";
            // 
            // NumLimitToReturn
            // 
            this.NumLimitToReturn.Enabled = false;
            this.NumLimitToReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumLimitToReturn.Location = new System.Drawing.Point(16, 312);
            this.NumLimitToReturn.Name = "NumLimitToReturn";
            this.NumLimitToReturn.Size = new System.Drawing.Size(202, 23);
            this.NumLimitToReturn.TabIndex = 8;
            // 
            // RbtnGiveChance
            // 
            this.RbtnGiveChance.AutoSize = true;
            this.RbtnGiveChance.Enabled = false;
            this.RbtnGiveChance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RbtnGiveChance.Location = new System.Drawing.Point(16, 130);
            this.RbtnGiveChance.Name = "RbtnGiveChance";
            this.RbtnGiveChance.Size = new System.Drawing.Size(57, 17);
            this.RbtnGiveChance.TabIndex = 9;
            this.RbtnGiveChance.Text = "Möhlət";
            this.RbtnGiveChance.UseVisualStyleBackColor = true;
            this.RbtnGiveChance.CheckedChanged += new System.EventHandler(this.RbtnNoOptions_CheckedChanged);
            // 
            // RbtnSetPayment
            // 
            this.RbtnSetPayment.AutoSize = true;
            this.RbtnSetPayment.Enabled = false;
            this.RbtnSetPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RbtnSetPayment.Location = new System.Drawing.Point(77, 130);
            this.RbtnSetPayment.Name = "RbtnSetPayment";
            this.RbtnSetPayment.Size = new System.Drawing.Size(87, 17);
            this.RbtnSetPayment.TabIndex = 10;
            this.RbtnSetPayment.Text = "Əlavə cərimə";
            this.RbtnSetPayment.UseVisualStyleBackColor = true;
            this.RbtnSetPayment.CheckedChanged += new System.EventHandler(this.RbtnNoOptions_CheckedChanged);
            // 
            // RbtnNoOptions
            // 
            this.RbtnNoOptions.AutoSize = true;
            this.RbtnNoOptions.Checked = true;
            this.RbtnNoOptions.Enabled = false;
            this.RbtnNoOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RbtnNoOptions.Location = new System.Drawing.Point(168, 130);
            this.RbtnNoOptions.Name = "RbtnNoOptions";
            this.RbtnNoOptions.Size = new System.Drawing.Size(61, 17);
            this.RbtnNoOptions.TabIndex = 11;
            this.RbtnNoOptions.TabStop = true;
            this.RbtnNoOptions.Text = "Heç biri";
            this.RbtnNoOptions.UseVisualStyleBackColor = true;
            this.RbtnNoOptions.CheckedChanged += new System.EventHandler(this.RbtnNoOptions_CheckedChanged);
            // 
            // StopReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 387);
            this.Controls.Add(this.RbtnNoOptions);
            this.Controls.Add(this.RbtnSetPayment);
            this.Controls.Add(this.RbtnGiveChance);
            this.Controls.Add(this.NumLimitToReturn);
            this.Controls.Add(this.LblLimitToReturn);
            this.Controls.Add(this.BtnEndReservation);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtComment);
            this.Controls.Add(this.CmbBookStatus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NumPenalty);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StopReservation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Kitab Qaytarılması";
            ((System.ComponentModel.ISupportInitialize)(this.NumPenalty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumLimitToReturn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown NumPenalty;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CmbBookStatus;
        private System.Windows.Forms.RichTextBox TxtComment;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnEndReservation;
        private System.Windows.Forms.Label LblLimitToReturn;
        private System.Windows.Forms.NumericUpDown NumLimitToReturn;
        private System.Windows.Forms.RadioButton RbtnGiveChance;
        private System.Windows.Forms.RadioButton RbtnSetPayment;
        private System.Windows.Forms.RadioButton RbtnNoOptions;
    }
}