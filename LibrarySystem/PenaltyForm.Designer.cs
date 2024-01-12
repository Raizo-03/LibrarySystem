namespace LibrarySystem
{
    partial class PenaltyForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PenaltyForm));
            this.label1 = new System.Windows.Forms.Label();
            this.borrowerLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.amountDueLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.amountpaidTb = new System.Windows.Forms.TextBox();
            this.changeLabel = new System.Windows.Forms.Label();
            this.cLabel = new System.Windows.Forms.Label();
            this.balanceLabel = new System.Windows.Forms.Label();
            this.balanceL = new System.Windows.Forms.Label();
            this.bLabel = new System.Windows.Forms.Label();
            this.penaltyLabel = new System.Windows.Forms.Label();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.penaltyDG = new System.Windows.Forms.DataGridView();
            this.penaltyBtn = new LibrarySystem.RJButton();
            this.payBtn = new LibrarySystem.RJButton();
            this.upperlabelPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.upperlabelTransition = new System.Windows.Forms.Timer(this.components);
            this.timeBtn = new Guna.UI2.WinForms.Guna2GradientCircleButton();
            this.guna2GradientCircleButton2 = new Guna.UI2.WinForms.Guna2GradientCircleButton();
            this.label4 = new System.Windows.Forms.Label();
            this.profilePic = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.category = new System.Windows.Forms.Label();
            this.bID = new System.Windows.Forms.Label();
            this.bnameInfo = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.penaltyDG)).BeginInit();
            this.upperlabelPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(363, 551);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Borrower\'s Name:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // borrowerLabel
            // 
            this.borrowerLabel.AutoSize = true;
            this.borrowerLabel.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrowerLabel.Location = new System.Drawing.Point(525, 551);
            this.borrowerLabel.Name = "borrowerLabel";
            this.borrowerLabel.Size = new System.Drawing.Size(0, 20);
            this.borrowerLabel.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(363, 593);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Amount Due:";
            // 
            // amountDueLabel
            // 
            this.amountDueLabel.AutoSize = true;
            this.amountDueLabel.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountDueLabel.Location = new System.Drawing.Point(525, 593);
            this.amountDueLabel.Name = "amountDueLabel";
            this.amountDueLabel.Size = new System.Drawing.Size(0, 20);
            this.amountDueLabel.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(363, 641);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Amount Paid:";
            // 
            // amountpaidTb
            // 
            this.amountpaidTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.amountpaidTb.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountpaidTb.Location = new System.Drawing.Point(525, 641);
            this.amountpaidTb.Name = "amountpaidTb";
            this.amountpaidTb.Size = new System.Drawing.Size(180, 19);
            this.amountpaidTb.TabIndex = 5;
            this.amountpaidTb.TextChanged += new System.EventHandler(this.amountpaidTb_TextChanged);
            // 
            // changeLabel
            // 
            this.changeLabel.AutoSize = true;
            this.changeLabel.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeLabel.Location = new System.Drawing.Point(363, 727);
            this.changeLabel.Name = "changeLabel";
            this.changeLabel.Size = new System.Drawing.Size(71, 21);
            this.changeLabel.TabIndex = 6;
            this.changeLabel.Text = "Change:";
            // 
            // cLabel
            // 
            this.cLabel.AutoSize = true;
            this.cLabel.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cLabel.Location = new System.Drawing.Point(525, 727);
            this.cLabel.Name = "cLabel";
            this.cLabel.Size = new System.Drawing.Size(19, 20);
            this.cLabel.TabIndex = 7;
            this.cLabel.Text = "0";
            // 
            // balanceLabel
            // 
            this.balanceLabel.AutoSize = true;
            this.balanceLabel.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balanceLabel.Location = new System.Drawing.Point(363, 686);
            this.balanceLabel.Name = "balanceLabel";
            this.balanceLabel.Size = new System.Drawing.Size(71, 21);
            this.balanceLabel.TabIndex = 9;
            this.balanceLabel.Text = "Balance:";
            // 
            // balanceL
            // 
            this.balanceL.Location = new System.Drawing.Point(0, 0);
            this.balanceL.Name = "balanceL";
            this.balanceL.Size = new System.Drawing.Size(100, 23);
            this.balanceL.TabIndex = 0;
            // 
            // bLabel
            // 
            this.bLabel.AutoSize = true;
            this.bLabel.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bLabel.Location = new System.Drawing.Point(525, 686);
            this.bLabel.Name = "bLabel";
            this.bLabel.Size = new System.Drawing.Size(19, 20);
            this.bLabel.TabIndex = 10;
            this.bLabel.Text = "0";
            // 
            // penaltyLabel
            // 
            this.penaltyLabel.AutoSize = true;
            this.penaltyLabel.Font = new System.Drawing.Font("Book Antiqua", 33.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.penaltyLabel.ForeColor = System.Drawing.Color.Sienna;
            this.penaltyLabel.Location = new System.Drawing.Point(3, 0);
            this.penaltyLabel.Name = "penaltyLabel";
            this.penaltyLabel.Size = new System.Drawing.Size(60, 371);
            this.penaltyLabel.TabIndex = 26;
            this.penaltyLabel.Text = "PENALTY";
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.Olive;
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.Khaki;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(39, 90);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(871, 5);
            this.guna2GradientPanel1.TabIndex = 27;
            // 
            // penaltyDG
            // 
            this.penaltyDG.BackgroundColor = System.Drawing.Color.DarkKhaki;
            this.penaltyDG.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.penaltyDG.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.penaltyDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkGoldenrod;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.penaltyDG.DefaultCellStyle = dataGridViewCellStyle2;
            this.penaltyDG.GridColor = System.Drawing.Color.PeachPuff;
            this.penaltyDG.Location = new System.Drawing.Point(39, 123);
            this.penaltyDG.Name = "penaltyDG";
            this.penaltyDG.Size = new System.Drawing.Size(564, 358);
            this.penaltyDG.TabIndex = 28;
            this.penaltyDG.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.penaltyDG_CellContentClick);
            // 
            // penaltyBtn
            // 
            this.penaltyBtn.BackColor = System.Drawing.Color.Olive;
            this.penaltyBtn.BackgroundColor = System.Drawing.Color.Olive;
            this.penaltyBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.penaltyBtn.BorderRadius = 25;
            this.penaltyBtn.BorderSize = 0;
            this.penaltyBtn.FlatAppearance.BorderSize = 0;
            this.penaltyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.penaltyBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.penaltyBtn.ForeColor = System.Drawing.Color.White;
            this.penaltyBtn.Location = new System.Drawing.Point(309, 784);
            this.penaltyBtn.Name = "penaltyBtn";
            this.penaltyBtn.Size = new System.Drawing.Size(223, 55);
            this.penaltyBtn.TabIndex = 29;
            this.penaltyBtn.Text = "PENALTIES";
            this.penaltyBtn.TextColor = System.Drawing.Color.White;
            this.penaltyBtn.UseVisualStyleBackColor = false;
            this.penaltyBtn.Click += new System.EventHandler(this.penaltyBtn_Click);
            // 
            // payBtn
            // 
            this.payBtn.BackColor = System.Drawing.Color.Olive;
            this.payBtn.BackgroundColor = System.Drawing.Color.Olive;
            this.payBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.payBtn.BorderRadius = 25;
            this.payBtn.BorderSize = 0;
            this.payBtn.FlatAppearance.BorderSize = 0;
            this.payBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.payBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payBtn.ForeColor = System.Drawing.Color.White;
            this.payBtn.Location = new System.Drawing.Point(551, 784);
            this.payBtn.Name = "payBtn";
            this.payBtn.Size = new System.Drawing.Size(223, 55);
            this.payBtn.TabIndex = 8;
            this.payBtn.Text = "PAY";
            this.payBtn.TextColor = System.Drawing.Color.White;
            this.payBtn.UseVisualStyleBackColor = false;
            this.payBtn.Click += new System.EventHandler(this.payBtn_Click);
            // 
            // upperlabelPanel
            // 
            this.upperlabelPanel.Controls.Add(this.penaltyLabel);
            this.upperlabelPanel.Location = new System.Drawing.Point(39, 32);
            this.upperlabelPanel.Name = "upperlabelPanel";
            this.upperlabelPanel.Size = new System.Drawing.Size(14, 52);
            this.upperlabelPanel.TabIndex = 30;
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
            this.timeBtn.TabIndex = 37;
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
            this.guna2GradientCircleButton2.TabIndex = 38;
            this.guna2GradientCircleButton2.Click += new System.EventHandler(this.guna2GradientCircleButton2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Book Antiqua", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(46, 498);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(202, 26);
            this.label4.TabIndex = 39;
            this.label4.Text = "BORROWER INFO";
            // 
            // profilePic
            // 
            this.profilePic.Image = ((System.Drawing.Image)(resources.GetObject("profilePic.Image")));
            this.profilePic.ImageRotate = 0F;
            this.profilePic.Location = new System.Drawing.Point(62, 532);
            this.profilePic.Name = "profilePic";
            this.profilePic.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.profilePic.Size = new System.Drawing.Size(166, 159);
            this.profilePic.TabIndex = 40;
            this.profilePic.TabStop = false;
            // 
            // category
            // 
            this.category.AutoSize = true;
            this.category.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.category.Location = new System.Drawing.Point(148, 777);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(18, 20);
            this.category.TabIndex = 61;
            this.category.Text = "n";
            // 
            // bID
            // 
            this.bID.AutoSize = true;
            this.bID.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bID.Location = new System.Drawing.Point(148, 740);
            this.bID.Name = "bID";
            this.bID.Size = new System.Drawing.Size(18, 20);
            this.bID.TabIndex = 60;
            this.bID.Text = "n";
            // 
            // bnameInfo
            // 
            this.bnameInfo.AutoSize = true;
            this.bnameInfo.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnameInfo.Location = new System.Drawing.Point(146, 703);
            this.bnameInfo.Name = "bnameInfo";
            this.bnameInfo.Size = new System.Drawing.Size(18, 20);
            this.bnameInfo.TabIndex = 59;
            this.bnameInfo.Text = "n";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(47, 740);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 21);
            this.label5.TabIndex = 58;
            this.label5.Text = "Student ID:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(47, 777);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 21);
            this.label6.TabIndex = 57;
            this.label6.Text = "Category:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(47, 704);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 21);
            this.label7.TabIndex = 56;
            this.label7.Text = "Name:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Book Antiqua", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(490, 498);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 26);
            this.label8.TabIndex = 62;
            this.label8.Text = "PENALTY";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 495);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 29);
            this.pictureBox1.TabIndex = 64;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(456, 498);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(28, 29);
            this.pictureBox2.TabIndex = 65;
            this.pictureBox2.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(13, 818);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(129, 21);
            this.label9.TabIndex = 66;
            this.label9.Text = "Days of Penalty:";
            // 
            // PenaltyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 880);
            this.ControlBox = false;
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.category);
            this.Controls.Add(this.bID);
            this.Controls.Add(this.bnameInfo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.profilePic);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.guna2GradientCircleButton2);
            this.Controls.Add(this.timeBtn);
            this.Controls.Add(this.upperlabelPanel);
            this.Controls.Add(this.penaltyBtn);
            this.Controls.Add(this.penaltyDG);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Controls.Add(this.bLabel);
            this.Controls.Add(this.balanceLabel);
            this.Controls.Add(this.payBtn);
            this.Controls.Add(this.cLabel);
            this.Controls.Add(this.changeLabel);
            this.Controls.Add(this.amountpaidTb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.amountDueLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.borrowerLabel);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PenaltyForm";
            this.Text = "PenaltyForm";
            this.Load += new System.EventHandler(this.PenaltyForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.penaltyDG)).EndInit();
            this.upperlabelPanel.ResumeLayout(false);
            this.upperlabelPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label borrowerLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label amountDueLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox amountpaidTb;
        private System.Windows.Forms.Label changeLabel;
        private System.Windows.Forms.Label cLabel;
        private RJButton payBtn;
        private System.Windows.Forms.Label balanceLabel;
        private System.Windows.Forms.Label balance;
        private System.Windows.Forms.Label bLabel;
        private System.Windows.Forms.Label balanceL;
        private System.Windows.Forms.Label penaltyLabel;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private System.Windows.Forms.DataGridView penaltyDG;
        private RJButton penaltyBtn;
        private System.Windows.Forms.FlowLayoutPanel upperlabelPanel;
        private System.Windows.Forms.Timer upperlabelTransition;
        private Guna.UI2.WinForms.Guna2GradientCircleButton timeBtn;
        private Guna.UI2.WinForms.Guna2GradientCircleButton guna2GradientCircleButton2;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2CirclePictureBox profilePic;
        private System.Windows.Forms.Label category;
        private System.Windows.Forms.Label bID;
        private System.Windows.Forms.Label bnameInfo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label9;
    }
}