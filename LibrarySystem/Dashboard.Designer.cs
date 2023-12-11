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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.upperPanel = new System.Windows.Forms.Panel();
            this.dashboardControlbx = new ReaLTaiizor.Controls.NightControlBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dashboardFlowPnl = new System.Windows.Forms.FlowLayoutPanel();
            this.aboutBtn2 = new System.Windows.Forms.Panel();
            this.aboutBtn = new System.Windows.Forms.Button();
            this.dashboardbackPnl = new System.Windows.Forms.FlowLayoutPanel();
            this.dashboardTransition = new System.Windows.Forms.Timer(this.components);
            this.reserveBtn2 = new System.Windows.Forms.Panel();
            this.reserveBtn = new System.Windows.Forms.Button();
            this.returnBtn2 = new System.Windows.Forms.Panel();
            this.returnBtn = new System.Windows.Forms.Button();
            this.borrowBtn2 = new System.Windows.Forms.Panel();
            this.borrowBtn = new System.Windows.Forms.Button();
            this.booklistBtn2 = new System.Windows.Forms.Panel();
            this.booklistBtn = new System.Windows.Forms.Button();
            this.dashboardBtn2 = new System.Windows.Forms.Panel();
            this.dashboardBtn = new System.Windows.Forms.Button();
            this.burgerTransition = new System.Windows.Forms.Timer(this.components);
            this.upperPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.dashboardFlowPnl.SuspendLayout();
            this.aboutBtn2.SuspendLayout();
            this.dashboardbackPnl.SuspendLayout();
            this.reserveBtn2.SuspendLayout();
            this.returnBtn2.SuspendLayout();
            this.borrowBtn2.SuspendLayout();
            this.booklistBtn2.SuspendLayout();
            this.dashboardBtn2.SuspendLayout();
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
            this.dashboardFlowPnl.Controls.Add(this.dashboardbackPnl);
            this.dashboardFlowPnl.Controls.Add(this.aboutBtn2);
            this.dashboardFlowPnl.Dock = System.Windows.Forms.DockStyle.Left;
            this.dashboardFlowPnl.Location = new System.Drawing.Point(0, 113);
            this.dashboardFlowPnl.Name = "dashboardFlowPnl";
            this.dashboardFlowPnl.Size = new System.Drawing.Size(274, 487);
            this.dashboardFlowPnl.TabIndex = 2;
            // 
            // aboutBtn2
            // 
            this.aboutBtn2.Controls.Add(this.aboutBtn);
            this.aboutBtn2.Location = new System.Drawing.Point(3, 68);
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
            // dashboardbackPnl
            // 
            this.dashboardbackPnl.Controls.Add(this.dashboardBtn2);
            this.dashboardbackPnl.Controls.Add(this.booklistBtn2);
            this.dashboardbackPnl.Controls.Add(this.borrowBtn2);
            this.dashboardbackPnl.Controls.Add(this.returnBtn2);
            this.dashboardbackPnl.Controls.Add(this.reserveBtn2);
            this.dashboardbackPnl.Location = new System.Drawing.Point(0, 0);
            this.dashboardbackPnl.Margin = new System.Windows.Forms.Padding(0);
            this.dashboardbackPnl.Name = "dashboardbackPnl";
            this.dashboardbackPnl.Size = new System.Drawing.Size(275, 65);
            this.dashboardbackPnl.TabIndex = 7;
            // 
            // dashboardTransition
            // 
            this.dashboardTransition.Tick += new System.EventHandler(this.dashboardTransition_Tick_1);
            // 
            // reserveBtn2
            // 
            this.reserveBtn2.Controls.Add(this.reserveBtn);
            this.reserveBtn2.Location = new System.Drawing.Point(3, 291);
            this.reserveBtn2.Name = "reserveBtn2";
            this.reserveBtn2.Size = new System.Drawing.Size(275, 66);
            this.reserveBtn2.TabIndex = 5;
            // 
            // reserveBtn
            // 
            this.reserveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reserveBtn.Image = ((System.Drawing.Image)(resources.GetObject("reserveBtn.Image")));
            this.reserveBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reserveBtn.Location = new System.Drawing.Point(-8, -21);
            this.reserveBtn.Name = "reserveBtn";
            this.reserveBtn.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.reserveBtn.Size = new System.Drawing.Size(294, 95);
            this.reserveBtn.TabIndex = 3;
            this.reserveBtn.Text = "      Reserve";
            this.reserveBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reserveBtn.UseVisualStyleBackColor = true;
            this.reserveBtn.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // returnBtn2
            // 
            this.returnBtn2.Controls.Add(this.returnBtn);
            this.returnBtn2.Location = new System.Drawing.Point(3, 219);
            this.returnBtn2.Name = "returnBtn2";
            this.returnBtn2.Size = new System.Drawing.Size(275, 66);
            this.returnBtn2.TabIndex = 6;
            // 
            // returnBtn
            // 
            this.returnBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnBtn.Image = ((System.Drawing.Image)(resources.GetObject("returnBtn.Image")));
            this.returnBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.returnBtn.Location = new System.Drawing.Point(-8, -16);
            this.returnBtn.Name = "returnBtn";
            this.returnBtn.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.returnBtn.Size = new System.Drawing.Size(294, 95);
            this.returnBtn.TabIndex = 3;
            this.returnBtn.Text = "      Return";
            this.returnBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.returnBtn.UseVisualStyleBackColor = true;
            this.returnBtn.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // borrowBtn2
            // 
            this.borrowBtn2.Controls.Add(this.borrowBtn);
            this.borrowBtn2.Location = new System.Drawing.Point(3, 147);
            this.borrowBtn2.Name = "borrowBtn2";
            this.borrowBtn2.Size = new System.Drawing.Size(275, 66);
            this.borrowBtn2.TabIndex = 6;
            // 
            // borrowBtn
            // 
            this.borrowBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrowBtn.Image = ((System.Drawing.Image)(resources.GetObject("borrowBtn.Image")));
            this.borrowBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.borrowBtn.Location = new System.Drawing.Point(-8, -14);
            this.borrowBtn.Name = "borrowBtn";
            this.borrowBtn.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.borrowBtn.Size = new System.Drawing.Size(294, 95);
            this.borrowBtn.TabIndex = 3;
            this.borrowBtn.Text = "      Borrow";
            this.borrowBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.borrowBtn.UseVisualStyleBackColor = true;
            // 
            // booklistBtn2
            // 
            this.booklistBtn2.Controls.Add(this.booklistBtn);
            this.booklistBtn2.Location = new System.Drawing.Point(3, 75);
            this.booklistBtn2.Name = "booklistBtn2";
            this.booklistBtn2.Size = new System.Drawing.Size(275, 66);
            this.booklistBtn2.TabIndex = 6;
            // 
            // booklistBtn
            // 
            this.booklistBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.booklistBtn.Image = ((System.Drawing.Image)(resources.GetObject("booklistBtn.Image")));
            this.booklistBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.booklistBtn.Location = new System.Drawing.Point(-8, -12);
            this.booklistBtn.Name = "booklistBtn";
            this.booklistBtn.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.booklistBtn.Size = new System.Drawing.Size(294, 95);
            this.booklistBtn.TabIndex = 3;
            this.booklistBtn.Text = "      Book List";
            this.booklistBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.booklistBtn.UseVisualStyleBackColor = true;
            // 
            // dashboardBtn2
            // 
            this.dashboardBtn2.Controls.Add(this.dashboardBtn);
            this.dashboardBtn2.Location = new System.Drawing.Point(3, 3);
            this.dashboardBtn2.Name = "dashboardBtn2";
            this.dashboardBtn2.Size = new System.Drawing.Size(275, 66);
            this.dashboardBtn2.TabIndex = 6;
            // 
            // dashboardBtn
            // 
            this.dashboardBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboardBtn.Image = ((System.Drawing.Image)(resources.GetObject("dashboardBtn.Image")));
            this.dashboardBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboardBtn.Location = new System.Drawing.Point(-8, -15);
            this.dashboardBtn.Name = "dashboardBtn";
            this.dashboardBtn.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.dashboardBtn.Size = new System.Drawing.Size(294, 95);
            this.dashboardBtn.TabIndex = 3;
            this.dashboardBtn.Text = "      Dashboard";
            this.dashboardBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboardBtn.UseVisualStyleBackColor = true;
            this.dashboardBtn.Click += new System.EventHandler(this.dashboardBtn_Click);
            // 
            // burgerTransition
            // 
            this.burgerTransition.Interval = 10;
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
            this.dashboardFlowPnl.ResumeLayout(false);
            this.aboutBtn2.ResumeLayout(false);
            this.dashboardbackPnl.ResumeLayout(false);
            this.reserveBtn2.ResumeLayout(false);
            this.returnBtn2.ResumeLayout(false);
            this.borrowBtn2.ResumeLayout(false);
            this.booklistBtn2.ResumeLayout(false);
            this.dashboardBtn2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel upperPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ReaLTaiizor.Controls.NightControlBox dashboardControlbx;
        private System.Windows.Forms.FlowLayoutPanel dashboardFlowPnl;
        private System.Windows.Forms.Panel aboutBtn2;
        private System.Windows.Forms.Button aboutBtn;
        private System.Windows.Forms.FlowLayoutPanel dashboardbackPnl;
        private System.Windows.Forms.Timer dashboardTransition;
        private System.Windows.Forms.Panel reserveBtn2;
        private System.Windows.Forms.Button reserveBtn;
        private System.Windows.Forms.Panel returnBtn2;
        private System.Windows.Forms.Button returnBtn;
        private System.Windows.Forms.Panel dashboardBtn2;
        private System.Windows.Forms.Button dashboardBtn;
        private System.Windows.Forms.Panel booklistBtn2;
        private System.Windows.Forms.Button booklistBtn;
        private System.Windows.Forms.Panel borrowBtn2;
        private System.Windows.Forms.Button borrowBtn;
        private System.Windows.Forms.Timer burgerTransition;
    }
}