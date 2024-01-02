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
            this.userIcon = new System.Windows.Forms.PictureBox();
            this.passIcon = new System.Windows.Forms.PictureBox();
            this.passwordBx = new CustomControls.RJControls.RJTextBox();
            this.usernameBx = new CustomControls.RJControls.RJTextBox();
            this.proceedBtn = new LibrarySystem.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.userIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passIcon)).BeginInit();
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
            // userIcon
            // 
            this.userIcon.Image = ((System.Drawing.Image)(resources.GetObject("userIcon.Image")));
            this.userIcon.Location = new System.Drawing.Point(69, 327);
            this.userIcon.Name = "userIcon";
            this.userIcon.Size = new System.Drawing.Size(31, 31);
            this.userIcon.TabIndex = 8;
            this.userIcon.TabStop = false;
            // 
            // passIcon
            // 
            this.passIcon.Image = ((System.Drawing.Image)(resources.GetObject("passIcon.Image")));
            this.passIcon.Location = new System.Drawing.Point(69, 374);
            this.passIcon.Name = "passIcon";
            this.passIcon.Size = new System.Drawing.Size(31, 34);
            this.passIcon.TabIndex = 9;
            this.passIcon.TabStop = false;
            this.passIcon.Click += new System.EventHandler(this.passIcon_Click);
            // 
            // passwordBx
            // 
            this.passwordBx.BackColor = System.Drawing.SystemColors.Window;
            this.passwordBx.BorderColor = System.Drawing.Color.Olive;
            this.passwordBx.BorderFocusColor = System.Drawing.Color.Lime;
            this.passwordBx.BorderRadius = 15;
            this.passwordBx.BorderSize = 2;
            this.passwordBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordBx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.passwordBx.Location = new System.Drawing.Point(107, 377);
            this.passwordBx.Margin = new System.Windows.Forms.Padding(4);
            this.passwordBx.Multiline = false;
            this.passwordBx.Name = "passwordBx";
            this.passwordBx.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.passwordBx.PasswordChar = false;
            this.passwordBx.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.passwordBx.PlaceholderText = "";
            this.passwordBx.Size = new System.Drawing.Size(206, 31);
            this.passwordBx.TabIndex = 11;
            this.passwordBx.Texts = "";
            this.passwordBx.UnderlinedStyle = false;
            this.passwordBx._TextChanged += new System.EventHandler(this.passwordBx__TextChanged);
            // 
            // usernameBx
            // 
            this.usernameBx.BackColor = System.Drawing.SystemColors.Window;
            this.usernameBx.BorderColor = System.Drawing.Color.Olive;
            this.usernameBx.BorderFocusColor = System.Drawing.Color.Lime;
            this.usernameBx.BorderRadius = 15;
            this.usernameBx.BorderSize = 2;
            this.usernameBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameBx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.usernameBx.Location = new System.Drawing.Point(107, 327);
            this.usernameBx.Margin = new System.Windows.Forms.Padding(4);
            this.usernameBx.Multiline = false;
            this.usernameBx.Name = "usernameBx";
            this.usernameBx.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.usernameBx.PasswordChar = false;
            this.usernameBx.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.usernameBx.PlaceholderText = "";
            this.usernameBx.Size = new System.Drawing.Size(206, 31);
            this.usernameBx.TabIndex = 10;
            this.usernameBx.Texts = "";
            this.usernameBx.UnderlinedStyle = false;
            // 
            // proceedBtn
            // 
            this.proceedBtn.BackColor = System.Drawing.Color.White;
            this.proceedBtn.BackgroundColor = System.Drawing.Color.White;
            this.proceedBtn.BorderColor = System.Drawing.Color.Olive;
            this.proceedBtn.BorderRadius = 29;
            this.proceedBtn.BorderSize = 2;
            this.proceedBtn.FlatAppearance.BorderSize = 0;
            this.proceedBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.proceedBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proceedBtn.ForeColor = System.Drawing.Color.Olive;
            this.proceedBtn.Location = new System.Drawing.Point(89, 441);
            this.proceedBtn.Name = "proceedBtn";
            this.proceedBtn.Size = new System.Drawing.Size(224, 59);
            this.proceedBtn.TabIndex = 3;
            this.proceedBtn.Text = "PROCEED";
            this.proceedBtn.TextColor = System.Drawing.Color.Olive;
            this.proceedBtn.UseVisualStyleBackColor = false;
            this.proceedBtn.Click += new System.EventHandler(this.proceedBtn_Click);
            // 
            // FirstForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 576);
            this.ControlBox = false;
            this.Controls.Add(this.passwordBx);
            this.Controls.Add(this.usernameBx);
            this.Controls.Add(this.passIcon);
            this.Controls.Add(this.userIcon);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.proceedBtn);
            this.Controls.Add(this.EternalLibPic);
            this.Controls.Add(this.nightControlBox1);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FirstForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FirstForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private System.Windows.Forms.Label EternalLibPic;
        private LibrarySystem.RJButton proceedBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.PictureBox userIcon;
        private System.Windows.Forms.PictureBox passIcon;
        private CustomControls.RJControls.RJTextBox usernameBx;
        private CustomControls.RJControls.RJTextBox passwordBx;
    }
}

