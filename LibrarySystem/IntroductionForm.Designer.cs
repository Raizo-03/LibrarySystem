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
            this.usernameBx = new System.Windows.Forms.TextBox();
            this.passwordBx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.userIcon = new System.Windows.Forms.PictureBox();
            this.passIcon = new System.Windows.Forms.PictureBox();
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
            // usernameBx
            // 
            this.usernameBx.Location = new System.Drawing.Point(106, 338);
            this.usernameBx.Name = "usernameBx";
            this.usernameBx.Size = new System.Drawing.Size(179, 20);
            this.usernameBx.TabIndex = 4;
            // 
            // passwordBx
            // 
            this.passwordBx.Location = new System.Drawing.Point(106, 388);
            this.passwordBx.Name = "passwordBx";
            this.passwordBx.Size = new System.Drawing.Size(179, 20);
            this.passwordBx.TabIndex = 5;
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
            this.lblMessage.Location = new System.Drawing.Point(103, 421);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(35, 13);
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
            this.Controls.Add(this.passIcon);
            this.Controls.Add(this.userIcon);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passwordBx);
            this.Controls.Add(this.usernameBx);
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
        private System.Windows.Forms.TextBox usernameBx;
        private System.Windows.Forms.TextBox passwordBx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.PictureBox userIcon;
        private System.Windows.Forms.PictureBox passIcon;
    }
}

