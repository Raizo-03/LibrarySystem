namespace LibrarySystem
{
    partial class DashboardForm2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardForm2));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.hellolabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.availableLabel = new System.Windows.Forms.Label();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.reservedB = new Guna.UI2.WinForms.Guna2GradientButton();
            this.penaltiesB = new Guna.UI2.WinForms.Guna2GradientButton();
            this.analyticsDG = new System.Windows.Forms.DataGridView();
            this.availbooksPanel = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.availbooksB = new Guna.UI2.WinForms.Guna2GradientButton();
            this.borrowedB = new Guna.UI2.WinForms.Guna2GradientButton();
            this.borrowedPanel = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.reservedPanel = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.userPanel = new Guna.UI2.WinForms.Guna2GradientPanel();
            ((System.ComponentModel.ISupportInitialize)(this.analyticsDG)).BeginInit();
            this.availbooksPanel.SuspendLayout();
            this.borrowedPanel.SuspendLayout();
            this.reservedPanel.SuspendLayout();
            this.userPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // hellolabel
            // 
            this.hellolabel.AutoSize = true;
            this.hellolabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hellolabel.Location = new System.Drawing.Point(12, 107);
            this.hellolabel.Name = "hellolabel";
            this.hellolabel.Size = new System.Drawing.Size(123, 42);
            this.hellolabel.TabIndex = 1;
            this.hellolabel.Text = "Hello, ";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(141, 107);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(137, 42);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "ADMIN";
            // 
            // availableLabel
            // 
            this.availableLabel.BackColor = System.Drawing.Color.Transparent;
            this.availableLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.availableLabel.ForeColor = System.Drawing.Color.White;
            this.availableLabel.Location = new System.Drawing.Point(168, 83);
            this.availableLabel.Name = "availableLabel";
            this.availableLabel.Size = new System.Drawing.Size(38, 33);
            this.availableLabel.TabIndex = 15;
            this.availableLabel.Text = "10";
            this.availableLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.availableLabel.Click += new System.EventHandler(this.availableLabel_Click);
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.Olive;
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.Khaki;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(19, 171);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(871, 5);
            this.guna2GradientPanel1.TabIndex = 16;
            // 
            // reservedB
            // 
            this.reservedB.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.reservedB.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.reservedB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.reservedB.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.reservedB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.reservedB.FillColor = System.Drawing.Color.Chartreuse;
            this.reservedB.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.reservedB.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reservedB.ForeColor = System.Drawing.Color.White;
            this.reservedB.Image = ((System.Drawing.Image)(resources.GetObject("reservedB.Image")));
            this.reservedB.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.reservedB.ImageSize = new System.Drawing.Size(35, 35);
            this.reservedB.Location = new System.Drawing.Point(6, 14);
            this.reservedB.Name = "reservedB";
            this.reservedB.Size = new System.Drawing.Size(200, 66);
            this.reservedB.TabIndex = 19;
            this.reservedB.Text = "RESERVED";
            this.reservedB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // penaltiesB
            // 
            this.penaltiesB.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.penaltiesB.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.penaltiesB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.penaltiesB.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.penaltiesB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.penaltiesB.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.penaltiesB.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.penaltiesB.ForeColor = System.Drawing.Color.White;
            this.penaltiesB.Image = ((System.Drawing.Image)(resources.GetObject("penaltiesB.Image")));
            this.penaltiesB.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.penaltiesB.ImageSize = new System.Drawing.Size(35, 35);
            this.penaltiesB.Location = new System.Drawing.Point(6, 14);
            this.penaltiesB.Name = "penaltiesB";
            this.penaltiesB.Size = new System.Drawing.Size(200, 66);
            this.penaltiesB.TabIndex = 20;
            this.penaltiesB.Text = "USERS";
            this.penaltiesB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // analyticsDG
            // 
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Transparent;
            this.analyticsDG.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.analyticsDG.BackgroundColor = System.Drawing.Color.PeachPuff;
            this.analyticsDG.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.analyticsDG.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.analyticsDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.analyticsDG.DefaultCellStyle = dataGridViewCellStyle2;
            this.analyticsDG.GridColor = System.Drawing.Color.PeachPuff;
            this.analyticsDG.Location = new System.Drawing.Point(19, 350);
            this.analyticsDG.Name = "analyticsDG";
            this.analyticsDG.Size = new System.Drawing.Size(596, 332);
            this.analyticsDG.TabIndex = 22;
            this.analyticsDG.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // availbooksPanel
            // 
            this.availbooksPanel.Controls.Add(this.availableLabel);
            this.availbooksPanel.Controls.Add(this.availbooksB);
            this.availbooksPanel.FillColor = System.Drawing.Color.DeepSkyBlue;
            this.availbooksPanel.FillColor2 = System.Drawing.Color.DodgerBlue;
            this.availbooksPanel.Location = new System.Drawing.Point(19, 197);
            this.availbooksPanel.Name = "availbooksPanel";
            this.availbooksPanel.Size = new System.Drawing.Size(209, 116);
            this.availbooksPanel.TabIndex = 23;
            // 
            // availbooksB
            // 
            this.availbooksB.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.availbooksB.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.availbooksB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.availbooksB.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.availbooksB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.availbooksB.FillColor = System.Drawing.Color.DeepSkyBlue;
            this.availbooksB.FillColor2 = System.Drawing.Color.DodgerBlue;
            this.availbooksB.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.availbooksB.ForeColor = System.Drawing.Color.White;
            this.availbooksB.Image = ((System.Drawing.Image)(resources.GetObject("availbooksB.Image")));
            this.availbooksB.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.availbooksB.ImageSize = new System.Drawing.Size(35, 35);
            this.availbooksB.Location = new System.Drawing.Point(6, 14);
            this.availbooksB.Name = "availbooksB";
            this.availbooksB.Size = new System.Drawing.Size(200, 66);
            this.availbooksB.TabIndex = 17;
            this.availbooksB.Text = "AVAILABLE BOOKS";
            this.availbooksB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.availbooksB.Click += new System.EventHandler(this.availbooksB_Click);
            // 
            // borrowedB
            // 
            this.borrowedB.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.borrowedB.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.borrowedB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.borrowedB.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.borrowedB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.borrowedB.FillColor = System.Drawing.Color.LightCoral;
            this.borrowedB.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.borrowedB.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrowedB.ForeColor = System.Drawing.Color.White;
            this.borrowedB.Image = ((System.Drawing.Image)(resources.GetObject("borrowedB.Image")));
            this.borrowedB.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.borrowedB.ImageSize = new System.Drawing.Size(35, 35);
            this.borrowedB.Location = new System.Drawing.Point(6, 14);
            this.borrowedB.Name = "borrowedB";
            this.borrowedB.Size = new System.Drawing.Size(200, 66);
            this.borrowedB.TabIndex = 18;
            this.borrowedB.Text = "BORROWED";
            this.borrowedB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // borrowedPanel
            // 
            this.borrowedPanel.Controls.Add(this.borrowedB);
            this.borrowedPanel.FillColor = System.Drawing.Color.LightCoral;
            this.borrowedPanel.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.borrowedPanel.Location = new System.Drawing.Point(234, 197);
            this.borrowedPanel.Name = "borrowedPanel";
            this.borrowedPanel.Size = new System.Drawing.Size(209, 116);
            this.borrowedPanel.TabIndex = 24;
            // 
            // reservedPanel
            // 
            this.reservedPanel.Controls.Add(this.reservedB);
            this.reservedPanel.FillColor = System.Drawing.Color.Chartreuse;
            this.reservedPanel.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.reservedPanel.Location = new System.Drawing.Point(449, 197);
            this.reservedPanel.Name = "reservedPanel";
            this.reservedPanel.Size = new System.Drawing.Size(209, 116);
            this.reservedPanel.TabIndex = 25;
            // 
            // userPanel
            // 
            this.userPanel.Controls.Add(this.penaltiesB);
            this.userPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.userPanel.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(165)))));
            this.userPanel.Location = new System.Drawing.Point(664, 197);
            this.userPanel.Name = "userPanel";
            this.userPanel.Size = new System.Drawing.Size(209, 116);
            this.userPanel.TabIndex = 26;
            // 
            // DashboardForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(1053, 762);
            this.ControlBox = false;
            this.Controls.Add(this.userPanel);
            this.Controls.Add(this.reservedPanel);
            this.Controls.Add(this.borrowedPanel);
            this.Controls.Add(this.availbooksPanel);
            this.Controls.Add(this.analyticsDG);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.hellolabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DashboardForm2";
            this.Load += new System.EventHandler(this.DashboardForm2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.analyticsDG)).EndInit();
            this.availbooksPanel.ResumeLayout(false);
            this.borrowedPanel.ResumeLayout(false);
            this.reservedPanel.ResumeLayout(false);
            this.userPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label hellolabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label availableLabel;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2GradientButton reservedB;
        private Guna.UI2.WinForms.Guna2GradientButton penaltiesB;
        private System.Windows.Forms.DataGridView analyticsDG;
        private Guna.UI2.WinForms.Guna2GradientPanel availbooksPanel;
        private Guna.UI2.WinForms.Guna2GradientButton borrowedB;
        private Guna.UI2.WinForms.Guna2GradientButton availbooksB;
        private Guna.UI2.WinForms.Guna2GradientPanel borrowedPanel;
        private Guna.UI2.WinForms.Guna2GradientPanel reservedPanel;
        private Guna.UI2.WinForms.Guna2GradientPanel userPanel;
    }
}