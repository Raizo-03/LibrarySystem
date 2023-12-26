namespace LibrarySystem
{
    partial class ReturnForm
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
            this.borrowerName = new System.Windows.Forms.Label();
            this.bName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.returndateTb = new System.Windows.Forms.TextBox();
            this.returndatePicker = new System.Windows.Forms.DateTimePicker();
            this.dueDateLabel = new System.Windows.Forms.Label();
            this.bkTitleLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.returnBtn = new LibrarySystem.RJButton();
            this.SuspendLayout();
            // 
            // borrowerName
            // 
            this.borrowerName.AutoSize = true;
            this.borrowerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrowerName.Location = new System.Drawing.Point(68, 532);
            this.borrowerName.Name = "borrowerName";
            this.borrowerName.Size = new System.Drawing.Size(145, 18);
            this.borrowerName.TabIndex = 0;
            this.borrowerName.Text = "Borrower\'s Name:";
            // 
            // bName
            // 
            this.bName.AutoSize = true;
            this.bName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bName.Location = new System.Drawing.Point(214, 532);
            this.bName.Name = "bName";
            this.bName.Size = new System.Drawing.Size(46, 18);
            this.bName.TabIndex = 1;
            this.bName.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(68, 571);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Due Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(68, 605);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Return Date:";
            // 
            // returndateTb
            // 
            this.returndateTb.Location = new System.Drawing.Point(177, 605);
            this.returndateTb.Name = "returndateTb";
            this.returndateTb.Size = new System.Drawing.Size(127, 20);
            this.returndateTb.TabIndex = 4;
            // 
            // returndatePicker
            // 
            this.returndatePicker.Location = new System.Drawing.Point(310, 605);
            this.returndatePicker.Name = "returndatePicker";
            this.returndatePicker.Size = new System.Drawing.Size(200, 20);
            this.returndatePicker.TabIndex = 5;
            this.returndatePicker.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dueDateLabel
            // 
            this.dueDateLabel.AutoSize = true;
            this.dueDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dueDateLabel.Location = new System.Drawing.Point(174, 571);
            this.dueDateLabel.Name = "dueDateLabel";
            this.dueDateLabel.Size = new System.Drawing.Size(46, 18);
            this.dueDateLabel.TabIndex = 6;
            this.dueDateLabel.Text = "label1";
            // 
            // bkTitleLabel
            // 
            this.bkTitleLabel.AutoSize = true;
            this.bkTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bkTitleLabel.Location = new System.Drawing.Point(68, 499);
            this.bkTitleLabel.Name = "bkTitleLabel";
            this.bkTitleLabel.Size = new System.Drawing.Size(90, 18);
            this.bkTitleLabel.TabIndex = 7;
            this.bkTitleLabel.Text = "Book Title:";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(174, 499);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(0, 18);
            this.titleLabel.TabIndex = 8;
            // 
            // returnBtn
            // 
            this.returnBtn.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.returnBtn.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.returnBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.returnBtn.BorderRadius = 0;
            this.returnBtn.BorderSize = 0;
            this.returnBtn.FlatAppearance.BorderSize = 0;
            this.returnBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.returnBtn.ForeColor = System.Drawing.Color.White;
            this.returnBtn.Location = new System.Drawing.Point(421, 661);
            this.returnBtn.Name = "returnBtn";
            this.returnBtn.Size = new System.Drawing.Size(150, 40);
            this.returnBtn.TabIndex = 9;
            this.returnBtn.Text = "RETURN";
            this.returnBtn.TextColor = System.Drawing.Color.White;
            this.returnBtn.UseVisualStyleBackColor = false;
            this.returnBtn.Click += new System.EventHandler(this.returnBtn_Click);
            // 
            // ReturnForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 880);
            this.ControlBox = false;
            this.Controls.Add(this.returnBtn);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.bkTitleLabel);
            this.Controls.Add(this.dueDateLabel);
            this.Controls.Add(this.returndatePicker);
            this.Controls.Add(this.returndateTb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bName);
            this.Controls.Add(this.borrowerName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReturnForm";
            this.Load += new System.EventHandler(this.ReturnForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label borrowerName;
        private System.Windows.Forms.Label bName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox returndateTb;
        private System.Windows.Forms.DateTimePicker returndatePicker;
        private System.Windows.Forms.Label dueDateLabel;
        private System.Windows.Forms.Label bkTitleLabel;
        private System.Windows.Forms.Label titleLabel;
        private RJButton returnBtn;
    }
}