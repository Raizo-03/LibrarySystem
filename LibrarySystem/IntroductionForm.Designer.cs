namespace LibrarySystem
{
    partial class FirstForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FirstForm));
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            this.EternalLibPic = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.passwordBx = new Guna.UI2.WinForms.Guna2TextBox();
            this.eyeIcon = new Guna.UI2.WinForms.Guna2GradientButton();
            this.usernameBx = new Guna.UI2.WinForms.Guna2TextBox();
            this.passIcon = new System.Windows.Forms.PictureBox();
            this.userIcon = new System.Windows.Forms.PictureBox();
            this.proceedBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            ((System.ComponentModel.ISupportInitialize)(this.passIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // nightControlBox1
            // 
            this.nightControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nightControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.nightControlBox1.CloseHoverColor = System.Drawing.Color.Red;
            this.nightControlBox1.CloseHoverForeColor = System.Drawing.Color.White;
            this.nightControlBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nightControlBox1.DefaultLocation = true;
            this.nightControlBox1.DisableMaximizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.nightControlBox1.DisableMinimizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.nightControlBox1.EnableCloseColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.nightControlBox1.EnableMaximizeButton = false;
            this.nightControlBox1.EnableMaximizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.nightControlBox1.EnableMinimizeButton = false;
            this.nightControlBox1.EnableMinimizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.nightControlBox1.Location = new System.Drawing.Point(269, 0);
            this.nightControlBox1.MaximizeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.nightControlBox1.MaximizeHoverForeColor = System.Drawing.Color.White;
            this.nightControlBox1.MinimizeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.nightControlBox1.MinimizeHoverForeColor = System.Drawing.Color.White;
            this.nightControlBox1.Name = "nightControlBox1";
            this.nightControlBox1.Size = new System.Drawing.Size(139, 31);
            this.nightControlBox1.TabIndex = 0;
            this.nightControlBox1.Click += new System.EventHandler(this.nightControlBox1_Click);
            // 
            // EternalLibPic
            // 
            this.EternalLibPic.Image = ((System.Drawing.Image)(resources.GetObject("EternalLibPic.Image")));
            this.EternalLibPic.Location = new System.Drawing.Point(88, 73);
            this.EternalLibPic.Name = "EternalLibPic";
            this.EternalLibPic.Size = new System.Drawing.Size(225, 210);
            this.EternalLibPic.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(225, 421);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(104, 421);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(38, 14);
            this.lblMessage.TabIndex = 7;
            this.lblMessage.Text = "label2";
            // 
            // passwordBx
            // 
            this.passwordBx.BorderColor = System.Drawing.Color.Olive;
            this.passwordBx.BorderRadius = 14;
            this.passwordBx.BorderThickness = 2;
            this.passwordBx.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordBx.DefaultText = "";
            this.passwordBx.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.passwordBx.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.passwordBx.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordBx.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordBx.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passwordBx.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordBx.ForeColor = System.Drawing.Color.Black;
            this.passwordBx.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passwordBx.Location = new System.Drawing.Point(107, 375);
            this.passwordBx.Name = "passwordBx";
            this.passwordBx.PasswordChar = '\0';
            this.passwordBx.PlaceholderText = "Password";
            this.passwordBx.SelectedText = "";
            this.passwordBx.Size = new System.Drawing.Size(206, 33);
            this.passwordBx.TabIndex = 12;
            this.passwordBx.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // eyeIcon
            // 
            this.eyeIcon.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.eyeIcon.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.eyeIcon.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.eyeIcon.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.eyeIcon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.eyeIcon.FillColor = System.Drawing.Color.White;
            this.eyeIcon.FillColor2 = System.Drawing.Color.White;
            this.eyeIcon.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.eyeIcon.ForeColor = System.Drawing.Color.White;
            this.eyeIcon.Image = ((System.Drawing.Image)(resources.GetObject("eyeIcon.Image")));
            this.eyeIcon.Location = new System.Drawing.Point(278, 381);
            this.eyeIcon.Name = "eyeIcon";
            this.eyeIcon.Size = new System.Drawing.Size(28, 20);
            this.eyeIcon.TabIndex = 13;
            this.eyeIcon.Click += new System.EventHandler(this.eyeIcon_Click);
            // 
            // usernameBx
            // 
            this.usernameBx.BorderColor = System.Drawing.Color.Olive;
            this.usernameBx.BorderRadius = 14;
            this.usernameBx.BorderThickness = 2;
            this.usernameBx.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.usernameBx.DefaultText = "";
            this.usernameBx.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.usernameBx.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.usernameBx.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.usernameBx.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.usernameBx.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.usernameBx.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameBx.ForeColor = System.Drawing.Color.Black;
            this.usernameBx.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.usernameBx.Location = new System.Drawing.Point(107, 327);
            this.usernameBx.Margin = new System.Windows.Forms.Padding(4);
            this.usernameBx.Name = "usernameBx";
            this.usernameBx.PasswordChar = '\0';
            this.usernameBx.PlaceholderText = "Username";
            this.usernameBx.SelectedText = "";
            this.usernameBx.Size = new System.Drawing.Size(206, 33);
            this.usernameBx.TabIndex = 14;
            // 
            // passIcon
            // 
            this.passIcon.Image = ((System.Drawing.Image)(resources.GetObject("passIcon.Image")));
            this.passIcon.Location = new System.Drawing.Point(70, 374);
            this.passIcon.Name = "passIcon";
            this.passIcon.Size = new System.Drawing.Size(31, 34);
            this.passIcon.TabIndex = 9;
            this.passIcon.TabStop = false;
            // 
            // userIcon
            // 
            this.userIcon.Image = ((System.Drawing.Image)(resources.GetObject("userIcon.Image")));
            this.userIcon.Location = new System.Drawing.Point(73, 327);
            this.userIcon.Name = "userIcon";
            this.userIcon.Size = new System.Drawing.Size(30, 31);
            this.userIcon.TabIndex = 8;
            this.userIcon.TabStop = false;
            // 
            // proceedBtn
            // 
            this.proceedBtn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.proceedBtn.BorderColor = System.Drawing.Color.Olive;
            this.proceedBtn.BorderRadius = 29;
            this.proceedBtn.BorderThickness = 1;
            this.proceedBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.proceedBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.proceedBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.proceedBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.proceedBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.proceedBtn.FillColor = System.Drawing.Color.DarkGoldenrod;
            this.proceedBtn.FillColor2 = System.Drawing.Color.Olive;
            this.proceedBtn.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proceedBtn.ForeColor = System.Drawing.Color.White;
            this.proceedBtn.Location = new System.Drawing.Point(89, 441);
            this.proceedBtn.Name = "proceedBtn";
            this.proceedBtn.Size = new System.Drawing.Size(224, 59);
            this.proceedBtn.TabIndex = 15;
            this.proceedBtn.Text = "LOGIN";
            this.proceedBtn.Click += new System.EventHandler(this.proceedBtn_Click);
            // 
            // FirstForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 576);
            this.ControlBox = false;
            this.Controls.Add(this.proceedBtn);
            this.Controls.Add(this.usernameBx);
            this.Controls.Add(this.eyeIcon);
            this.Controls.Add(this.passwordBx);
            this.Controls.Add(this.passIcon);
            this.Controls.Add(this.userIcon);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EternalLibPic);
            this.Controls.Add(this.nightControlBox1);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FirstForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FirstForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.passIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private System.Windows.Forms.Label EternalLibPic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMessage;
        private Guna.UI2.WinForms.Guna2TextBox passwordBx;
        private Guna.UI2.WinForms.Guna2GradientButton eyeIcon;
        private Guna.UI2.WinForms.Guna2TextBox usernameBx;
        private System.Windows.Forms.PictureBox passIcon;
        private System.Windows.Forms.PictureBox userIcon;
        private Guna.UI2.WinForms.Guna2GradientButton proceedBtn;
    }
}

