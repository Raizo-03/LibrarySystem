namespace LibrarySystem
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.upperPanel = new System.Windows.Forms.Panel();
            this.dashboardControlbx = new ReaLTaiizor.Controls.NightControlBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dashboardFlowPnl = new System.Windows.Forms.FlowLayoutPanel();
            this.dashboardBtn2 = new System.Windows.Forms.Button();
            this.dashboardBtn = new System.Windows.Forms.Panel();
            this.mainmenuFlowpnl = new System.Windows.Forms.FlowLayoutPanel();
            this.aboutBtn2 = new System.Windows.Forms.Panel();
            this.aboutBtn = new System.Windows.Forms.Button();
            this.exitBtn2 = new System.Windows.Forms.Panel();
            this.exitBtn = new System.Windows.Forms.Button();
            this.upperPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.dashboardBtn.SuspendLayout();
            this.aboutBtn2.SuspendLayout();
            this.exitBtn2.SuspendLayout();
            this.SuspendLayout();
            // 
            // upperPanel
            // 
            this.upperPanel.Controls.Add(this.dashboardControlbx);
            this.upperPanel.Controls.Add(this.pictureBox1);
            this.upperPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.upperPanel.Location = new System.Drawing.Point(0, 0);
            this.upperPanel.Name = "upperPanel";
            this.upperPanel.Size = new System.Drawing.Size(1067, 113);
            this.upperPanel.TabIndex = 1;
            this.upperPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // dashboardControlbx
            // 
            this.dashboardControlbx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dashboardControlbx.BackColor = System.Drawing.Color.Transparent;
            this.dashboardControlbx.CloseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.dashboardControlbx.CloseHoverForeColor = System.Drawing.Color.Black;
            this.dashboardControlbx.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dashboardControlbx.DefaultLocation = true;
            this.dashboardControlbx.DisableMaximizeColor = System.Drawing.Color.Black;
            this.dashboardControlbx.DisableMinimizeColor = System.Drawing.Color.Black;
            this.dashboardControlbx.EnableCloseColor = System.Drawing.Color.Black;
            this.dashboardControlbx.EnableMaximizeButton = true;
            this.dashboardControlbx.EnableMaximizeColor = System.Drawing.Color.Black;
            this.dashboardControlbx.EnableMinimizeButton = true;
            this.dashboardControlbx.EnableMinimizeColor = System.Drawing.Color.Black;
            this.dashboardControlbx.Location = new System.Drawing.Point(928, 0);
            this.dashboardControlbx.MaximizeHoverColor = System.Drawing.Color.Olive;
            this.dashboardControlbx.MaximizeHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.dashboardControlbx.MinimizeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.dashboardControlbx.MinimizeHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.dashboardControlbx.Name = "dashboardControlbx";
            this.dashboardControlbx.Size = new System.Drawing.Size(139, 31);
            this.dashboardControlbx.TabIndex = 1;
            this.dashboardControlbx.Click += new System.EventHandler(this.nightControlBox1_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 45);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dashboardFlowPnl
            // 
            this.dashboardFlowPnl.Dock = System.Windows.Forms.DockStyle.Left;
            this.dashboardFlowPnl.Location = new System.Drawing.Point(0, 113);
            this.dashboardFlowPnl.Name = "dashboardFlowPnl";
            this.dashboardFlowPnl.Size = new System.Drawing.Size(263, 487);
            this.dashboardFlowPnl.TabIndex = 2;
            // 
            // dashboardBtn2
            // 
            this.dashboardBtn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboardBtn2.Image = ((System.Drawing.Image)(resources.GetObject("dashboardBtn2.Image")));
            this.dashboardBtn2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboardBtn2.Location = new System.Drawing.Point(-8, -11);
            this.dashboardBtn2.Name = "dashboardBtn2";
            this.dashboardBtn2.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.dashboardBtn2.Size = new System.Drawing.Size(294, 95);
            this.dashboardBtn2.TabIndex = 3;
            this.dashboardBtn2.Text = "      Dashboard";
            this.dashboardBtn2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboardBtn2.UseVisualStyleBackColor = true;
            this.dashboardBtn2.Click += new System.EventHandler(this.button1_Click);
            // 
            // dashboardBtn
            // 
            this.dashboardBtn.Controls.Add(this.dashboardBtn2);
            this.dashboardBtn.Location = new System.Drawing.Point(422, 298);
            this.dashboardBtn.Name = "dashboardBtn";
            this.dashboardBtn.Size = new System.Drawing.Size(275, 66);
            this.dashboardBtn.TabIndex = 4;
            // 
            // mainmenuFlowpnl
            // 
            this.mainmenuFlowpnl.Location = new System.Drawing.Point(437, 172);
            this.mainmenuFlowpnl.Name = "mainmenuFlowpnl";
            this.mainmenuFlowpnl.Size = new System.Drawing.Size(260, 109);
            this.mainmenuFlowpnl.TabIndex = 6;
            // 
            // aboutBtn2
            // 
            this.aboutBtn2.Controls.Add(this.aboutBtn);
            this.aboutBtn2.Location = new System.Drawing.Point(422, 388);
            this.aboutBtn2.Name = "aboutBtn2";
            this.aboutBtn2.Size = new System.Drawing.Size(275, 66);
            this.aboutBtn2.TabIndex = 5;
            // 
            // aboutBtn
            // 
            this.aboutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutBtn.Image = ((System.Drawing.Image)(resources.GetObject("aboutBtn.Image")));
            this.aboutBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.aboutBtn.Location = new System.Drawing.Point(-8, -11);
            this.aboutBtn.Name = "aboutBtn";
            this.aboutBtn.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.aboutBtn.Size = new System.Drawing.Size(294, 95);
            this.aboutBtn.TabIndex = 3;
            this.aboutBtn.Text = "      About";
            this.aboutBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.aboutBtn.UseVisualStyleBackColor = true;
            // 
            // exitBtn2
            // 
            this.exitBtn2.Controls.Add(this.exitBtn);
            this.exitBtn2.Location = new System.Drawing.Point(422, 478);
            this.exitBtn2.Name = "exitBtn2";
            this.exitBtn2.Size = new System.Drawing.Size(275, 66);
            this.exitBtn2.TabIndex = 6;
            // 
            // exitBtn
            // 
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.Image = ((System.Drawing.Image)(resources.GetObject("exitBtn.Image")));
            this.exitBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exitBtn.Location = new System.Drawing.Point(-8, -11);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.exitBtn.Size = new System.Drawing.Size(294, 95);
            this.exitBtn.TabIndex = 3;
            this.exitBtn.Text = "      Exit";
            this.exitBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exitBtn.UseVisualStyleBackColor = true;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 600);
            this.ControlBox = false;
            this.Controls.Add(this.exitBtn2);
            this.Controls.Add(this.aboutBtn2);
            this.Controls.Add(this.mainmenuFlowpnl);
            this.Controls.Add(this.dashboardBtn);
            this.Controls.Add(this.dashboardFlowPnl);
            this.Controls.Add(this.upperPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashboardForm";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.upperPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.dashboardBtn.ResumeLayout(false);
            this.aboutBtn2.ResumeLayout(false);
            this.exitBtn2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel upperPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ReaLTaiizor.Controls.NightControlBox dashboardControlbx;
        private System.Windows.Forms.FlowLayoutPanel dashboardFlowPnl;
        private System.Windows.Forms.Button dashboardBtn2;
        private System.Windows.Forms.Panel dashboardBtn;
        private System.Windows.Forms.FlowLayoutPanel mainmenuFlowpnl;
        private System.Windows.Forms.Panel aboutBtn2;
        private System.Windows.Forms.Button aboutBtn;
        private System.Windows.Forms.Panel exitBtn2;
        private System.Windows.Forms.Button exitBtn;
    }
}