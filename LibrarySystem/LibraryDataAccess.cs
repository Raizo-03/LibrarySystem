using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{

    internal class LibraryDataAccess
    {
        private string connectionString = "Server=localhost;Database=librarysystem;Uid=root;Pwd='';";

        public void BorrowBook(string title, int userId, DateTime borrowDate, DateTime dueDate)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                // Note: Remove the book_id from the column list if it's an AUTO_INCREMENT field
                string query = "INSERT INTO borrowings (book_title, user_id, borrow_date, due_date) VALUES (@book_title, @userId, @borrowDate, @dueDate)";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@book_title", title);
                    command.Parameters.AddWithValue("@userId", userId);
                    command.Parameters.AddWithValue("@borrowDate", borrowDate);
                    command.Parameters.AddWithValue("@dueDate", dueDate);

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
