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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BorrowForm));
            this.borrowerLabel = new System.Windows.Forms.Label();
            this.databorrowedLabel = new System.Windows.Forms.Label();
            this.duedateLabel = new System.Windows.Forms.Label();
            this.borrowerName = new System.Windows.Forms.TextBox();
            this.borrowDate = new System.Windows.Forms.TextBox();
            this.dueDate = new System.Windows.Forms.TextBox();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.borrowLabel = new System.Windows.Forms.Label();
            this.borrowDG = new System.Windows.Forms.DataGridView();
            this.calendarBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.borrowedBtn = new LibrarySystem.RJButton();
            this.borrowBtn = new LibrarySystem.RJButton();
            this.borrowedDatepicker = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.borrowDG)).BeginInit();
            this.SuspendLayout();
            // 
            // borrowerLabel
            // 
            this.borrowerLabel.AutoSize = true;
            this.borrowerLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrowerLabel.Location = new System.Drawing.Point(216, 563);
            this.borrowerLabel.Name = "borrowerLabel";
            this.borrowerLabel.Size = new System.Drawing.Size(156, 18);
            this.borrowerLabel.TabIndex = 9;
            this.borrowerLabel.Text = "Borrower\'s Name: ";
            // 
            // databorrowedLabel
            // 
            this.databorrowedLabel.AutoSize = true;
            this.databorrowedLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.databorrowedLabel.Location = new System.Drawing.Point(216, 597);
            this.databorrowedLabel.Name = "databorrowedLabel";
            this.databorrowedLabel.Size = new System.Drawing.Size(134, 18);
            this.databorrowedLabel.TabIndex = 10;
            this.databorrowedLabel.Text = "Date Borrowed:";
            // 
            // duedateLabel
            // 
            this.duedateLabel.AutoSize = true;
            this.duedateLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.duedateLabel.Location = new System.Drawing.Point(216, 625);
            this.duedateLabel.Name = "duedateLabel";
            this.duedateLabel.Size = new System.Drawing.Size(87, 18);
            this.duedateLabel.TabIndex = 11;
            this.duedateLabel.Text = "Due Date:";
            // 
            // borrowerName
            // 
            this.borrowerName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrowerName.Location = new System.Drawing.Point(378, 560);
            this.borrowerName.Name = "borrowerName";
            this.borrowerName.Size = new System.Drawing.Size(192, 26);
            this.borrowerName.TabIndex = 18;
            this.borrowerName.TextChanged += new System.EventHandler(this.borrowerName_TextChanged);
            // 
            // borrowDate
            // 
            this.borrowDate.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrowDate.Location = new System.Drawing.Point(378, 598);
            this.borrowDate.Name = "borrowDate";
            this.borrowDate.Size = new System.Drawing.Size(192, 26);
            this.borrowDate.TabIndex = 19;
            this.borrowDate.TextChanged += new System.EventHandler(this.borrowDate_TextChanged);
            // 
            // dueDate
            // 
            this.dueDate.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dueDate.Location = new System.Drawing.Point(378, 630);
            this.dueDate.Name = "dueDate";
            this.dueDate.Size = new System.Drawing.Size(192, 26);
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
            // borrowLabel
            // 
            this.borrowLabel.AutoSize = true;
            this.borrowLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 33.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrowLabel.ForeColor = System.Drawing.Color.Black;
            this.borrowLabel.Location = new System.Drawing.Point(30, 35);
            this.borrowLabel.Name = "borrowLabel";
            this.borrowLabel.Size = new System.Drawing.Size(232, 52);
            this.borrowLabel.TabIndex = 25;
            this.borrowLabel.Text = "BORROW";
            // 
            // borrowDG
            // 
            this.borrowDG.BackgroundColor = System.Drawing.Color.DarkKhaki;
            this.borrowDG.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.borrowDG.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.borrowDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.borrowDG.GridColor = System.Drawing.Color.PeachPuff;
            this.borrowDG.Location = new System.Drawing.Point(39, 123);
            this.borrowDG.Name = "borrowDG";
            this.borrowDG.Size = new System.Drawing.Size(564, 358);
            this.borrowDG.TabIndex = 27;
            this.borrowDG.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.borrowDG_CellContentClick);
            // 
            // calendarBtn
            // 
            this.calendarBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.calendarBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.calendarBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.calendarBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.calendarBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.calendarBtn.FillColor = System.Drawing.Color.Olive;
            this.calendarBtn.FillColor2 = System.Drawing.Color.YellowGreen;
            this.calendarBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.calendarBtn.ForeColor = System.Drawing.Color.White;
            this.calendarBtn.Image = ((System.Drawing.Image)(resources.GetObject("calendarBtn.Image")));
            this.calendarBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.calendarBtn.Location = new System.Drawing.Point(585, 597);
            this.calendarBtn.Name = "calendarBtn";
            this.calendarBtn.Size = new System.Drawing.Size(63, 40);
            this.calendarBtn.TabIndex = 28;
            this.calendarBtn.Click += new System.EventHandler(this.calendarBtn_Click);
            // 
            // borrowedBtn
            // 
            this.borrowedBtn.BackColor = System.Drawing.Color.Olive;
            this.borrowedBtn.BackgroundColor = System.Drawing.Color.Olive;
            this.borrowedBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.borrowedBtn.BorderRadius = 25;
            this.borrowedBtn.BorderSize = 0;
            this.borrowedBtn.FlatAppearance.BorderSize = 0;
            this.borrowedBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.borrowedBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrowedBtn.ForeColor = System.Drawing.Color.White;
            this.borrowedBtn.Location = new System.Drawing.Point(264, 680);
            this.borrowedBtn.Name = "borrowedBtn";
            this.borrowedBtn.Size = new System.Drawing.Size(179, 55);
            this.borrowedBtn.TabIndex = 26;
            this.borrowedBtn.Text = "BORROWED BOOKS";
            this.borrowedBtn.TextColor = System.Drawing.Color.White;
            this.borrowedBtn.UseVisualStyleBackColor = false;
            this.borrowedBtn.Click += new System.EventHandler(this.borrowedBtn_Click);
            // 
            // borrowBtn
            // 
            this.borrowBtn.BackColor = System.Drawing.Color.Olive;
            this.borrowBtn.BackgroundColor = System.Drawing.Color.Olive;
            this.borrowBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.borrowBtn.BorderRadius = 25;
            this.borrowBtn.BorderSize = 0;
            this.borrowBtn.FlatAppearance.BorderSize = 0;
            this.borrowBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.borrowBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrowBtn.ForeColor = System.Drawing.Color.White;
            this.borrowBtn.Location = new System.Drawing.Point(490, 680);
            this.borrowBtn.Name = "borrowBtn";
            this.borrowBtn.Size = new System.Drawing.Size(179, 55);
            this.borrowBtn.TabIndex = 15;
            this.borrowBtn.Text = "BORROW";
            this.borrowBtn.TextColor = System.Drawing.Color.White;
            this.borrowBtn.UseVisualStyleBackColor = false;
            this.borrowBtn.Click += new System.EventHandler(this.borrowBtn_Click);
            // 
            // borrowedDatepicker
            // 
            this.borrowedDatepicker.CalendarForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.borrowedDatepicker.Location = new System.Drawing.Point(618, 609);
            this.borrowedDatepicker.Name = "borrowedDatepicker";
            this.borrowedDatepicker.Size = new System.Drawing.Size(19, 20);
            this.borrowedDatepicker.TabIndex = 17;
            this.borrowedDatepicker.CloseUp += new System.EventHandler(this.borrowedDatepicker_CloseUp);
            this.borrowedDatepicker.ValueChanged += new System.EventHandler(this.borrowedDatepicker_ValueChanged);
            // 
            // BorrowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 880);
            this.ControlBox = false;
            this.Controls.Add(this.borrowDG);
            this.Controls.Add(this.borrowedBtn);
            this.Controls.Add(this.borrowLabel);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Controls.Add(this.dueDate);
            this.Controls.Add(this.borrowDate);
            this.Controls.Add(this.borrowerName);
            this.Controls.Add(this.borrowedDatepicker);
            this.Controls.Add(this.borrowBtn);
            this.Controls.Add(this.duedateLabel);
            this.Controls.Add(this.databorrowedLabel);
            this.Controls.Add(this.borrowerLabel);
            this.Controls.Add(this.calendarBtn);
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
        private System.Windows.Forms.TextBox borrowerName;
        private System.Windows.Forms.TextBox borrowDate;
        private System.Windows.Forms.TextBox dueDate;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private System.Windows.Forms.Label borrowLabel;
        private RJButton borrowedBtn;
        private System.Windows.Forms.DataGridView borrowDG;
        private Guna.UI2.WinForms.Guna2GradientButton calendarBtn;
        private System.Windows.Forms.DateTimePicker borrowedDatepicker;
    }
}