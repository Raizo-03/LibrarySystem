namespace LibrarySystem
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
            ((System.ComponentModel.ISupportInitialize)(this.reservedbooksDG)).BeginInit();
            this.manageFlowPanel.SuspendLayout();
            this.upperlabelPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // bnameLabel
            // 
            this.bnameLabel.AutoSize = true;
            this.bnameLabel.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnameLabel.Location = new System.Drawing.Point(368, 622);
            this.bnameLabel.Name = "bnameLabel";
            this.bnameLabel.Size = new System.Drawing.Size(140, 21);
            this.bnameLabel.TabIndex = 0;
            this.bnameLabel.Text = "Borrower\'s Name:";
            // 
            // btitleLabel
            // 
            this.btitleLabel.AutoSize = true;
            this.btitleLabel.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btitleLabel.Location = new System.Drawing.Point(368, 583);
            this.btitleLabel.Name = "btitleLabel";
            this.btitleLabel.Size = new System.Drawing.Size(91, 21);
            this.btitleLabel.TabIndex = 2;
            this.btitleLabel.Text = "Book Title:";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(524, 583);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(0, 20);
            this.titleLabel.TabIndex = 3;
            // 
            // reservedateLabel
            // 
            this.reservedateLabel.AutoSize = true;
            this.reservedateLabel.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reservedateLabel.Location = new System.Drawing.Point(368, 657);
            this.reservedateLabel.Name = "reservedateLabel";
            this.reservedateLabel.Size = new System.Drawing.Size(120, 21);
            this.reservedateLabel.TabIndex = 4;
            this.reservedateLabel.Text = "Reserved Date:";
            // 
            // reserveddateTb
            // 
            this.reserveddateTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.reserveddateTb.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reserveddateTb.Location = new System.Drawing.Point(528, 659);
            this.reserveddateTb.Name = "reserveddateTb";
            this.reserveddateTb.Size = new System.Drawing.Size(180, 19);
            this.reserveddateTb.TabIndex = 5;
            // 
            // reservedatepicker
            // 
            this.reservedatepicker.Location = new System.Drawing.Point(773, 655);
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
            this.borrowernameTb.Location = new System.Drawing.Point(528, 624);
            this.borrowernameTb.Name = "borrowernameTb";
            this.borrowernameTb.Size = new System.Drawing.Size(180, 19);
            this.borrowernameTb.TabIndex = 7;
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
            this.calendarBtn.Location = new System.Drawing.Point(740, 645);
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
            this.manageFlowPanel.Location = new System.Drawing.Point(694, 708);
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
            this.reserveBtn.Location = new System.Drawing.Point(465, 711);
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
            this.rjButton1.Location = new System.Drawing.Point(236, 708);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(223, 55);
            this.rjButton1.TabIndex = 34;
            this.rjButton1.Text = "RESERVED BOOKS";
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            this.rjButton1.Click += new System.EventHandler(this.rjButton1_Click);
            // 
            // ReserveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 880);
            this.ControlBox = false;
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
    }
}