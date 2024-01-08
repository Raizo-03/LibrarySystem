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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReturnForm));
            this.borrowerName = new System.Windows.Forms.Label();
            this.bName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.returndateTb = new System.Windows.Forms.TextBox();
            this.returndatePicker = new System.Windows.Forms.DateTimePicker();
            this.dueDateLabel = new System.Windows.Forms.Label();
            this.bkTitleLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.returnLabel = new System.Windows.Forms.Label();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.borrowDG = new System.Windows.Forms.DataGridView();
            this.calendarBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.borrowedBtn = new LibrarySystem.RJButton();
            this.returnBtn = new LibrarySystem.RJButton();
            this.upperlabelPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.upperlabelTransition = new System.Windows.Forms.Timer(this.components);
            this.timeBtn = new Guna.UI2.WinForms.Guna2GradientCircleButton();
            this.guna2GradientCircleButton2 = new Guna.UI2.WinForms.Guna2GradientCircleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.profilePic = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.category = new System.Windows.Forms.Label();
            this.bID = new System.Windows.Forms.Label();
            this.bnameInfo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.borrowDG)).BeginInit();
            this.upperlabelPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePic)).BeginInit();
            this.SuspendLayout();
            // 
            // borrowerName
            // 
            this.borrowerName.AutoSize = true;
            this.borrowerName.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrowerName.Location = new System.Drawing.Point(419, 596);
            this.borrowerName.Name = "borrowerName";
            this.borrowerName.Size = new System.Drawing.Size(140, 21);
            this.borrowerName.TabIndex = 0;
            this.borrowerName.Text = "Borrower\'s Name:";
            // 
            // bName
            // 
            this.bName.AutoSize = true;
            this.bName.Font = new System.Drawing.Font("Bookman Old Style", 12F);
            this.bName.Location = new System.Drawing.Point(597, 596);
            this.bName.Name = "bName";
            this.bName.Size = new System.Drawing.Size(0, 20);
            this.bName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(419, 629);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Due Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(419, 666);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Return Date:";
            // 
            // returndateTb
            // 
            this.returndateTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.returndateTb.Font = new System.Drawing.Font("Bookman Old Style", 12F);
            this.returndateTb.Location = new System.Drawing.Point(601, 663);
            this.returndateTb.Name = "returndateTb";
            this.returndateTb.Size = new System.Drawing.Size(180, 19);
            this.returndateTb.TabIndex = 4;
            // 
            // returndatePicker
            // 
            this.returndatePicker.Location = new System.Drawing.Point(828, 663);
            this.returndatePicker.Name = "returndatePicker";
            this.returndatePicker.Size = new System.Drawing.Size(19, 20);
            this.returndatePicker.TabIndex = 5;
            this.returndatePicker.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dueDateLabel
            // 
            this.dueDateLabel.AutoSize = true;
            this.dueDateLabel.Font = new System.Drawing.Font("Bookman Old Style", 12F);
            this.dueDateLabel.Location = new System.Drawing.Point(597, 635);
            this.dueDateLabel.Name = "dueDateLabel";
            this.dueDateLabel.Size = new System.Drawing.Size(0, 20);
            this.dueDateLabel.TabIndex = 6;
            // 
            // bkTitleLabel
            // 
            this.bkTitleLabel.AutoSize = true;
            this.bkTitleLabel.Font = new System.Drawing.Font("Book Antiqua", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bkTitleLabel.Location = new System.Drawing.Point(419, 563);
            this.bkTitleLabel.Name = "bkTitleLabel";
            this.bkTitleLabel.Size = new System.Drawing.Size(95, 22);
            this.bkTitleLabel.TabIndex = 7;
            this.bkTitleLabel.Text = "Book Title:";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(597, 563);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(0, 20);
            this.titleLabel.TabIndex = 8;
            // 
            // returnLabel
            // 
            this.returnLabel.AutoSize = true;
            this.returnLabel.Font = new System.Drawing.Font("Book Antiqua", 33.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnLabel.ForeColor = System.Drawing.Color.Sienna;
            this.returnLabel.Location = new System.Drawing.Point(3, 0);
            this.returnLabel.Name = "returnLabel";
            this.returnLabel.Size = new System.Drawing.Size(60, 318);
            this.returnLabel.TabIndex = 27;
            this.returnLabel.Text = "RETURN";
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.Olive;
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.Khaki;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(39, 90);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(871, 5);
            this.guna2GradientPanel1.TabIndex = 26;
            // 
            // borrowDG
            // 
            this.borrowDG.BackgroundColor = System.Drawing.Color.DarkKhaki;
            this.borrowDG.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.borrowDG.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.borrowDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkGoldenrod;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.borrowDG.DefaultCellStyle = dataGridViewCellStyle3;
            this.borrowDG.GridColor = System.Drawing.Color.PeachPuff;
            this.borrowDG.Location = new System.Drawing.Point(39, 123);
            this.borrowDG.Name = "borrowDG";
            this.borrowDG.Size = new System.Drawing.Size(564, 358);
            this.borrowDG.TabIndex = 28;
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
            this.calendarBtn.Location = new System.Drawing.Point(795, 652);
            this.calendarBtn.Name = "calendarBtn";
            this.calendarBtn.Size = new System.Drawing.Size(63, 40);
            this.calendarBtn.TabIndex = 30;
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
            this.borrowedBtn.Location = new System.Drawing.Point(375, 715);
            this.borrowedBtn.Name = "borrowedBtn";
            this.borrowedBtn.Size = new System.Drawing.Size(223, 55);
            this.borrowedBtn.TabIndex = 29;
            this.borrowedBtn.Text = "BORROWED BOOKS";
            this.borrowedBtn.TextColor = System.Drawing.Color.White;
            this.borrowedBtn.UseVisualStyleBackColor = false;
            this.borrowedBtn.Click += new System.EventHandler(this.borrowedBtn_Click);
            // 
            // returnBtn
            // 
            this.returnBtn.BackColor = System.Drawing.Color.Olive;
            this.returnBtn.BackgroundColor = System.Drawing.Color.Olive;
            this.returnBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.returnBtn.BorderRadius = 25;
            this.returnBtn.BorderSize = 0;
            this.returnBtn.FlatAppearance.BorderSize = 0;
            this.returnBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.returnBtn.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnBtn.ForeColor = System.Drawing.Color.White;
            this.returnBtn.Location = new System.Drawing.Point(673, 715);
            this.returnBtn.Name = "returnBtn";
            this.returnBtn.Size = new System.Drawing.Size(223, 55);
            this.returnBtn.TabIndex = 9;
            this.returnBtn.Text = "RETURN";
            this.returnBtn.TextColor = System.Drawing.Color.White;
            this.returnBtn.UseVisualStyleBackColor = false;
            this.returnBtn.Click += new System.EventHandler(this.returnBtn_Click);
            // 
            // upperlabelPanel
            // 
            this.upperlabelPanel.Controls.Add(this.returnLabel);
            this.upperlabelPanel.Location = new System.Drawing.Point(39, 35);
            this.upperlabelPanel.Name = "upperlabelPanel";
            this.upperlabelPanel.Size = new System.Drawing.Size(14, 49);
            this.upperlabelPanel.TabIndex = 31;
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
            this.timeBtn.TabIndex = 35;
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
            this.guna2GradientCircleButton2.Location = new System.Drawing.Point(875, 50);
            this.guna2GradientCircleButton2.Name = "guna2GradientCircleButton2";
            this.guna2GradientCircleButton2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2GradientCircleButton2.Size = new System.Drawing.Size(35, 32);
            this.guna2GradientCircleButton2.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 498);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 26);
            this.label1.TabIndex = 37;
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
            this.profilePic.TabIndex = 38;
            this.profilePic.TabStop = false;
            // 
            // category
            // 
            this.category.AutoSize = true;
            this.category.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.category.Location = new System.Drawing.Point(148, 788);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(18, 20);
            this.category.TabIndex = 49;
            this.category.Text = "n";
            // 
            // bID
            // 
            this.bID.AutoSize = true;
            this.bID.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bID.Location = new System.Drawing.Point(148, 751);
            this.bID.Name = "bID";
            this.bID.Size = new System.Drawing.Size(18, 20);
            this.bID.TabIndex = 48;
            this.bID.Text = "n";
            // 
            // bnameInfo
            // 
            this.bnameInfo.AutoSize = true;
            this.bnameInfo.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnameInfo.Location = new System.Drawing.Point(146, 714);
            this.bnameInfo.Name = "bnameInfo";
            this.bnameInfo.Size = new System.Drawing.Size(18, 20);
            this.bnameInfo.TabIndex = 47;
            this.bnameInfo.Text = "n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(47, 751);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 21);
            this.label4.TabIndex = 46;
            this.label4.Text = "Student ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(47, 788);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 21);
            this.label5.TabIndex = 45;
            this.label5.Text = "Category:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(47, 715);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 21);
            this.label6.TabIndex = 44;
            this.label6.Text = "Name:";
            // 
            // ReturnForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 880);
            this.ControlBox = false;
            this.Controls.Add(this.category);
            this.Controls.Add(this.bID);
            this.Controls.Add(this.bnameInfo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.profilePic);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2GradientCircleButton2);
            this.Controls.Add(this.timeBtn);
            this.Controls.Add(this.upperlabelPanel);
            this.Controls.Add(this.borrowedBtn);
            this.Controls.Add(this.borrowDG);
            this.Controls.Add(this.guna2GradientPanel1);
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
            this.Controls.Add(this.calendarBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReturnForm";
            this.Load += new System.EventHandler(this.ReturnForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.borrowDG)).EndInit();
            this.upperlabelPanel.ResumeLayout(false);
            this.upperlabelPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePic)).EndInit();
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
        private System.Windows.Forms.Label returnLabel;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private System.Windows.Forms.DataGridView borrowDG;
        private RJButton borrowedBtn;
        private Guna.UI2.WinForms.Guna2GradientButton calendarBtn;
        private System.Windows.Forms.FlowLayoutPanel upperlabelPanel;
        private System.Windows.Forms.Timer upperlabelTransition;
        private Guna.UI2.WinForms.Guna2GradientCircleButton timeBtn;
        private Guna.UI2.WinForms.Guna2GradientCircleButton guna2GradientCircleButton2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox profilePic;
        private System.Windows.Forms.Label category;
        private System.Windows.Forms.Label bID;
        private System.Windows.Forms.Label bnameInfo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}