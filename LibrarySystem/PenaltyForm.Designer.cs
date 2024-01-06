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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
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
            ((System.ComponentModel.ISupportInitialize)(this.penaltyDG)).BeginInit();
            this.upperlabelPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(310, 521);
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
            this.borrowerLabel.Location = new System.Drawing.Point(472, 521);
            this.borrowerLabel.Name = "borrowerLabel";
            this.borrowerLabel.Size = new System.Drawing.Size(0, 20);
            this.borrowerLabel.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(310, 563);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Amount Due:";
            // 
            // amountDueLabel
            // 
            this.amountDueLabel.AutoSize = true;
            this.amountDueLabel.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountDueLabel.Location = new System.Drawing.Point(472, 563);
            this.amountDueLabel.Name = "amountDueLabel";
            this.amountDueLabel.Size = new System.Drawing.Size(0, 20);
            this.amountDueLabel.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(310, 611);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Amount Paid:";
            // 
            // amountpaidTb
            // 
            this.amountpaidTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.amountpaidTb.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountpaidTb.Location = new System.Drawing.Point(472, 611);
            this.amountpaidTb.Name = "amountpaidTb";
            this.amountpaidTb.Size = new System.Drawing.Size(180, 19);
            this.amountpaidTb.TabIndex = 5;
            this.amountpaidTb.TextChanged += new System.EventHandler(this.amountpaidTb_TextChanged);
            // 
            // changeLabel
            // 
            this.changeLabel.AutoSize = true;
            this.changeLabel.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeLabel.Location = new System.Drawing.Point(310, 697);
            this.changeLabel.Name = "changeLabel";
            this.changeLabel.Size = new System.Drawing.Size(71, 21);
            this.changeLabel.TabIndex = 6;
            this.changeLabel.Text = "Change:";
            // 
            // cLabel
            // 
            this.cLabel.AutoSize = true;
            this.cLabel.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cLabel.Location = new System.Drawing.Point(472, 697);
            this.cLabel.Name = "cLabel";
            this.cLabel.Size = new System.Drawing.Size(19, 20);
            this.cLabel.TabIndex = 7;
            this.cLabel.Text = "0";
            // 
            // balanceLabel
            // 
            this.balanceLabel.AutoSize = true;
            this.balanceLabel.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balanceLabel.Location = new System.Drawing.Point(310, 656);
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
            this.bLabel.Location = new System.Drawing.Point(472, 656);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkGoldenrod;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.penaltyDG.DefaultCellStyle = dataGridViewCellStyle1;
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
            this.penaltyBtn.Location = new System.Drawing.Point(268, 750);
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
            this.payBtn.Location = new System.Drawing.Point(566, 750);
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
            // PenaltyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 880);
            this.ControlBox = false;
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
    }
}