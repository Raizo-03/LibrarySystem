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
            this.departmentLabel = new System.Windows.Forms.Label();
            this.userIDLabel = new System.Windows.Forms.Label();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.dashboardControlbx = new ReaLTaiizor.Controls.NightControlBox();
            this.dashboardburgerIcon = new System.Windows.Forms.PictureBox();
            this.dashboardFlowPnl = new System.Windows.Forms.FlowLayoutPanel();
            this.dashboardbackPnl = new System.Windows.Forms.FlowLayoutPanel();
            this.dashboardBtn2 = new System.Windows.Forms.Panel();
            this.dashboardBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.booklistBtn2 = new System.Windows.Forms.Panel();
            this.booklistBtn = new System.Windows.Forms.Button();
            this.borrowBtn2 = new System.Windows.Forms.Panel();
            this.borrowBtn = new System.Windows.Forms.Button();
            this.returnBtn2 = new System.Windows.Forms.Panel();
            this.returnBtn = new System.Windows.Forms.Button();
            this.reserveBtn2 = new System.Windows.Forms.Panel();
            this.reserveBtn = new System.Windows.Forms.Button();
            this.borrowerlistBtn2 = new System.Windows.Forms.Panel();
            this.borrowerlistBtn = new System.Windows.Forms.Button();
            this.aboutBtn2 = new System.Windows.Forms.Panel();
            this.aboutBtn = new System.Windows.Forms.Button();
            this.logoutBtn2 = new System.Windows.Forms.Panel();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.dashboardTransition = new System.Windows.Forms.Timer(this.components);
            this.burgerTransition = new System.Windows.Forms.Timer(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.upperPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardburgerIcon)).BeginInit();
            this.dashboardFlowPnl.SuspendLayout();
            this.dashboardbackPnl.SuspendLayout();
            this.dashboardBtn2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.booklistBtn2.SuspendLayout();
            this.borrowBtn2.SuspendLayout();
            this.returnBtn2.SuspendLayout();
            this.reserveBtn2.SuspendLayout();
            this.borrowerlistBtn2.SuspendLayout();
            this.aboutBtn2.SuspendLayout();
            this.logoutBtn2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // upperPanel
            // 
            this.upperPanel.Controls.Add(this.departmentLabel);
            this.upperPanel.Controls.Add(this.userIDLabel);
            this.upperPanel.Controls.Add(this.userNameLabel);
            this.upperPanel.Controls.Add(this.dashboardControlbx);
            this.upperPanel.Controls.Add(this.dashboardburgerIcon);
            this.upperPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.upperPanel.Location = new System.Drawing.Point(0, 0);
            this.upperPanel.Name = "upperPanel";
            this.upperPanel.Size = new System.Drawing.Size(1067, 74);
            this.upperPanel.TabIndex = 1;
            this.upperPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // departmentLabel
            // 
            this.departmentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departmentLabel.Location = new System.Drawing.Point(862, 46);
            this.departmentLabel.Name = "departmentLabel";
            this.departmentLabel.Size = new System.Drawing.Size(125, 25);
            this.departmentLabel.TabIndex = 4;
            this.departmentLabel.Text = "department";
            // 
            // userIDLabel
            // 
            this.userIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userIDLabel.Location = new System.Drawing.Point(731, 47);
            this.userIDLabel.Name = "userIDLabel";
            this.userIDLabel.Size = new System.Drawing.Size(125, 25);
            this.userIDLabel.TabIndex = 3;
            this.userIDLabel.Text = "id";
            // 
            // userNameLabel
            // 
            this.userNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLabel.Location = new System.Drawing.Point(731, 22);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(195, 25);
            this.userNameLabel.TabIndex = 2;
            this.userNameLabel.Text = "name";
            // 
            // dashboardControlbx
            // 
            this.dashboardControlbx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dashboardControlbx.BackColor = System.Drawing.Color.Transparent;
            this.dashboardControlbx.CloseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
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
            this.dashboardControlbx.Visible = false;
            this.dashboardControlbx.Click += new System.EventHandler(this.nightControlBox1_Click_1);
            // 
            // dashboardburgerIcon
            // 
            this.dashboardburgerIcon.Image = ((System.Drawing.Image)(resources.GetObject("dashboardburgerIcon.Image")));
            this.dashboardburgerIcon.Location = new System.Drawing.Point(12, 22);
            this.dashboardburgerIcon.Name = "dashboardburgerIcon";
            this.dashboardburgerIcon.Size = new System.Drawing.Size(48, 45);
            this.dashboardburgerIcon.TabIndex = 0;
            this.dashboardburgerIcon.TabStop = false;
            this.dashboardburgerIcon.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // dashboardFlowPnl
            // 
            this.dashboardFlowPnl.Controls.Add(this.dashboardbackPnl);
            this.dashboardFlowPnl.Controls.Add(this.aboutBtn2);
            this.dashboardFlowPnl.Controls.Add(this.logoutBtn2);
            this.dashboardFlowPnl.Dock = System.Windows.Forms.DockStyle.Left;
            this.dashboardFlowPnl.Location = new System.Drawing.Point(0, 74);
            this.dashboardFlowPnl.Name = "dashboardFlowPnl";
            this.dashboardFlowPnl.Size = new System.Drawing.Size(71, 644);
            this.dashboardFlowPnl.TabIndex = 2;
            // 
            // dashboardbackPnl
            // 
            this.dashboardbackPnl.Controls.Add(this.dashboardBtn2);
            this.dashboardbackPnl.Controls.Add(this.booklistBtn2);
            this.dashboardbackPnl.Controls.Add(this.borrowBtn2);
            this.dashboardbackPnl.Controls.Add(this.returnBtn2);
            this.dashboardbackPnl.Controls.Add(this.reserveBtn2);
            this.dashboardbackPnl.Controls.Add(this.borrowerlistBtn2);
            this.dashboardbackPnl.Location = new System.Drawing.Point(0, 0);
            this.dashboardbackPnl.Margin = new System.Windows.Forms.Padding(0);
            this.dashboardbackPnl.Name = "dashboardbackPnl";
            this.dashboardbackPnl.Size = new System.Drawing.Size(275, 73);
            this.dashboardbackPnl.TabIndex = 7;
            this.dashboardbackPnl.Paint += new System.Windows.Forms.PaintEventHandler(this.dashboardbackPnl_Paint);
            // 
            // dashboardBtn2
            // 
            this.dashboardBtn2.Controls.Add(this.dashboardBtn);
            this.dashboardBtn2.Controls.Add(this.pictureBox1);
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
            this.dashboardBtn.Location = new System.Drawing.Point(-8, -14);
            this.dashboardBtn.Name = "dashboardBtn";
            this.dashboardBtn.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.dashboardBtn.Size = new System.Drawing.Size(294, 94);
            this.dashboardBtn.TabIndex = 3;
            this.dashboardBtn.Text = "      Dashboard";
            this.dashboardBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboardBtn.UseVisualStyleBackColor = true;
            this.dashboardBtn.Click += new System.EventHandler(this.dashboardBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(74, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(987, 526);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
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
            this.booklistBtn.Margin = new System.Windows.Forms.Padding(0);
            this.booklistBtn.Name = "booklistBtn";
            this.booklistBtn.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.booklistBtn.Size = new System.Drawing.Size(294, 95);
            this.booklistBtn.TabIndex = 3;
            this.booklistBtn.Text = "      Book List";
            this.booklistBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.booklistBtn.UseVisualStyleBackColor = true;
            this.booklistBtn.Click += new System.EventHandler(this.booklistBtn_Click_1);
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
            this.borrowBtn.Click += new System.EventHandler(this.borrowBtn_Click);
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
            // borrowerlistBtn2
            // 
            this.borrowerlistBtn2.Controls.Add(this.borrowerlistBtn);
            this.borrowerlistBtn2.Location = new System.Drawing.Point(3, 363);
            this.borrowerlistBtn2.Name = "borrowerlistBtn2";
            this.borrowerlistBtn2.Size = new System.Drawing.Size(275, 66);
            this.borrowerlistBtn2.TabIndex = 6;
            // 
            // borrowerlistBtn
            // 
            this.borrowerlistBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrowerlistBtn.Image = ((System.Drawing.Image)(resources.GetObject("borrowerlistBtn.Image")));
            this.borrowerlistBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.borrowerlistBtn.Location = new System.Drawing.Point(-8, -21);
            this.borrowerlistBtn.Name = "borrowerlistBtn";
            this.borrowerlistBtn.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.borrowerlistBtn.Size = new System.Drawing.Size(294, 95);
            this.borrowerlistBtn.TabIndex = 3;
            this.borrowerlistBtn.Text = "      Borrower List";
            this.borrowerlistBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.borrowerlistBtn.UseVisualStyleBackColor = true;
            this.borrowerlistBtn.Click += new System.EventHandler(this.borrowerlistBtn_Click);
            // 
            // aboutBtn2
            // 
            this.aboutBtn2.Controls.Add(this.aboutBtn);
            this.aboutBtn2.Location = new System.Drawing.Point(3, 76);
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
            this.aboutBtn.Click += new System.EventHandler(this.aboutBtn_Click_1);
            // 
            // logoutBtn2
            // 
            this.logoutBtn2.Controls.Add(this.logoutBtn);
            this.logoutBtn2.Location = new System.Drawing.Point(3, 148);
            this.logoutBtn2.Name = "logoutBtn2";
            this.logoutBtn2.Size = new System.Drawing.Size(275, 66);
            this.logoutBtn2.TabIndex = 6;
            // 
            // logoutBtn
            // 
            this.logoutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutBtn.Image = ((System.Drawing.Image)(resources.GetObject("logoutBtn.Image")));
            this.logoutBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logoutBtn.Location = new System.Drawing.Point(-8, -11);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.logoutBtn.Size = new System.Drawing.Size(294, 95);
            this.logoutBtn.TabIndex = 3;
            this.logoutBtn.Text = "      Logout";
            this.logoutBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logoutBtn.UseVisualStyleBackColor = true;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // dashboardTransition
            // 
            this.dashboardTransition.Tick += new System.EventHandler(this.dashboardTransition_Tick_1);
            // 
            // burgerTransition
            // 
            this.burgerTransition.Interval = 10;
            this.burgerTransition.Tick += new System.EventHandler(this.burgerTransition_Tick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(1066, 150);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 718);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.dashboardFlowPnl);
            this.Controls.Add(this.upperPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashboardForm";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.upperPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dashboardburgerIcon)).EndInit();
            this.dashboardFlowPnl.ResumeLayout(false);
            this.dashboardbackPnl.ResumeLayout(false);
            this.dashboardBtn2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.booklistBtn2.ResumeLayout(false);
            this.borrowBtn2.ResumeLayout(false);
            this.returnBtn2.ResumeLayout(false);
            this.reserveBtn2.ResumeLayout(false);
            this.borrowerlistBtn2.ResumeLayout(false);
            this.aboutBtn2.ResumeLayout(false);
            this.logoutBtn2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel upperPanel;
        private System.Windows.Forms.PictureBox dashboardburgerIcon;
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel borrowerlistBtn2;
        private System.Windows.Forms.Button borrowerlistBtn;
        private System.Windows.Forms.Panel logoutBtn2;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Label departmentLabel;
        private System.Windows.Forms.Label userIDLabel;
    }
}