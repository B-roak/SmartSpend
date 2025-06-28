using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;



namespace SmartSpend
{
    internal static class DataManager
    {
        private const string ConnectionString = "Data Source=expenses.db";

        static DataManager()
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

        internal static void AddNewExpense(Expense expense)
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

        internal static List<Expense> GetAllExpenses()
        {
            var expenses = new List<Expense>();

            using var connection = new SqliteConnection(ConnectionString);
            connection.Open();

            var selectCmd = connection.CreateCommand();
            selectCmd.CommandText = "SELECT Category, SubCategory, Value FROM Expenses";

            using var reader = selectCmd.ExecuteReader();
            while (reader.Read())
            {
                expenses.Add(new Expense
                (
                   (Categories)reader.GetInt32(0),
                   (SubCategories)reader.GetInt32(1),
                   reader.GetDouble(2)
                ));
            }

            return expenses;
        }
    }
}
