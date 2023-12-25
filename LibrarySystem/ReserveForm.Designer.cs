namespace LibrarySystem
{
    partial class ReserveForm
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
            this.bnameLabel = new System.Windows.Forms.Label();
            this.btitleLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.reservedateLabel = new System.Windows.Forms.Label();
            this.reserveddateTb = new System.Windows.Forms.TextBox();
            this.reservedatepicker = new System.Windows.Forms.DateTimePicker();
            this.borrowernameTb = new System.Windows.Forms.TextBox();
            this.reserveBtn = new LibrarySystem.RJButton();
            this.SuspendLayout();
            // 
            // bnameLabel
            // 
            this.bnameLabel.AutoSize = true;
            this.bnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnameLabel.Location = new System.Drawing.Point(311, 494);
            this.bnameLabel.Name = "bnameLabel";
            this.bnameLabel.Size = new System.Drawing.Size(150, 20);
            this.bnameLabel.TabIndex = 0;
            this.bnameLabel.Text = "Borrower\'s Name:";
            // 
            // btitleLabel
            // 
            this.btitleLabel.AutoSize = true;
            this.btitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btitleLabel.Location = new System.Drawing.Point(311, 455);
            this.btitleLabel.Name = "btitleLabel";
            this.btitleLabel.Size = new System.Drawing.Size(94, 20);
            this.btitleLabel.TabIndex = 2;
            this.btitleLabel.Text = "Book Title:";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(467, 455);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(39, 20);
            this.titleLabel.TabIndex = 3;
            this.titleLabel.Text = "title";
            // 
            // reservedateLabel
            // 
            this.reservedateLabel.AutoSize = true;
            this.reservedateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reservedateLabel.Location = new System.Drawing.Point(311, 529);
            this.reservedateLabel.Name = "reservedateLabel";
            this.reservedateLabel.Size = new System.Drawing.Size(134, 20);
            this.reservedateLabel.TabIndex = 4;
            this.reservedateLabel.Text = "Reserved Date:";
            // 
            // reserveddateTb
            // 
            this.reserveddateTb.Location = new System.Drawing.Point(471, 531);
            this.reserveddateTb.Name = "reserveddateTb";
            this.reserveddateTb.Size = new System.Drawing.Size(121, 20);
            this.reserveddateTb.TabIndex = 5;
            this.reserveddateTb.Text = "d";
            // 
            // reservedatepicker
            // 
            this.reservedatepicker.Location = new System.Drawing.Point(598, 531);
            this.reservedatepicker.Name = "reservedatepicker";
            this.reservedatepicker.Size = new System.Drawing.Size(200, 20);
            this.reservedatepicker.TabIndex = 6;
            this.reservedatepicker.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // borrowernameTb
            // 
            this.borrowernameTb.Location = new System.Drawing.Point(471, 496);
            this.borrowernameTb.Name = "borrowernameTb";
            this.borrowernameTb.Size = new System.Drawing.Size(121, 20);
            this.borrowernameTb.TabIndex = 7;
            // 
            // reserveBtn
            // 
            this.reserveBtn.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.reserveBtn.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.reserveBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.reserveBtn.BorderRadius = 0;
            this.reserveBtn.BorderSize = 0;
            this.reserveBtn.FlatAppearance.BorderSize = 0;
            this.reserveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reserveBtn.ForeColor = System.Drawing.Color.White;
            this.reserveBtn.Location = new System.Drawing.Point(471, 571);
            this.reserveBtn.Name = "reserveBtn";
            this.reserveBtn.Size = new System.Drawing.Size(150, 40);
            this.reserveBtn.TabIndex = 8;
            this.reserveBtn.Text = "RESERVE";
            this.reserveBtn.TextColor = System.Drawing.Color.White;
            this.reserveBtn.UseVisualStyleBackColor = false;
            this.reserveBtn.Click += new System.EventHandler(this.reserveBtn_Click);
            // 
            // ReserveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 880);
            this.ControlBox = false;
            this.Controls.Add(this.reserveBtn);
            this.Controls.Add(this.borrowernameTb);
            this.Controls.Add(this.reservedatepicker);
            this.Controls.Add(this.reserveddateTb);
            this.Controls.Add(this.reservedateLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.btitleLabel);
            this.Controls.Add(this.bnameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReserveForm";
            this.Load += new System.EventHandler(this.ReserveForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label bnameLabel;
        private System.Windows.Forms.Label btitleLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label reservedateLabel;
        private System.Windows.Forms.TextBox reserveddateTb;
        private System.Windows.Forms.DateTimePicker reservedatepicker;
        private System.Windows.Forms.TextBox borrowernameTb;
        private RJButton reserveBtn;
    }
}