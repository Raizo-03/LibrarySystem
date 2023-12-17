namespace LibrarySystem
{
    partial class BooklistForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BooklistForm));
            this.booklistLlbl = new ReaLTaiizor.Controls.FoxBigLabel();
            this.mockingbirdBook = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.availBtn = new LibrarySystem.RJButton();
            this.acadBtn = new LibrarySystem.RJButton();
            this.nonfictionBtn = new LibrarySystem.RJButton();
            this.rjButton1 = new LibrarySystem.RJButton();
            this.fictionbook1 = new LibrarySystem.RJButton();
            this.fictionBtn = new LibrarySystem.RJButton();
            this.mockingbirdBook.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // booklistLlbl
            // 
            this.booklistLlbl.Font = new System.Drawing.Font("Segoe UI Semibold", 20F);
            this.booklistLlbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(88)))), ((int)(((byte)(100)))));
            this.booklistLlbl.Line = ReaLTaiizor.Controls.FoxBigLabel.Direction.Bottom;
            this.booklistLlbl.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.booklistLlbl.Location = new System.Drawing.Point(47, 39);
            this.booklistLlbl.Name = "booklistLlbl";
            this.booklistLlbl.Size = new System.Drawing.Size(165, 51);
            this.booklistLlbl.TabIndex = 7;
            this.booklistLlbl.Text = "Book List";
            // 
            // mockingbirdBook
            // 
            this.mockingbirdBook.BackColor = System.Drawing.Color.Transparent;
            this.mockingbirdBook.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mockingbirdBook.Controls.Add(this.panel1);
            this.mockingbirdBook.Controls.Add(this.fictionbook1);
            this.mockingbirdBook.Controls.Add(this.flowLayoutPanel1);
            this.mockingbirdBook.Location = new System.Drawing.Point(44, 113);
            this.mockingbirdBook.Name = "mockingbirdBook";
            this.mockingbirdBook.Size = new System.Drawing.Size(168, 230);
            this.mockingbirdBook.TabIndex = 6;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(89, 129);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(871, 230);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.rjButton1);
            this.panel1.Controls.Add(this.flowLayoutPanel2);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(168, 230);
            this.panel1.TabIndex = 8;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Location = new System.Drawing.Point(89, 129);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(871, 230);
            this.flowLayoutPanel2.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.No;
            this.dataGridView1.Location = new System.Drawing.Point(439, 207);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(478, 307);
            this.dataGridView1.TabIndex = 11;
            // 
            // availBtn
            // 
            this.availBtn.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.availBtn.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.availBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.availBtn.BorderRadius = 0;
            this.availBtn.BorderSize = 0;
            this.availBtn.FlatAppearance.BorderSize = 0;
            this.availBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.availBtn.ForeColor = System.Drawing.Color.White;
            this.availBtn.Location = new System.Drawing.Point(817, 27);
            this.availBtn.Name = "availBtn";
            this.availBtn.Size = new System.Drawing.Size(100, 98);
            this.availBtn.TabIndex = 10;
            this.availBtn.Text = "AVAILABLE";
            this.availBtn.TextColor = System.Drawing.Color.White;
            this.availBtn.UseVisualStyleBackColor = false;
            this.availBtn.Click += new System.EventHandler(this.availBtn_Click);
            // 
            // acadBtn
            // 
            this.acadBtn.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.acadBtn.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.acadBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.acadBtn.BorderRadius = 0;
            this.acadBtn.BorderSize = 0;
            this.acadBtn.FlatAppearance.BorderSize = 0;
            this.acadBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.acadBtn.ForeColor = System.Drawing.Color.White;
            this.acadBtn.Location = new System.Drawing.Point(696, 27);
            this.acadBtn.Name = "acadBtn";
            this.acadBtn.Size = new System.Drawing.Size(100, 98);
            this.acadBtn.TabIndex = 9;
            this.acadBtn.Text = "ACADEMIC";
            this.acadBtn.TextColor = System.Drawing.Color.White;
            this.acadBtn.UseVisualStyleBackColor = false;
            // 
            // nonfictionBtn
            // 
            this.nonfictionBtn.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.nonfictionBtn.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.nonfictionBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.nonfictionBtn.BorderRadius = 0;
            this.nonfictionBtn.BorderSize = 0;
            this.nonfictionBtn.FlatAppearance.BorderSize = 0;
            this.nonfictionBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nonfictionBtn.ForeColor = System.Drawing.Color.White;
            this.nonfictionBtn.Location = new System.Drawing.Point(574, 27);
            this.nonfictionBtn.Name = "nonfictionBtn";
            this.nonfictionBtn.Size = new System.Drawing.Size(100, 98);
            this.nonfictionBtn.TabIndex = 8;
            this.nonfictionBtn.Text = "NON - FICTION";
            this.nonfictionBtn.TextColor = System.Drawing.Color.White;
            this.nonfictionBtn.UseVisualStyleBackColor = false;
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.Transparent;
            this.rjButton1.BackgroundColor = System.Drawing.Color.Transparent;
            this.rjButton1.BorderColor = System.Drawing.Color.Transparent;
            this.rjButton1.BorderRadius = 1;
            this.rjButton1.BorderSize = 3;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton1.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.rjButton1.Image = ((System.Drawing.Image)(resources.GetObject("rjButton1.Image")));
            this.rjButton1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rjButton1.Location = new System.Drawing.Point(3, 3);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(171, 230);
            this.rjButton1.TabIndex = 1;
            this.rjButton1.Text = " \r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\nTo Kill A Mockingbird\r\n978-1-234567-89-0\r\n Harper Lee 1960\r\nJ." +
    "B. Lippincott & Co.\r\n";
            this.rjButton1.TextColor = System.Drawing.Color.DarkOliveGreen;
            this.rjButton1.UseVisualStyleBackColor = false;
            // 
            // fictionbook1
            // 
            this.fictionbook1.BackColor = System.Drawing.Color.Transparent;
            this.fictionbook1.BackgroundColor = System.Drawing.Color.Transparent;
            this.fictionbook1.BorderColor = System.Drawing.Color.Transparent;
            this.fictionbook1.BorderRadius = 1;
            this.fictionbook1.BorderSize = 3;
            this.fictionbook1.FlatAppearance.BorderSize = 0;
            this.fictionbook1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fictionbook1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fictionbook1.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.fictionbook1.Image = ((System.Drawing.Image)(resources.GetObject("fictionbook1.Image")));
            this.fictionbook1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.fictionbook1.Location = new System.Drawing.Point(3, 3);
            this.fictionbook1.Name = "fictionbook1";
            this.fictionbook1.Size = new System.Drawing.Size(171, 230);
            this.fictionbook1.TabIndex = 1;
            this.fictionbook1.Text = " \r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\nTo Kill A Mockingbird\r\n978-1-234567-89-0\r\n Harper Lee 1960\r\nJ." +
    "B. Lippincott & Co.\r\n";
            this.fictionbook1.TextColor = System.Drawing.Color.DarkOliveGreen;
            this.fictionbook1.UseVisualStyleBackColor = false;
            this.fictionbook1.Click += new System.EventHandler(this.rjButton1_Click);
            // 
            // fictionBtn
            // 
            this.fictionBtn.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.fictionBtn.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.fictionBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.fictionBtn.BorderRadius = 0;
            this.fictionBtn.BorderSize = 0;
            this.fictionBtn.FlatAppearance.BorderSize = 0;
            this.fictionBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fictionBtn.ForeColor = System.Drawing.Color.White;
            this.fictionBtn.Location = new System.Drawing.Point(451, 27);
            this.fictionBtn.Name = "fictionBtn";
            this.fictionBtn.Size = new System.Drawing.Size(100, 98);
            this.fictionBtn.TabIndex = 2;
            this.fictionBtn.Text = "FICTION";
            this.fictionBtn.TextColor = System.Drawing.Color.White;
            this.fictionBtn.UseVisualStyleBackColor = false;
            this.fictionBtn.Click += new System.EventHandler(this.fictionButton_Click);
            // 
            // BooklistForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 760);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.availBtn);
            this.Controls.Add(this.acadBtn);
            this.Controls.Add(this.nonfictionBtn);
            this.Controls.Add(this.mockingbirdBook);
            this.Controls.Add(this.booklistLlbl);
            this.Controls.Add(this.fictionBtn);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BooklistForm";
            this.Load += new System.EventHandler(this.BooklistForm_Load);
            this.mockingbirdBook.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private RJButton fictionBtn;
        private ReaLTaiizor.Controls.FoxBigLabel booklistLlbl;
        private System.Windows.Forms.Panel mockingbirdBook;
        private RJButton fictionbook1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private RJButton rjButton1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private RJButton nonfictionBtn;
        private RJButton acadBtn;
        private RJButton availBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}