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
            this.hellolabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.allbooksBtn = new LibrarySystem.RJButton();
            this.availbooksBtn = new LibrarySystem.RJButton();
            this.allbooksLabel = new System.Windows.Forms.Label();
            this.availableLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // hellolabel
            // 
            this.hellolabel.AutoSize = true;
            this.hellolabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hellolabel.Location = new System.Drawing.Point(66, 84);
            this.hellolabel.Name = "hellolabel";
            this.hellolabel.Size = new System.Drawing.Size(123, 42);
            this.hellolabel.TabIndex = 1;
            this.hellolabel.Text = "Hello, ";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(179, 84);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(137, 42);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "ADMIN";
            // 
            // allbooksBtn
            // 
            this.allbooksBtn.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.allbooksBtn.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.allbooksBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.allbooksBtn.BorderRadius = 0;
            this.allbooksBtn.BorderSize = 0;
            this.allbooksBtn.FlatAppearance.BorderSize = 0;
            this.allbooksBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.allbooksBtn.ForeColor = System.Drawing.Color.White;
            this.allbooksBtn.Location = new System.Drawing.Point(564, 12);
            this.allbooksBtn.Name = "allbooksBtn";
            this.allbooksBtn.Size = new System.Drawing.Size(176, 40);
            this.allbooksBtn.TabIndex = 12;
            this.allbooksBtn.Text = "All Books";
            this.allbooksBtn.TextColor = System.Drawing.Color.White;
            this.allbooksBtn.UseVisualStyleBackColor = false;
            // 
            // availbooksBtn
            // 
            this.availbooksBtn.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.availbooksBtn.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.availbooksBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.availbooksBtn.BorderRadius = 0;
            this.availbooksBtn.BorderSize = 0;
            this.availbooksBtn.FlatAppearance.BorderSize = 0;
            this.availbooksBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.availbooksBtn.ForeColor = System.Drawing.Color.White;
            this.availbooksBtn.Location = new System.Drawing.Point(564, 71);
            this.availbooksBtn.Name = "availbooksBtn";
            this.availbooksBtn.Size = new System.Drawing.Size(176, 40);
            this.availbooksBtn.TabIndex = 13;
            this.availbooksBtn.Text = "Available Books";
            this.availbooksBtn.TextColor = System.Drawing.Color.White;
            this.availbooksBtn.UseVisualStyleBackColor = false;
            // 
            // allbooksLabel
            // 
            this.allbooksLabel.BackColor = System.Drawing.Color.Transparent;
            this.allbooksLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allbooksLabel.Location = new System.Drawing.Point(702, 12);
            this.allbooksLabel.Name = "allbooksLabel";
            this.allbooksLabel.Size = new System.Drawing.Size(38, 40);
            this.allbooksLabel.TabIndex = 14;
            this.allbooksLabel.Text = "15";
            this.allbooksLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // availableLabel
            // 
            this.availableLabel.BackColor = System.Drawing.Color.Transparent;
            this.availableLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.availableLabel.Location = new System.Drawing.Point(702, 71);
            this.availableLabel.Name = "availableLabel";
            this.availableLabel.Size = new System.Drawing.Size(38, 40);
            this.availableLabel.TabIndex = 15;
            this.availableLabel.Text = "10";
            this.availableLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DashboardForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(1057, 880);
            this.ControlBox = false;
            this.Controls.Add(this.availableLabel);
            this.Controls.Add(this.allbooksLabel);
            this.Controls.Add(this.availbooksBtn);
            this.Controls.Add(this.allbooksBtn);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.hellolabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DashboardForm2";
            this.Load += new System.EventHandler(this.DashboardForm2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label hellolabel;
        private System.Windows.Forms.Label nameLabel;
        private RJButton allbooksBtn;
        private RJButton availbooksBtn;
        private System.Windows.Forms.Label allbooksLabel;
        private System.Windows.Forms.Label availableLabel;
    }
}