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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.borrowedDatepicker = new System.Windows.Forms.DateTimePicker();
            this.upperlabelPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.upperlabelTransition = new System.Windows.Forms.Timer(this.components);
            this.timeBtn = new Guna.UI2.WinForms.Guna2GradientCircleButton();
            this.guna2GradientCircleButton2 = new Guna.UI2.WinForms.Guna2GradientCircleButton();
            this.borrowedBtn = new LibrarySystem.RJButton();
            this.borrowBtn = new LibrarySystem.RJButton();
            this.label1 = new System.Windows.Forms.Label();
            this.profilePic = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bnameInfo = new System.Windows.Forms.Label();
            this.bID = new System.Windows.Forms.Label();
            this.category = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.borrowDG)).BeginInit();
            this.upperlabelPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePic)).BeginInit();
            this.SuspendLayout();
            // 
            // borrowerLabel
            // 
            this.borrowerLabel.AutoSize = true;
            this.borrowerLabel.Font = new System.Drawing.Font("Book Antiqua", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrowerLabel.Location = new System.Drawing.Point(423, 635);
            this.borrowerLabel.Name = "borrowerLabel";
            this.borrowerLabel.Size = new System.Drawing.Size(154, 22);
            this.borrowerLabel.TabIndex = 9;
            this.borrowerLabel.Text = "Borrower\'s Name: ";
            // 
            // databorrowedLabel
            // 
            this.databorrowedLabel.AutoSize = true;
            this.databorrowedLabel.Font = new System.Drawing.Font("Book Antiqua", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.databorrowedLabel.Location = new System.Drawing.Point(423, 669);
            this.databorrowedLabel.Name = "databorrowedLabel";
            this.databorrowedLabel.Size = new System.Drawing.Size(132, 22);
            this.databorrowedLabel.TabIndex = 10;
            this.databorrowedLabel.Text = "Date Borrowed:";
            // 
            // duedateLabel
            // 
            this.duedateLabel.AutoSize = true;
            this.duedateLabel.Font = new System.Drawing.Font("Book Antiqua", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.duedateLabel.Location = new System.Drawing.Point(423, 697);
            this.duedateLabel.Name = "duedateLabel";
            this.duedateLabel.Size = new System.Drawing.Size(89, 22);
            this.duedateLabel.TabIndex = 11;
            this.duedateLabel.Text = "Due Date:";
            // 
            // borrowerName
            // 
            this.borrowerName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.borrowerName.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrowerName.Location = new System.Drawing.Point(585, 638);
            this.borrowerName.Name = "borrowerName";
            this.borrowerName.Size = new System.Drawing.Size(192, 19);
            this.borrowerName.TabIndex = 18;
            this.borrowerName.TextChanged += new System.EventHandler(this.borrowerName_TextChanged);
            // 
            // borrowDate
            // 
            this.borrowDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.borrowDate.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrowDate.Location = new System.Drawing.Point(585, 670);
            this.borrowDate.Name = "borrowDate";
            this.borrowDate.Size = new System.Drawing.Size(192, 19);
            this.borrowDate.TabIndex = 19;
            this.borrowDate.TextChanged += new System.EventHandler(this.borrowDate_TextChanged);
            // 
            // dueDate
            // 
            this.dueDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dueDate.Font = new System.Drawing.Font("Bookman Old Style", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dueDate.Location = new System.Drawing.Point(585, 702);
            this.dueDate.Name = "dueDate";
            this.dueDate.Size = new System.Drawing.Size(192, 20);
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
            this.borrowLabel.Font = new System.Drawing.Font("Book Antiqua", 33.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrowLabel.ForeColor = System.Drawing.Color.Sienna;
            this.borrowLabel.Location = new System.Drawing.Point(3, 0);
            this.borrowLabel.Name = "borrowLabel";
            this.borrowLabel.Size = new System.Drawing.Size(68, 318);
            this.borrowLabel.TabIndex = 25;
            this.borrowLabel.Text = "BORROW";
            // 
            // borrowDG
            // 
            this.borrowDG.BackgroundColor = System.Drawing.Color.DarkKhaki;
            this.borrowDG.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.borrowDG.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.borrowDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkGoldenrod;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.borrowDG.DefaultCellStyle = dataGridViewCellStyle1;
            this.borrowDG.GridColor = System.Drawing.Color.PeachPuff;
            this.borrowDG.Location = new System.Drawing.Point(39, 123);
            this.borrowDG.Name = "borrowDG";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Goldenrod;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.borrowDG.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
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
            this.calendarBtn.Location = new System.Drawing.Point(792, 669);
            this.calendarBtn.Name = "calendarBtn";
            this.calendarBtn.Size = new System.Drawing.Size(63, 40);
            this.calendarBtn.TabIndex = 28;
            this.calendarBtn.Click += new System.EventHandler(this.calendarBtn_Click);
            // 
            // borrowedDatepicker
            // 
            this.borrowedDatepicker.CalendarFont = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrowedDatepicker.CalendarForeColor = System.Drawing.Color.DarkGoldenrod;
            this.borrowedDatepicker.CalendarMonthBackground = System.Drawing.Color.Tan;
            this.borrowedDatepicker.CalendarTitleBackColor = System.Drawing.Color.DarkGoldenrod;
            this.borrowedDatepicker.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrowedDatepicker.Location = new System.Drawing.Point(825, 681);
            this.borrowedDatepicker.Name = "borrowedDatepicker";
            this.borrowedDatepicker.Size = new System.Drawing.Size(19, 21);
            this.borrowedDatepicker.TabIndex = 17;
            this.borrowedDatepicker.CloseUp += new System.EventHandler(this.borrowedDatepicker_CloseUp);
            this.borrowedDatepicker.ValueChanged += new System.EventHandler(this.borrowedDatepicker_ValueChanged);
            // 
            // upperlabelPanel
            // 
            this.upperlabelPanel.Controls.Add(this.borrowLabel);
            this.upperlabelPanel.Location = new System.Drawing.Point(39, 31);
            this.upperlabelPanel.Name = "upperlabelPanel";
            this.upperlabelPanel.Size = new System.Drawing.Size(15, 53);
            this.upperlabelPanel.TabIndex = 29;
            // 
            // upperlabelTransition
            // 
            this.upperlabelTransition.Tick += new System.EventHandler(this.upperlabelTransition_Tick);
            // 
            // timeBtn
            // 
            this.timeBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.timeBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.timeBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.timeBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.timeBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.timeBtn.FillColor = System.Drawing.Color.DarkGoldenrod;
            this.timeBtn.FillColor2 = System.Drawing.Color.Tan;
            this.timeBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.timeBtn.ForeColor = System.Drawing.Color.White;
            this.timeBtn.Image = ((System.Drawing.Image)(resources.GetObject("timeBtn.Image")));
            this.timeBtn.Location = new System.Drawing.Point(875, 12);
            this.timeBtn.Name = "timeBtn";
            this.timeBtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.timeBtn.Size = new System.Drawing.Size(35, 32);
            this.timeBtn.TabIndex = 34;
            this.timeBtn.Click += new System.EventHandler(this.timeBtn_Click);
            // 
            // guna2GradientCircleButton2
            // 
            this.guna2GradientCircleButton2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientCircleButton2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientCircleButton2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientCircleButton2.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientCircleButton2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientCircleButton2.FillColor = System.Drawing.Color.DarkGoldenrod;
            this.guna2GradientCircleButton2.FillColor2 = System.Drawing.Color.Tan;
            this.guna2GradientCircleButton2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GradientCircleButton2.ForeColor = System.Drawing.Color.White;
            this.guna2GradientCircleButton2.Image = ((System.Drawing.Image)(resources.GetObject("guna2GradientCircleButton2.Image")));
            this.guna2GradientCircleButton2.Location = new System.Drawing.Point(875, 52);
            this.guna2GradientCircleButton2.Name = "guna2GradientCircleButton2";
            this.guna2GradientCircleButton2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2GradientCircleButton2.Size = new System.Drawing.Size(35, 32);
            this.guna2GradientCircleButton2.TabIndex = 35;
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
            this.borrowedBtn.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrowedBtn.ForeColor = System.Drawing.Color.White;
            this.borrowedBtn.Location = new System.Drawing.Point(381, 759);
            this.borrowedBtn.Name = "borrowedBtn";
            this.borrowedBtn.Size = new System.Drawing.Size(223, 55);
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
            this.borrowBtn.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrowBtn.ForeColor = System.Drawing.Color.White;
            this.borrowBtn.Location = new System.Drawing.Point(679, 759);
            this.borrowBtn.Name = "borrowBtn";
            this.borrowBtn.Size = new System.Drawing.Size(223, 55);
            this.borrowBtn.TabIndex = 15;
            this.borrowBtn.Text = "BORROW";
            this.borrowBtn.TextColor = System.Drawing.Color.White;
            this.borrowBtn.UseVisualStyleBackColor = false;
            this.borrowBtn.Click += new System.EventHandler(this.borrowBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 498);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 26);
            this.label1.TabIndex = 36;
            this.label1.Text = "BORROWER INFO";
            // 
            // profilePic
            // 
            this.profilePic.Image = ((System.Drawing.Image)(resources.GetObject("profilePic.Image")));
            this.profilePic.ImageRotate = 0F;
            this.profilePic.Location = new System.Drawing.Point(62, 532);
            this.profilePic.Name = "profilePic";
            this.profilePic.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.profilePic.Size = new System.Drawing.Size(166, 159);
            this.profilePic.TabIndex = 37;
            this.profilePic.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 703);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 21);
            this.label2.TabIndex = 38;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 776);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 21);
            this.label3.TabIndex = 39;
            this.label3.Text = "Category:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 739);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 21);
            this.label4.TabIndex = 40;
            this.label4.Text = "Student ID:";
            // 
            // bnameInfo
            // 
            this.bnameInfo.AutoSize = true;
            this.bnameInfo.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnameInfo.Location = new System.Drawing.Point(134, 702);
            this.bnameInfo.Name = "bnameInfo";
            this.bnameInfo.Size = new System.Drawing.Size(18, 20);
            this.bnameInfo.TabIndex = 41;
            this.bnameInfo.Text = "n";
            // 
            // bID
            // 
            this.bID.AutoSize = true;
            this.bID.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bID.Location = new System.Drawing.Point(136, 739);
            this.bID.Name = "bID";
            this.bID.Size = new System.Drawing.Size(18, 20);
            this.bID.TabIndex = 42;
            this.bID.Text = "n";
            // 
            // category
            // 
            this.category.AutoSize = true;
            this.category.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.category.Location = new System.Drawing.Point(136, 776);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(18, 20);
            this.category.TabIndex = 43;
            this.category.Text = "n";
            // 
            // BorrowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 880);
            this.ControlBox = false;
            this.Controls.Add(this.category);
            this.Controls.Add(this.bID);
            this.Controls.Add(this.bnameInfo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.profilePic);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2GradientCircleButton2);
            this.Controls.Add(this.timeBtn);
            this.Controls.Add(this.upperlabelPanel);
            this.Controls.Add(this.borrowDG);
            this.Controls.Add(this.borrowedBtn);
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
            this.upperlabelPanel.ResumeLayout(false);
            this.upperlabelPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label borrowerLabel;
        private System.Windows.Forms.Label databorrowedLabel;
        private System.Windows.Forms.Label duedateLabel;
        private System.Windows.Forms.TextBox borrowerName;
        private System.Windows.Forms.TextBox borrowDate;
        private System.Windows.Forms.TextBox dueDate;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private System.Windows.Forms.Label borrowLabel;
        private RJButton borrowedBtn;
        private System.Windows.Forms.DataGridView borrowDG;
        private Guna.UI2.WinForms.Guna2GradientButton calendarBtn;
        private System.Windows.Forms.DateTimePicker borrowedDatepicker;
        private RJButton borrowBtn;
        private System.Windows.Forms.FlowLayoutPanel upperlabelPanel;
        private System.Windows.Forms.Timer upperlabelTransition;
        private Guna.UI2.WinForms.Guna2GradientCircleButton timeBtn;
        private Guna.UI2.WinForms.Guna2GradientCircleButton guna2GradientCircleButton2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox profilePic;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label bnameInfo;
        private System.Windows.Forms.Label bID;
        private System.Windows.Forms.Label category;
    }
}