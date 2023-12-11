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
            this.upperPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // upperPanel
            // 
            this.upperPanel.Controls.Add(this.dashboardControlbx);
            this.upperPanel.Controls.Add(this.pictureBox1);
            this.upperPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.upperPanel.Location = new System.Drawing.Point(0, 0);
            this.upperPanel.Name = "upperPanel";
            this.upperPanel.Size = new System.Drawing.Size(1067, 96);
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
            this.dashboardFlowPnl.Location = new System.Drawing.Point(0, 96);
            this.dashboardFlowPnl.Name = "dashboardFlowPnl";
            this.dashboardFlowPnl.Size = new System.Drawing.Size(263, 504);
            this.dashboardFlowPnl.TabIndex = 2;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 600);
            this.ControlBox = false;
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
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel upperPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ReaLTaiizor.Controls.NightControlBox dashboardControlbx;
        private System.Windows.Forms.FlowLayoutPanel dashboardFlowPnl;
    }
}