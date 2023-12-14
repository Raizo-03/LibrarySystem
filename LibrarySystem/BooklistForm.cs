using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace LibrarySystem
{
    public partial class BooklistForm : Form
    {
        private List<Book> bookList = new List<Book>();
        private BindingSource bindingSource = new BindingSource();

        public BooklistForm()
        {
            InitializeComponent();
            InitializeDataGridView();
        }

        private void BooklistForm_Load(object sender, EventArgs e)
        {
            // Perform any additional initialization here if needed
        }

        private void InitializeDataGridView()
        {
            bookTable.DefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Regular);

            // Customize DataGridView properties as needed
            bookTable.AutoGenerateColumns = false;


            // Set DataPropertyName for each column
            DataGridViewTextBoxColumn titleColumn = new DataGridViewTextBoxColumn();
            titleColumn.Name = "Title";
            titleColumn.HeaderText = "Title";
            titleColumn.DataPropertyName = "Title";
            titleColumn.DefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Bold); // Set font style
            bookTable.Columns.Add(titleColumn);

          

            // ISBN Column
            DataGridViewTextBoxColumn isbnColumn = new DataGridViewTextBoxColumn();
            isbnColumn.Name = "ISBN";
            isbnColumn.HeaderText = "ISBN";
            isbnColumn.DataPropertyName = "ISBN";
            bookTable.Columns.Add(isbnColumn);

            // Category Column
            DataGridViewTextBoxColumn categoryColumn = new DataGridViewTextBoxColumn();
            categoryColumn.Name = "Category";
            categoryColumn.HeaderText = "Category";
            categoryColumn.DataPropertyName = "Category";
            bookTable.Columns.Add(categoryColumn);

            // Author Column
            DataGridViewTextBoxColumn authorColumn = new DataGridViewTextBoxColumn();
            authorColumn.Name = "Author";
            authorColumn.HeaderText = "Author";
            authorColumn.DataPropertyName = "Author";
            bookTable.Columns.Add(authorColumn);

            // Copyright Column
            DataGridViewTextBoxColumn copyrightColumn = new DataGridViewTextBoxColumn();
            copyrightColumn.Name = "Copyright";
            copyrightColumn.HeaderText = "Copyright";
            copyrightColumn.DataPropertyName = "Copyright";
            bookTable.Columns.Add(copyrightColumn);

            // Publisher Column
            DataGridViewTextBoxColumn publisherColumn = new DataGridViewTextBoxColumn();
            publisherColumn.Name = "Publisher";
            publisherColumn.HeaderText = "Publisher";
            publisherColumn.DataPropertyName = "Publisher";
            bookTable.Columns.Add(publisherColumn);

            // Status Column
            DataGridViewTextBoxColumn statusColumn = new DataGridViewTextBoxColumn();
            statusColumn.Name = "Status";
            statusColumn.HeaderText = "Status";
            statusColumn.DataPropertyName = "Status";
            bookTable.Columns.Add(statusColumn);

            bookTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Set the default selection back color to white
            bookTable.DefaultCellStyle.SelectionBackColor = Color.Transparent;

            bindingSource.DataSource = bookList;
            bookTable.DataSource = bindingSource;

            // Handle the RowStateChanged event to change the background color of the selected row
            bookTable.RowStateChanged += BookTableRowStateChanged;


        }

        private void BookTableRowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            foreach (DataGridViewCell cell in e.Row.Cells)
            {
                // Create a new style object with the desired color
                var customStyle = new DataGridViewCellStyle()
                {
                    ForeColor = Color.Black, // Change this color as needed
                };
                cell.Style = customStyle;
            }


        }

        public class Book
        {
            public System.Drawing.Image Image { get; set; }
            public string Title { get; set; }
            public string ISBN { get; set; }
            public string Category { get; set; }
            public string Author { get; set; }
            public int Copyright { get; set; }
            public string Publisher { get; set; }
            public string Status { get; set; }
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            // Set the Image for the new book
            System.Drawing.Image bookImage = System.Drawing.Image.FromFile(@"C:\Users\USER\source\repos\LibrarySystem\images\aboutIcon.png");

            // Add a predefined book to the list
            Book newBook = new Book
            {
                Image = bookImage,
                Title = "Sample Title",
                ISBN = "1234567890",
                Category = "Fiction",
                Author = "John Doe",
                Copyright = 2023,
                Publisher = "Sample Publisher",
                Status = "Available"
            };
            // Add the new book to the list
            bookList.Add(newBook);

            // Update the BindingSource to refresh the DataGridView
            bindingSource.ResetBindings(false);

            // Select the last row (newly added book)
            if (bookTable.Rows.Count > 0)
            {
                bookTable.Rows[bookTable.Rows.Count -1].Selected = true;
            }


        }
    }
}
