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
            this.payBtn = new LibrarySystem.RJButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(104, 390);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Borrower\'s Name:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // borrowerLabel
            // 
            this.borrowerLabel.AutoSize = true;
            this.borrowerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrowerLabel.Location = new System.Drawing.Point(260, 390);
            this.borrowerLabel.Name = "borrowerLabel";
            this.borrowerLabel.Size = new System.Drawing.Size(57, 20);
            this.borrowerLabel.TabIndex = 1;
            this.borrowerLabel.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(104, 432);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Amount Due:";
            // 
            // amountDueLabel
            // 
            this.amountDueLabel.AutoSize = true;
            this.amountDueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountDueLabel.Location = new System.Drawing.Point(260, 432);
            this.amountDueLabel.Name = "amountDueLabel";
            this.amountDueLabel.Size = new System.Drawing.Size(47, 20);
            this.amountDueLabel.TabIndex = 3;
            this.amountDueLabel.Text = "label";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(104, 480);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Amount Paid:";
            // 
            // amountpaidTb
            // 
            this.amountpaidTb.Location = new System.Drawing.Point(264, 480);
            this.amountpaidTb.Name = "amountpaidTb";
            this.amountpaidTb.Size = new System.Drawing.Size(100, 20);
            this.amountpaidTb.TabIndex = 5;
            this.amountpaidTb.TextChanged += new System.EventHandler(this.amountpaidTb_TextChanged);
            // 
            // changeLabel
            // 
            this.changeLabel.AutoSize = true;
            this.changeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeLabel.Location = new System.Drawing.Point(104, 566);
            this.changeLabel.Name = "changeLabel";
            this.changeLabel.Size = new System.Drawing.Size(76, 20);
            this.changeLabel.TabIndex = 6;
            this.changeLabel.Text = "Change:";
            // 
            // cLabel
            // 
            this.cLabel.AutoSize = true;
            this.cLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cLabel.Location = new System.Drawing.Point(260, 566);
            this.cLabel.Name = "cLabel";
            this.cLabel.Size = new System.Drawing.Size(68, 20);
            this.cLabel.TabIndex = 7;
            this.cLabel.Text = "change";
            // 
            // balanceLabel
            // 
            this.balanceLabel.AutoSize = true;
            this.balanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balanceLabel.Location = new System.Drawing.Point(104, 525);
            this.balanceLabel.Name = "balanceLabel";
            this.balanceLabel.Size = new System.Drawing.Size(79, 20);
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
            this.bLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bLabel.Location = new System.Drawing.Point(260, 525);
            this.bLabel.Name = "bLabel";
            this.bLabel.Size = new System.Drawing.Size(72, 20);
            this.bLabel.TabIndex = 10;
            this.bLabel.Text = "balance";
            // 
            // payBtn
            // 
            this.payBtn.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.payBtn.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.payBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.payBtn.BorderRadius = 0;
            this.payBtn.BorderSize = 0;
            this.payBtn.FlatAppearance.BorderSize = 0;
            this.payBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.payBtn.ForeColor = System.Drawing.Color.White;
            this.payBtn.Location = new System.Drawing.Point(594, 432);
            this.payBtn.Name = "payBtn";
            this.payBtn.Size = new System.Drawing.Size(150, 40);
            this.payBtn.TabIndex = 8;
            this.payBtn.Text = "PAY";
            this.payBtn.TextColor = System.Drawing.Color.White;
            this.payBtn.UseVisualStyleBackColor = false;
            this.payBtn.Click += new System.EventHandler(this.payBtn_Click);
            // 
            // PenaltyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 880);
            this.ControlBox = false;
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
    }
}