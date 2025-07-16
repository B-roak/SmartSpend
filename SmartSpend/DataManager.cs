using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;



namespace SmartSpend
{
    public abstract class DataManager
    {
        public abstract void AddNewExpense(Expense expense);

        public abstract List<Expense> GetAllExpenses();

        public abstract void DeleteExpense(Expense expense);
    }
}