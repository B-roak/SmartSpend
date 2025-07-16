using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartSpend
{
    public class DatabaseManager : DataManager
    {
        protected const string ConnectionString = "Data Source=expenses.db";
        public DatabaseManager()
        {
            using var connection = new SqliteConnection(ConnectionString);
            connection.Open();

            var tableCmd = connection.CreateCommand();
            tableCmd.CommandText =
            @"
            CREATE TABLE IF NOT EXISTS Expenses (
                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                Category INTEGER NOT NULL,
                SubCategory INTEGER NOT NULL,
                Value REAL NOT NULL
            );
            ";
            tableCmd.ExecuteNonQuery();
        }

        public override  void AddNewExpense(Expense expense)
        {
            using var connection = new SqliteConnection(ConnectionString);
            connection.Open();

            var insertCmd = connection.CreateCommand();
            insertCmd.CommandText =
            @"
            INSERT INTO Expenses (Category, SubCategory, Value)
            VALUES ($cat, $sub, $val);
        ";
            insertCmd.Parameters.AddWithValue("$cat", (int)expense.Category);
            insertCmd.Parameters.AddWithValue("$sub", (int)expense.SubCategory);
            insertCmd.Parameters.AddWithValue("$val", expense.Value);

            insertCmd.ExecuteNonQuery();
        }

        public override void DeleteExpense(Expense expense)
        {
            using var connection = new SqliteConnection(ConnectionString);
            connection.Open();

            var deleteCmd = connection.CreateCommand();
            deleteCmd.CommandText =
            @"
            DELETE FROM Expenses WHERE Id = $id
        ";
            
            deleteCmd.Parameters.AddWithValue("$id", expense.ID);

            deleteCmd.ExecuteNonQuery();
          
        }

        public override  List<Expense> GetAllExpenses()
        {
            var expenses = new List<Expense>();

            using var connection = new SqliteConnection(ConnectionString);
            connection.Open();

            var selectCmd = connection.CreateCommand();
            selectCmd.CommandText = "SELECT Category, SubCategory, Value, Id FROM Expenses";

            using var reader = selectCmd.ExecuteReader();
            while (reader.Read())
            {
                expenses.Add(new Expense
                (
                   (Categories)reader.GetInt32(0),
                   (SubCategories)reader.GetInt32(1),
                   reader.GetDouble(2),
                   reader.GetInt32(3)
                ));
            }

            return expenses;
        }
    }
}
