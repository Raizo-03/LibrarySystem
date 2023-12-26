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
            this.reservedbooksDG = new System.Windows.Forms.DataGridView();
            this.deleteBtn = new LibrarySystem.RJButton();
            this.editBtn = new LibrarySystem.RJButton();
            this.rbooksBtn = new LibrarySystem.RJButton();
            this.reserveBtn = new LibrarySystem.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.reservedbooksDG)).BeginInit();
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
            // reservedbooksDG
            // 
            this.reservedbooksDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reservedbooksDG.Location = new System.Drawing.Point(315, 54);
            this.reservedbooksDG.Name = "reservedbooksDG";
            this.reservedbooksDG.Size = new System.Drawing.Size(452, 361);
            this.reservedbooksDG.TabIndex = 11;
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.deleteBtn.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.deleteBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.deleteBtn.BorderRadius = 0;
            this.deleteBtn.BorderSize = 0;
            this.deleteBtn.FlatAppearance.BorderSize = 0;
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.ForeColor = System.Drawing.Color.White;
            this.deleteBtn.Location = new System.Drawing.Point(649, 625);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(150, 40);
            this.deleteBtn.TabIndex = 13;
            this.deleteBtn.Text = "DELETE";
            this.deleteBtn.TextColor = System.Drawing.Color.White;
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.editBtn.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.editBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.editBtn.BorderRadius = 0;
            this.editBtn.BorderSize = 0;
            this.editBtn.FlatAppearance.BorderSize = 0;
            this.editBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editBtn.ForeColor = System.Drawing.Color.White;
            this.editBtn.Location = new System.Drawing.Point(649, 567);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(150, 40);
            this.editBtn.TabIndex = 10;
            this.editBtn.Text = "EDIT";
            this.editBtn.TextColor = System.Drawing.Color.White;
            this.editBtn.UseVisualStyleBackColor = false;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // rbooksBtn
            // 
            this.rbooksBtn.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.rbooksBtn.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.rbooksBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rbooksBtn.BorderRadius = 0;
            this.rbooksBtn.BorderSize = 0;
            this.rbooksBtn.FlatAppearance.BorderSize = 0;
            this.rbooksBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbooksBtn.ForeColor = System.Drawing.Color.White;
            this.rbooksBtn.Location = new System.Drawing.Point(471, 567);
            this.rbooksBtn.Name = "rbooksBtn";
            this.rbooksBtn.Size = new System.Drawing.Size(150, 40);
            this.rbooksBtn.TabIndex = 9;
            this.rbooksBtn.Text = "RESERVED BOOKS";
            this.rbooksBtn.TextColor = System.Drawing.Color.White;
            this.rbooksBtn.UseVisualStyleBackColor = false;
            this.rbooksBtn.Click += new System.EventHandler(this.rbooksBtn_Click);
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
            this.reserveBtn.Location = new System.Drawing.Point(295, 567);
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
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.reservedbooksDG);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.rbooksBtn);
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
            ((System.ComponentModel.ISupportInitialize)(this.reservedbooksDG)).EndInit();
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
        private RJButton rbooksBtn;
        private RJButton editBtn;
        private System.Windows.Forms.DataGridView reservedbooksDG;
        private RJButton deleteBtn;
    }
}