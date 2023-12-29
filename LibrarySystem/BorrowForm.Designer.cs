namespace LibrarySystem
{
    partial class BorrowForm
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
            this.borrowerLabel = new System.Windows.Forms.Label();
            this.databorrowedLabel = new System.Windows.Forms.Label();
            this.duedateLabel = new System.Windows.Forms.Label();
            this.borrowedDatepicker = new System.Windows.Forms.DateTimePicker();
            this.borrowerName = new System.Windows.Forms.TextBox();
            this.borrowDate = new System.Windows.Forms.TextBox();
            this.dueDate = new System.Windows.Forms.TextBox();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.booklistLabel = new System.Windows.Forms.Label();
            this.borrowDG = new System.Windows.Forms.DataGridView();
            this.rjButton1 = new LibrarySystem.RJButton();
            this.borrowBtn = new LibrarySystem.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.borrowDG)).BeginInit();
            this.SuspendLayout();
            // 
            // borrowerLabel
            // 
            this.borrowerLabel.AutoSize = true;
            this.borrowerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrowerLabel.Location = new System.Drawing.Point(258, 617);
            this.borrowerLabel.Name = "borrowerLabel";
            this.borrowerLabel.Size = new System.Drawing.Size(134, 16);
            this.borrowerLabel.TabIndex = 9;
            this.borrowerLabel.Text = "Borrower\'s Name: ";
            // 
            // databorrowedLabel
            // 
            this.databorrowedLabel.AutoSize = true;
            this.databorrowedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.databorrowedLabel.Location = new System.Drawing.Point(258, 657);
            this.databorrowedLabel.Name = "databorrowedLabel";
            this.databorrowedLabel.Size = new System.Drawing.Size(114, 16);
            this.databorrowedLabel.TabIndex = 10;
            this.databorrowedLabel.Text = "Date Borrowed:";
            // 
            // duedateLabel
            // 
            this.duedateLabel.AutoSize = true;
            this.duedateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.duedateLabel.Location = new System.Drawing.Point(258, 693);
            this.duedateLabel.Name = "duedateLabel";
            this.duedateLabel.Size = new System.Drawing.Size(76, 16);
            this.duedateLabel.TabIndex = 11;
            this.duedateLabel.Text = "Due Date:";
            // 
            // borrowedDatepicker
            // 
            this.borrowedDatepicker.Location = new System.Drawing.Point(534, 660);
            this.borrowedDatepicker.Name = "borrowedDatepicker";
            this.borrowedDatepicker.Size = new System.Drawing.Size(200, 20);
            this.borrowedDatepicker.TabIndex = 17;
            this.borrowedDatepicker.ValueChanged += new System.EventHandler(this.borrowedDatepicker_ValueChanged);
            // 
            // borrowerName
            // 
            this.borrowerName.Location = new System.Drawing.Point(398, 617);
            this.borrowerName.Name = "borrowerName";
            this.borrowerName.Size = new System.Drawing.Size(119, 20);
            this.borrowerName.TabIndex = 18;
            this.borrowerName.TextChanged += new System.EventHandler(this.borrowerName_TextChanged);
            // 
            // borrowDate
            // 
            this.borrowDate.Location = new System.Drawing.Point(398, 660);
            this.borrowDate.Name = "borrowDate";
            this.borrowDate.Size = new System.Drawing.Size(119, 20);
            this.borrowDate.TabIndex = 19;
            this.borrowDate.TextChanged += new System.EventHandler(this.borrowDate_TextChanged);
            // 
            // dueDate
            // 
            this.dueDate.Location = new System.Drawing.Point(398, 693);
            this.dueDate.Name = "dueDate";
            this.dueDate.Size = new System.Drawing.Size(119, 20);
            this.dueDate.TabIndex = 20;
            this.dueDate.TextChanged += new System.EventHandler(this.dueDate_TextChanged);
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.Olive;
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.Khaki;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(39, 90);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(871, 5);
            this.guna2GradientPanel1.TabIndex = 21;
            // 
            // booklistLabel
            // 
            this.booklistLabel.AutoSize = true;
            this.booklistLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 33.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.booklistLabel.ForeColor = System.Drawing.Color.Black;
            this.booklistLabel.Location = new System.Drawing.Point(30, 35);
            this.booklistLabel.Name = "booklistLabel";
            this.booklistLabel.Size = new System.Drawing.Size(232, 52);
            this.booklistLabel.TabIndex = 25;
            this.booklistLabel.Text = "BORROW";
            // 
            // borrowDG
            // 
            this.borrowDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.borrowDG.Location = new System.Drawing.Point(39, 123);
            this.borrowDG.Name = "borrowDG";
            this.borrowDG.Size = new System.Drawing.Size(531, 358);
            this.borrowDG.TabIndex = 27;
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton1.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton1.BorderRadius = 0;
            this.rjButton1.BorderSize = 0;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.ForeColor = System.Drawing.Color.White;
            this.rjButton1.Location = new System.Drawing.Point(302, 754);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(150, 40);
            this.rjButton1.TabIndex = 26;
            this.rjButton1.Text = "BORROWED BOOKS";
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            // 
            // borrowBtn
            // 
            this.borrowBtn.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.borrowBtn.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.borrowBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.borrowBtn.BorderRadius = 0;
            this.borrowBtn.BorderSize = 0;
            this.borrowBtn.FlatAppearance.BorderSize = 0;
            this.borrowBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.borrowBtn.ForeColor = System.Drawing.Color.White;
            this.borrowBtn.Location = new System.Drawing.Point(480, 754);
            this.borrowBtn.Name = "borrowBtn";
            this.borrowBtn.Size = new System.Drawing.Size(150, 40);
            this.borrowBtn.TabIndex = 15;
            this.borrowBtn.Text = "BORROW";
            this.borrowBtn.TextColor = System.Drawing.Color.White;
            this.borrowBtn.UseVisualStyleBackColor = false;
            this.borrowBtn.Click += new System.EventHandler(this.borrowBtn_Click);
            // 
            // BorrowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 880);
            this.ControlBox = false;
            this.Controls.Add(this.borrowDG);
            this.Controls.Add(this.rjButton1);
            this.Controls.Add(this.booklistLabel);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Controls.Add(this.dueDate);
            this.Controls.Add(this.borrowDate);
            this.Controls.Add(this.borrowerName);
            this.Controls.Add(this.borrowedDatepicker);
            this.Controls.Add(this.borrowBtn);
            this.Controls.Add(this.duedateLabel);
            this.Controls.Add(this.databorrowedLabel);
            this.Controls.Add(this.borrowerLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BorrowForm";
            this.Load += new System.EventHandler(this.BorrowForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.borrowDG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label borrowerLabel;
        private System.Windows.Forms.Label databorrowedLabel;
        private System.Windows.Forms.Label duedateLabel;
        private RJButton borrowBtn;
        private System.Windows.Forms.DateTimePicker borrowedDatepicker;
        private System.Windows.Forms.TextBox borrowerName;
        private System.Windows.Forms.TextBox borrowDate;
        private System.Windows.Forms.TextBox dueDate;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private System.Windows.Forms.Label booklistLabel;
        private RJButton rjButton1;
        private System.Windows.Forms.DataGridView borrowDG;
    }
}