using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace LibrarySystem
{
    public partial class BooklistForm : Form
    {
        private List<Book> books;

        public BooklistForm()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(255, 253, 247, 228); // CUSTOM BG COLOR #FDF7E4
            books = new List<Book>();

            // Set DataGridView to read-only
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.CellSelect;

            // Initialize DataGridView columns
            dataGridView1.ColumnCount = 3;
            dataGridView1.Columns[0].Name = "Title";
            dataGridView1.Columns[1].Name = "Genre";
            dataGridView1.Columns[2].Name = "Availability";

            // Add DataGridViewComboBoxColumn for Genre
            DataGridViewComboBoxColumn genreColumn = new DataGridViewComboBoxColumn();
            genreColumn.HeaderText = "Genre";
            genreColumn.Name = "Genre";
            genreColumn.Items.AddRange("Fiction", "Non-Fiction", "Academic");
            dataGridView1.Columns.Add(genreColumn);

            // Add DataGridViewCheckBoxColumn for Availability
            DataGridViewCheckBoxColumn availabilityColumn = new DataGridViewCheckBoxColumn();
            availabilityColumn.HeaderText = "Availability";
            availabilityColumn.Name = "Availability";
            dataGridView1.Columns.Add(availabilityColumn);

            // Attach the SortCompare event handler for Genre column sorting
            dataGridView1.SortCompare += DataGridView1_SortCompare;
        }

        // Add a method to populate the DataGridView with books
        private void PopulateDataGridView()
        {
            dataGridView1.Rows.Clear(); // Clear existing rows

            foreach (var book in books)
            {
                int rowIndex = dataGridView1.Rows.Add();
                dataGridView1.Rows[rowIndex].Cells["Title"].Value = book.Title;
                dataGridView1.Rows[rowIndex].Cells["Genre"].Value = book.Genre;
                dataGridView1.Rows[rowIndex].Cells["Availability"].Value = book.IsAvailable;
            }
        }

        private void BooklistForm_Load(object sender, EventArgs e)
        {
            // Optional: You can load additional data or perform any setup when the form loads.
        }

        private void fictionButton_Click(object sender, EventArgs e)
        {
            // Optional: You can implement logic for handling the fictionButton click event.
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            // Optional: You can implement logic for handling the rjButton1 click event.
        }

        private void ShowBookDetails(Book book)
        {
            // Optional: You can implement logic for displaying book details.
        }

        private void availBtn_Click(object sender, EventArgs e)
        {
            // Add predefined books
            books.Add(new Book { Title = "To Kill a Mockingbird", Genre = "Fiction", IsAvailable = true });
            books.Add(new Book { Title = "1984", Genre = "Fiction", IsAvailable = true });
            books.Add(new Book { Title = "Pride and Prejudice", Genre = "Fiction", IsAvailable = true });
            books.Add(new Book { Title = "The Great Gatsby", Genre = "Fiction", IsAvailable = true });
            books.Add(new Book { Title = "One Hundred Years of Solitude", Genre = "Fiction", IsAvailable = true });
            books.Add(new Book { Title = "Sapiens: A Brief History of Humankind", Genre = "Non-Fiction", IsAvailable = true });
            books.Add(new Book { Title = "The Immortal Life of Henrietta Lacks", Genre = "Non-Fiction", IsAvailable = true });
            books.Add(new Book { Title = "Educated", Genre = "Non-Fiction", IsAvailable = true });
            books.Add(new Book { Title = "The Diary of a Young Girl", Genre = "Non-Fiction", IsAvailable = true });
            books.Add(new Book { Title = "Thinking, Fast and Slow", Genre = "Non-Fiction", IsAvailable = true });
            books.Add(new Book { Title = "A Brief History of Time", Genre = "Academic", IsAvailable = true });
            books.Add(new Book { Title = "The Elements of Style", Genre = "Academic", IsAvailable = true });
            books.Add(new Book { Title = "Principia Mathematica", Genre = "Academic", IsAvailable = true });
            books.Add(new Book { Title = "The Structure of Scientific Revolutions", Genre = "Academic", IsAvailable = true });
            books.Add(new Book { Title = "The Origin of Species", Genre = "Academic", IsAvailable = true });

            // Populate the DataGridView with the updated list of books
            PopulateDataGridView();
        }
        // Event handler for the SortCompare event to customize sorting for Genre column
        private void DataGridView1_SortCompare(object sender, DataGridViewSortCompareEventArgs e)
        {
            if (e.Column.Name == "Genre") // Check if sorting is on the Genre column
            {
                e.SortResult = String.Compare(e.CellValue1.ToString(), e.CellValue2.ToString());
                e.Handled = true; // Handle the sorting
            }
        }
        
        public class Book
        {
            public string Title { get; set; }
            public string Genre { get; set; }
            public bool IsAvailable { get; set; }
        }
    }
}
