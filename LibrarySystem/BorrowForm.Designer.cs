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
            this.fictiongroupBx = new System.Windows.Forms.GroupBox();
            this.solitudecheckBx = new System.Windows.Forms.CheckBox();
            this.gatsbycheckBx = new System.Windows.Forms.CheckBox();
            this.pridecheckBx = new System.Windows.Forms.CheckBox();
            this.checkBx1984 = new System.Windows.Forms.CheckBox();
            this.mockingchechBx = new System.Windows.Forms.CheckBox();
            this.nonficgroupBx = new System.Windows.Forms.GroupBox();
            this.thinkingcheckBx = new System.Windows.Forms.CheckBox();
            this.diarycheckBx = new System.Windows.Forms.CheckBox();
            this.educatedcheckBx = new System.Windows.Forms.CheckBox();
            this.immortalcheckBx = new System.Windows.Forms.CheckBox();
            this.sapienscheckBx = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.borrowerLabel = new System.Windows.Forms.Label();
            this.databorrowedLabel = new System.Windows.Forms.Label();
            this.duedateLabel = new System.Windows.Forms.Label();
            this.borrower = new System.Windows.Forms.Label();
            this.borrowdate = new System.Windows.Forms.Label();
            this.duedate = new System.Windows.Forms.Label();
            this.borrowBtn = new LibrarySystem.RJButton();
            this.fictiongroupBx.SuspendLayout();
            this.nonficgroupBx.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fictiongroupBx
            // 
            this.fictiongroupBx.Controls.Add(this.solitudecheckBx);
            this.fictiongroupBx.Controls.Add(this.gatsbycheckBx);
            this.fictiongroupBx.Controls.Add(this.pridecheckBx);
            this.fictiongroupBx.Controls.Add(this.checkBx1984);
            this.fictiongroupBx.Controls.Add(this.mockingchechBx);
            this.fictiongroupBx.Location = new System.Drawing.Point(37, 178);
            this.fictiongroupBx.Name = "fictiongroupBx";
            this.fictiongroupBx.Size = new System.Drawing.Size(251, 235);
            this.fictiongroupBx.TabIndex = 0;
            this.fictiongroupBx.TabStop = false;
            this.fictiongroupBx.Text = "FICTION";
            this.fictiongroupBx.Enter += new System.EventHandler(this.fictiongroupBx_Enter);
            // 
            // solitudecheckBx
            // 
            this.solitudecheckBx.AutoSize = true;
            this.solitudecheckBx.Location = new System.Drawing.Point(19, 187);
            this.solitudecheckBx.Name = "solitudecheckBx";
            this.solitudecheckBx.Size = new System.Drawing.Size(173, 17);
            this.solitudecheckBx.TabIndex = 4;
            this.solitudecheckBx.Text = "One Hundred Years of Solitude";
            this.solitudecheckBx.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.solitudecheckBx.UseVisualStyleBackColor = true;
            // 
            // gatsbycheckBx
            // 
            this.gatsbycheckBx.AutoSize = true;
            this.gatsbycheckBx.Location = new System.Drawing.Point(19, 151);
            this.gatsbycheckBx.Name = "gatsbycheckBx";
            this.gatsbycheckBx.Size = new System.Drawing.Size(110, 17);
            this.gatsbycheckBx.TabIndex = 3;
            this.gatsbycheckBx.Text = "The Great Gatsby";
            this.gatsbycheckBx.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.gatsbycheckBx.UseVisualStyleBackColor = true;
            // 
            // pridecheckBx
            // 
            this.pridecheckBx.AutoSize = true;
            this.pridecheckBx.Location = new System.Drawing.Point(19, 115);
            this.pridecheckBx.Name = "pridecheckBx";
            this.pridecheckBx.Size = new System.Drawing.Size(118, 17);
            this.pridecheckBx.TabIndex = 2;
            this.pridecheckBx.Text = "Pride and Prejudice";
            this.pridecheckBx.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pridecheckBx.UseVisualStyleBackColor = true;
            // 
            // checkBx1984
            // 
            this.checkBx1984.AutoSize = true;
            this.checkBx1984.Location = new System.Drawing.Point(19, 78);
            this.checkBx1984.Name = "checkBx1984";
            this.checkBx1984.Size = new System.Drawing.Size(50, 17);
            this.checkBx1984.TabIndex = 1;
            this.checkBx1984.Text = "1984";
            this.checkBx1984.UseVisualStyleBackColor = true;
            // 
            // mockingchechBx
            // 
            this.mockingchechBx.AutoSize = true;
            this.mockingchechBx.Location = new System.Drawing.Point(19, 40);
            this.mockingchechBx.Name = "mockingchechBx";
            this.mockingchechBx.Size = new System.Drawing.Size(126, 17);
            this.mockingchechBx.TabIndex = 0;
            this.mockingchechBx.Text = "To Kill A Mockingbird";
            this.mockingchechBx.UseVisualStyleBackColor = true;
            // 
            // nonficgroupBx
            // 
            this.nonficgroupBx.Controls.Add(this.thinkingcheckBx);
            this.nonficgroupBx.Controls.Add(this.diarycheckBx);
            this.nonficgroupBx.Controls.Add(this.educatedcheckBx);
            this.nonficgroupBx.Controls.Add(this.immortalcheckBx);
            this.nonficgroupBx.Controls.Add(this.sapienscheckBx);
            this.nonficgroupBx.Location = new System.Drawing.Point(336, 178);
            this.nonficgroupBx.Name = "nonficgroupBx";
            this.nonficgroupBx.Size = new System.Drawing.Size(251, 235);
            this.nonficgroupBx.TabIndex = 5;
            this.nonficgroupBx.TabStop = false;
            this.nonficgroupBx.Text = "NON-FICTION";
            this.nonficgroupBx.Enter += new System.EventHandler(this.nonficgroupBx_Enter);
            // 
            // thinkingcheckBx
            // 
            this.thinkingcheckBx.AutoSize = true;
            this.thinkingcheckBx.Location = new System.Drawing.Point(19, 187);
            this.thinkingcheckBx.Name = "thinkingcheckBx";
            this.thinkingcheckBx.Size = new System.Drawing.Size(140, 17);
            this.thinkingcheckBx.TabIndex = 4;
            this.thinkingcheckBx.Text = "Thinking, Fast and Slow";
            this.thinkingcheckBx.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.thinkingcheckBx.UseVisualStyleBackColor = true;
            // 
            // diarycheckBx
            // 
            this.diarycheckBx.AutoSize = true;
            this.diarycheckBx.Location = new System.Drawing.Point(19, 151);
            this.diarycheckBx.Name = "diarycheckBx";
            this.diarycheckBx.Size = new System.Drawing.Size(145, 17);
            this.diarycheckBx.TabIndex = 3;
            this.diarycheckBx.Text = "The Diary of a Young Girl";
            this.diarycheckBx.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.diarycheckBx.UseVisualStyleBackColor = true;
            // 
            // educatedcheckBx
            // 
            this.educatedcheckBx.AutoSize = true;
            this.educatedcheckBx.Location = new System.Drawing.Point(19, 115);
            this.educatedcheckBx.Name = "educatedcheckBx";
            this.educatedcheckBx.Size = new System.Drawing.Size(72, 17);
            this.educatedcheckBx.TabIndex = 2;
            this.educatedcheckBx.Text = "Educated";
            this.educatedcheckBx.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.educatedcheckBx.UseVisualStyleBackColor = true;
            // 
            // immortalcheckBx
            // 
            this.immortalcheckBx.AutoSize = true;
            this.immortalcheckBx.Location = new System.Drawing.Point(19, 78);
            this.immortalcheckBx.Name = "immortalcheckBx";
            this.immortalcheckBx.Size = new System.Drawing.Size(197, 17);
            this.immortalcheckBx.TabIndex = 1;
            this.immortalcheckBx.Text = "The Immortal Life of Henrietta Lacks";
            this.immortalcheckBx.UseVisualStyleBackColor = true;
            // 
            // sapienscheckBx
            // 
            this.sapienscheckBx.AutoSize = true;
            this.sapienscheckBx.Location = new System.Drawing.Point(19, 40);
            this.sapienscheckBx.Name = "sapienscheckBx";
            this.sapienscheckBx.Size = new System.Drawing.Size(205, 17);
            this.sapienscheckBx.TabIndex = 0;
            this.sapienscheckBx.Text = "Sapiens: A Brief History of Humankind";
            this.sapienscheckBx.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(218, 438);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(499, 161);
            this.panel1.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(0, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(496, 32);
            this.label5.TabIndex = 4;
            this.label5.Text = "label5";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(1, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(496, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "label4";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(0, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(496, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "label3";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(0, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(496, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(496, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(336, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "label6";
            // 
            // borrowerLabel
            // 
            this.borrowerLabel.AutoSize = true;
            this.borrowerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrowerLabel.Location = new System.Drawing.Point(56, 632);
            this.borrowerLabel.Name = "borrowerLabel";
            this.borrowerLabel.Size = new System.Drawing.Size(134, 16);
            this.borrowerLabel.TabIndex = 9;
            this.borrowerLabel.Text = "Borrower\'s Name: ";
            // 
            // databorrowedLabel
            // 
            this.databorrowedLabel.AutoSize = true;
            this.databorrowedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.databorrowedLabel.Location = new System.Drawing.Point(56, 672);
            this.databorrowedLabel.Name = "databorrowedLabel";
            this.databorrowedLabel.Size = new System.Drawing.Size(114, 16);
            this.databorrowedLabel.TabIndex = 10;
            this.databorrowedLabel.Text = "Date Borrowed:";
            // 
            // duedateLabel
            // 
            this.duedateLabel.AutoSize = true;
            this.duedateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.duedateLabel.Location = new System.Drawing.Point(56, 708);
            this.duedateLabel.Name = "duedateLabel";
            this.duedateLabel.Size = new System.Drawing.Size(76, 16);
            this.duedateLabel.TabIndex = 11;
            this.duedateLabel.Text = "Due Date:";
            // 
            // borrower
            // 
            this.borrower.AutoSize = true;
            this.borrower.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrower.Location = new System.Drawing.Point(196, 632);
            this.borrower.Name = "borrower";
            this.borrower.Size = new System.Drawing.Size(49, 18);
            this.borrower.TabIndex = 12;
            this.borrower.Text = "name";
            // 
            // borrowdate
            // 
            this.borrowdate.AutoSize = true;
            this.borrowdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrowdate.Location = new System.Drawing.Point(196, 672);
            this.borrowdate.Name = "borrowdate";
            this.borrowdate.Size = new System.Drawing.Size(40, 18);
            this.borrowdate.TabIndex = 13;
            this.borrowdate.Text = "date";
            this.borrowdate.Click += new System.EventHandler(this.label7_Click);
            // 
            // duedate
            // 
            this.duedate.AutoSize = true;
            this.duedate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.duedate.Location = new System.Drawing.Point(196, 708);
            this.duedate.Name = "duedate";
            this.duedate.Size = new System.Drawing.Size(67, 18);
            this.duedate.TabIndex = 14;
            this.duedate.Text = "duedate";
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
            this.borrowBtn.Location = new System.Drawing.Point(382, 762);
            this.borrowBtn.Name = "borrowBtn";
            this.borrowBtn.Size = new System.Drawing.Size(150, 40);
            this.borrowBtn.TabIndex = 15;
            this.borrowBtn.Text = "BORROW";
            this.borrowBtn.TextColor = System.Drawing.Color.White;
            this.borrowBtn.UseVisualStyleBackColor = false;
            // 
            // BorrowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 880);
            this.ControlBox = false;
            this.Controls.Add(this.borrowBtn);
            this.Controls.Add(this.duedate);
            this.Controls.Add(this.borrowdate);
            this.Controls.Add(this.borrower);
            this.Controls.Add(this.duedateLabel);
            this.Controls.Add(this.databorrowedLabel);
            this.Controls.Add(this.borrowerLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.nonficgroupBx);
            this.Controls.Add(this.fictiongroupBx);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BorrowForm";
            this.Load += new System.EventHandler(this.BorrowForm_Load);
            this.fictiongroupBx.ResumeLayout(false);
            this.fictiongroupBx.PerformLayout();
            this.nonficgroupBx.ResumeLayout(false);
            this.nonficgroupBx.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox fictiongroupBx;
        private System.Windows.Forms.CheckBox mockingchechBx;
        private System.Windows.Forms.CheckBox checkBx1984;
        private System.Windows.Forms.CheckBox pridecheckBx;
        private System.Windows.Forms.CheckBox solitudecheckBx;
        private System.Windows.Forms.CheckBox gatsbycheckBx;
        private System.Windows.Forms.GroupBox nonficgroupBx;
        private System.Windows.Forms.CheckBox thinkingcheckBx;
        private System.Windows.Forms.CheckBox diarycheckBx;
        private System.Windows.Forms.CheckBox educatedcheckBx;
        private System.Windows.Forms.CheckBox immortalcheckBx;
        private System.Windows.Forms.CheckBox sapienscheckBx;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label borrowerLabel;
        private System.Windows.Forms.Label databorrowedLabel;
        private System.Windows.Forms.Label duedateLabel;
        private System.Windows.Forms.Label borrower;
        private System.Windows.Forms.Label borrowdate;
        private System.Windows.Forms.Label duedate;
        private RJButton borrowBtn;
    }
}