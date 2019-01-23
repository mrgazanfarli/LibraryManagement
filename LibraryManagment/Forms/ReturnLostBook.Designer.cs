namespace LibraryManagment.Forms
{
    partial class ReturnLostBook
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
            this.LblBookNotReturned = new System.Windows.Forms.Label();
            this.RbtnBookNotReturned = new System.Windows.Forms.RadioButton();
            this.RbtnBookReturned = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnFinish = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LblBookNotReturned);
            this.groupBox1.Controls.Add(this.RbtnBookNotReturned);
            this.groupBox1.Controls.Add(this.RbtnBookReturned);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(289, 139);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // LblBookNotReturned
            // 
            this.LblBookNotReturned.AutoSize = true;
            this.LblBookNotReturned.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblBookNotReturned.Location = new System.Drawing.Point(9, 106);
            this.LblBookNotReturned.Name = "LblBookNotReturned";
            this.LblBookNotReturned.Size = new System.Drawing.Size(0, 15);
            this.LblBookNotReturned.TabIndex = 6;
            this.LblBookNotReturned.Visible = false;
            // 
            // RbtnBookNotReturned
            // 
            this.RbtnBookNotReturned.AutoSize = true;
            this.RbtnBookNotReturned.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RbtnBookNotReturned.Location = new System.Drawing.Point(9, 77);
            this.RbtnBookNotReturned.Name = "RbtnBookNotReturned";
            this.RbtnBookNotReturned.Size = new System.Drawing.Size(108, 22);
            this.RbtnBookNotReturned.TabIndex = 5;
            this.RbtnBookNotReturned.TabStop = true;
            this.RbtnBookNotReturned.Text = "Qaytarılmadı";
            this.RbtnBookNotReturned.UseVisualStyleBackColor = true;
            this.RbtnBookNotReturned.CheckedChanged += new System.EventHandler(this.Rbtns_CheckedChanged);
            // 
            // RbtnBookReturned
            // 
            this.RbtnBookReturned.AutoSize = true;
            this.RbtnBookReturned.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RbtnBookReturned.Location = new System.Drawing.Point(9, 49);
            this.RbtnBookReturned.Name = "RbtnBookReturned";
            this.RbtnBookReturned.Size = new System.Drawing.Size(87, 22);
            this.RbtnBookReturned.TabIndex = 4;
            this.RbtnBookReturned.TabStop = true;
            this.RbtnBookReturned.Text = "Qaytarıldı";
            this.RbtnBookReturned.UseVisualStyleBackColor = true;
            this.RbtnBookReturned.CheckedChanged += new System.EventHandler(this.Rbtns_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "Verilən müddət ərzində kitab qaytarıldımı?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnFinish
            // 
            this.BtnFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnFinish.Location = new System.Drawing.Point(64, 156);
            this.BtnFinish.Name = "BtnFinish";
            this.BtnFinish.Size = new System.Drawing.Size(179, 36);
            this.BtnFinish.TabIndex = 4;
            this.BtnFinish.Text = "Sonlandır";
            this.BtnFinish.UseVisualStyleBackColor = true;
            this.BtnFinish.Click += new System.EventHandler(this.BtnFinish_Click);
            // 
            // ReturnLostBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 204);
            this.Controls.Add(this.BtnFinish);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReturnLostBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "İtirilmiş kitab";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RbtnBookNotReturned;
        private System.Windows.Forms.RadioButton RbtnBookReturned;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnFinish;
        private System.Windows.Forms.Label LblBookNotReturned;
    }
}