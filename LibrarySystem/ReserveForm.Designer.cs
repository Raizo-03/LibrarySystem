﻿namespace LibrarySystem
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReserveForm));
            this.bnameLabel = new System.Windows.Forms.Label();
            this.btitleLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.reservedateLabel = new System.Windows.Forms.Label();
            this.reserveddateTb = new System.Windows.Forms.TextBox();
            this.reservedatepicker = new System.Windows.Forms.DateTimePicker();
            this.borrowernameTb = new System.Windows.Forms.TextBox();
            this.reservedbooksDG = new System.Windows.Forms.DataGridView();
            this.reserveLabel = new System.Windows.Forms.Label();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.calendarBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.manageTransition = new System.Windows.Forms.Timer(this.components);
            this.manageFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.manageBtn = new LibrarySystem.RJButton();
            this.deleteBtn = new LibrarySystem.RJButton();
            this.reserveBtn = new LibrarySystem.RJButton();
            this.upperlabelPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.upperlabelTransition = new System.Windows.Forms.Timer(this.components);
            this.rjButton1 = new LibrarySystem.RJButton();
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
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.bookImage = new System.Windows.Forms.PictureBox();
            this.bookG = new System.Windows.Forms.Label();
            this.bookA = new System.Windows.Forms.Label();
            this.bookT = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.reservedbooksDG)).BeginInit();
            this.manageFlowPanel.SuspendLayout();
            this.upperlabelPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // bnameLabel
            // 
            this.bnameLabel.AutoSize = true;
            this.bnameLabel.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnameLabel.Location = new System.Drawing.Point(351, 679);
            this.bnameLabel.Name = "bnameLabel";
            this.bnameLabel.Size = new System.Drawing.Size(140, 21);
            this.bnameLabel.TabIndex = 0;
            this.bnameLabel.Text = "Borrower\'s Name:";
            // 
            // btitleLabel
            // 
            this.btitleLabel.AutoSize = true;
            this.btitleLabel.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btitleLabel.Location = new System.Drawing.Point(351, 640);
            this.btitleLabel.Name = "btitleLabel";
            this.btitleLabel.Size = new System.Drawing.Size(91, 21);
            this.btitleLabel.TabIndex = 2;
            this.btitleLabel.Text = "Book Title:";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(507, 640);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(0, 20);
            this.titleLabel.TabIndex = 3;
            // 
            // reservedateLabel
            // 
            this.reservedateLabel.AutoSize = true;
            this.reservedateLabel.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reservedateLabel.Location = new System.Drawing.Point(351, 714);
            this.reservedateLabel.Name = "reservedateLabel";
            this.reservedateLabel.Size = new System.Drawing.Size(120, 21);
            this.reservedateLabel.TabIndex = 4;
            this.reservedateLabel.Text = "Reserved Date:";
            // 
            // reserveddateTb
            // 
            this.reserveddateTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.reserveddateTb.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reserveddateTb.Location = new System.Drawing.Point(511, 716);
            this.reserveddateTb.Name = "reserveddateTb";
            this.reserveddateTb.Size = new System.Drawing.Size(180, 19);
            this.reserveddateTb.TabIndex = 5;
            // 
            // reservedatepicker
            // 
            this.reservedatepicker.Location = new System.Drawing.Point(740, 712);
            this.reservedatepicker.Name = "reservedatepicker";
            this.reservedatepicker.Size = new System.Drawing.Size(19, 20);
            this.reservedatepicker.TabIndex = 6;
            this.reservedatepicker.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // borrowernameTb
            // 
            this.borrowernameTb.BackColor = System.Drawing.Color.White;
            this.borrowernameTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.borrowernameTb.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrowernameTb.Location = new System.Drawing.Point(511, 681);
            this.borrowernameTb.Name = "borrowernameTb";
            this.borrowernameTb.Size = new System.Drawing.Size(180, 19);
            this.borrowernameTb.TabIndex = 7;
            this.borrowernameTb.TextChanged += new System.EventHandler(this.borrowernameTb_TextChanged);
            // 
            // reservedbooksDG
            // 
            this.reservedbooksDG.BackgroundColor = System.Drawing.Color.DarkKhaki;
            this.reservedbooksDG.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.reservedbooksDG.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.reservedbooksDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkGoldenrod;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.reservedbooksDG.DefaultCellStyle = dataGridViewCellStyle1;
            this.reservedbooksDG.GridColor = System.Drawing.Color.PeachPuff;
            this.reservedbooksDG.Location = new System.Drawing.Point(39, 123);
            this.reservedbooksDG.Name = "reservedbooksDG";
            this.reservedbooksDG.Size = new System.Drawing.Size(564, 358);
            this.reservedbooksDG.TabIndex = 11;
            this.reservedbooksDG.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.reservedbooksDG_CellContentClick);
            // 
            // reserveLabel
            // 
            this.reserveLabel.AutoSize = true;
            this.reserveLabel.Font = new System.Drawing.Font("Book Antiqua", 33.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reserveLabel.ForeColor = System.Drawing.Color.Sienna;
            this.reserveLabel.Location = new System.Drawing.Point(3, 0);
            this.reserveLabel.Name = "reserveLabel";
            this.reserveLabel.Size = new System.Drawing.Size(58, 371);
            this.reserveLabel.TabIndex = 29;
            this.reserveLabel.Text = "RESERVE";
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.Olive;
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.Khaki;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(39, 90);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(871, 5);
            this.guna2GradientPanel1.TabIndex = 28;
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
            this.calendarBtn.Location = new System.Drawing.Point(706, 700);
            this.calendarBtn.Name = "calendarBtn";
            this.calendarBtn.Size = new System.Drawing.Size(63, 40);
            this.calendarBtn.TabIndex = 31;
            // 
            // manageTransition
            // 
            this.manageTransition.Tick += new System.EventHandler(this.manageTransition_Tick);
            // 
            // manageFlowPanel
            // 
            this.manageFlowPanel.Controls.Add(this.manageBtn);
            this.manageFlowPanel.Controls.Add(this.deleteBtn);
            this.manageFlowPanel.Location = new System.Drawing.Point(543, 755);
            this.manageFlowPanel.Name = "manageFlowPanel";
            this.manageFlowPanel.Size = new System.Drawing.Size(232, 63);
            this.manageFlowPanel.TabIndex = 32;
            // 
            // manageBtn
            // 
            this.manageBtn.BackColor = System.Drawing.Color.Olive;
            this.manageBtn.BackgroundColor = System.Drawing.Color.Olive;
            this.manageBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.manageBtn.BorderRadius = 25;
            this.manageBtn.BorderSize = 0;
            this.manageBtn.FlatAppearance.BorderSize = 0;
            this.manageBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manageBtn.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageBtn.ForeColor = System.Drawing.Color.White;
            this.manageBtn.Location = new System.Drawing.Point(3, 3);
            this.manageBtn.Name = "manageBtn";
            this.manageBtn.Size = new System.Drawing.Size(223, 55);
            this.manageBtn.TabIndex = 10;
            this.manageBtn.Text = "MANAGE";
            this.manageBtn.TextColor = System.Drawing.Color.White;
            this.manageBtn.UseVisualStyleBackColor = false;
            this.manageBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.Olive;
            this.deleteBtn.BackgroundColor = System.Drawing.Color.Olive;
            this.deleteBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.deleteBtn.BorderRadius = 22;
            this.deleteBtn.BorderSize = 0;
            this.deleteBtn.FlatAppearance.BorderSize = 0;
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.ForeColor = System.Drawing.Color.White;
            this.deleteBtn.Location = new System.Drawing.Point(3, 64);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(223, 43);
            this.deleteBtn.TabIndex = 13;
            this.deleteBtn.Text = "DELETE";
            this.deleteBtn.TextColor = System.Drawing.Color.White;
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // reserveBtn
            // 
            this.reserveBtn.BackColor = System.Drawing.Color.Olive;
            this.reserveBtn.BackgroundColor = System.Drawing.Color.Olive;
            this.reserveBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.reserveBtn.BorderRadius = 25;
            this.reserveBtn.BorderSize = 0;
            this.reserveBtn.FlatAppearance.BorderSize = 0;
            this.reserveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reserveBtn.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reserveBtn.ForeColor = System.Drawing.Color.White;
            this.reserveBtn.Location = new System.Drawing.Point(303, 755);
            this.reserveBtn.Name = "reserveBtn";
            this.reserveBtn.Size = new System.Drawing.Size(223, 55);
            this.reserveBtn.TabIndex = 8;
            this.reserveBtn.Text = "RESERVE";
            this.reserveBtn.TextColor = System.Drawing.Color.White;
            this.reserveBtn.UseVisualStyleBackColor = false;
            this.reserveBtn.Click += new System.EventHandler(this.reserveBtn_Click);
            // 
            // upperlabelPanel
            // 
            this.upperlabelPanel.Controls.Add(this.reserveLabel);
            this.upperlabelPanel.Location = new System.Drawing.Point(39, 35);
            this.upperlabelPanel.Name = "upperlabelPanel";
            this.upperlabelPanel.Size = new System.Drawing.Size(13, 49);
            this.upperlabelPanel.TabIndex = 33;
            // 
            // upperlabelTransition
            // 
            this.upperlabelTransition.Tick += new System.EventHandler(this.upperlabelTransition_Tick);
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.Olive;
            this.rjButton1.BackgroundColor = System.Drawing.Color.Olive;
            this.rjButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton1.BorderRadius = 25;
            this.rjButton1.BorderSize = 0;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton1.ForeColor = System.Drawing.Color.White;
            this.rjButton1.Location = new System.Drawing.Point(303, 813);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(223, 55);
            this.rjButton1.TabIndex = 34;
            this.rjButton1.Text = "RESERVED BOOKS";
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            this.rjButton1.Click += new System.EventHandler(this.rjButton1_Click);
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
            this.timeBtn.TabIndex = 36;
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
            this.guna2GradientCircleButton2.TabIndex = 37;
            this.guna2GradientCircleButton2.Click += new System.EventHandler(this.guna2GradientCircleButton2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 498);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 26);
            this.label1.TabIndex = 38;
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
            this.profilePic.TabIndex = 39;
            this.profilePic.TabStop = false;
            // 
            // category
            // 
            this.category.AutoSize = true;
            this.category.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.category.Location = new System.Drawing.Point(148, 792);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(18, 20);
            this.category.TabIndex = 55;
            this.category.Text = "n";
            // 
            // bID
            // 
            this.bID.AutoSize = true;
            this.bID.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bID.Location = new System.Drawing.Point(148, 755);
            this.bID.Name = "bID";
            this.bID.Size = new System.Drawing.Size(18, 20);
            this.bID.TabIndex = 54;
            this.bID.Text = "n";
            // 
            // bnameInfo
            // 
            this.bnameInfo.AutoSize = true;
            this.bnameInfo.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnameInfo.Location = new System.Drawing.Point(146, 718);
            this.bnameInfo.Name = "bnameInfo";
            this.bnameInfo.Size = new System.Drawing.Size(18, 20);
            this.bnameInfo.TabIndex = 53;
            this.bnameInfo.Text = "n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(47, 755);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 21);
            this.label4.TabIndex = 52;
            this.label4.Text = "Student ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(47, 792);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 21);
            this.label5.TabIndex = 51;
            this.label5.Text = "Category:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(47, 719);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 21);
            this.label6.TabIndex = 50;
            this.label6.Text = "Name:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Book Antiqua", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(836, 506);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 26);
            this.label8.TabIndex = 56;
            this.label8.Text = "BOOK INFO";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Book Antiqua", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(477, 506);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 26);
            this.label7.TabIndex = 57;
            this.label7.Text = "RESERVE";
            // 
            // bookImage
            // 
            this.bookImage.Location = new System.Drawing.Point(852, 540);
            this.bookImage.Name = "bookImage";
            this.bookImage.Size = new System.Drawing.Size(105, 126);
            this.bookImage.TabIndex = 58;
            this.bookImage.TabStop = false;
            // 
            // bookG
            // 
            this.bookG.AutoSize = true;
            this.bookG.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookG.Location = new System.Drawing.Point(800, 748);
            this.bookG.Name = "bookG";
            this.bookG.Size = new System.Drawing.Size(19, 20);
            this.bookG.TabIndex = 61;
            this.bookG.Text = "5";
            // 
            // bookA
            // 
            this.bookA.AutoSize = true;
            this.bookA.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookA.Location = new System.Drawing.Point(800, 712);
            this.bookA.Name = "bookA";
            this.bookA.Size = new System.Drawing.Size(19, 20);
            this.bookA.TabIndex = 60;
            this.bookA.Text = "5";
            // 
            // bookT
            // 
            this.bookT.AutoSize = true;
            this.bookT.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookT.Location = new System.Drawing.Point(801, 683);
            this.bookT.Name = "bookT";
            this.bookT.Size = new System.Drawing.Size(15, 18);
            this.bookT.TabIndex = 59;
            this.bookT.Text = "5";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(802, 503);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(28, 29);
            this.pictureBox3.TabIndex = 62;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 498);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 29);
            this.pictureBox1.TabIndex = 63;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(443, 503);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(28, 29);
            this.pictureBox2.TabIndex = 64;
            this.pictureBox2.TabStop = false;
            // 
            // ReserveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 880);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.bookG);
            this.Controls.Add(this.bookA);
            this.Controls.Add(this.bookT);
            this.Controls.Add(this.bookImage);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
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
            this.Controls.Add(this.rjButton1);
            this.Controls.Add(this.upperlabelPanel);
            this.Controls.Add(this.manageFlowPanel);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Controls.Add(this.reservedbooksDG);
            this.Controls.Add(this.reserveBtn);
            this.Controls.Add(this.borrowernameTb);
            this.Controls.Add(this.reservedatepicker);
            this.Controls.Add(this.reserveddateTb);
            this.Controls.Add(this.reservedateLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.btitleLabel);
            this.Controls.Add(this.bnameLabel);
            this.Controls.Add(this.calendarBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReserveForm";
            this.Load += new System.EventHandler(this.ReserveForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reservedbooksDG)).EndInit();
            this.manageFlowPanel.ResumeLayout(false);
            this.upperlabelPanel.ResumeLayout(false);
            this.upperlabelPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
        private RJButton manageBtn;
        private System.Windows.Forms.DataGridView reservedbooksDG;
        private RJButton deleteBtn;
        private System.Windows.Forms.Label reserveLabel;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2GradientButton calendarBtn;
        private System.Windows.Forms.Timer manageTransition;
        private System.Windows.Forms.FlowLayoutPanel manageFlowPanel;
        private System.Windows.Forms.FlowLayoutPanel upperlabelPanel;
        private System.Windows.Forms.Timer upperlabelTransition;
        private RJButton rjButton1;
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
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox bookImage;
        private System.Windows.Forms.Label bookG;
        private System.Windows.Forms.Label bookA;
        private System.Windows.Forms.Label bookT;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}