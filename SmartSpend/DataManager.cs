using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartSpend
{
    static class DataManager 
    {
        private static List<Expense> ExpenseList = new List<Expense>();
    
        public static void AddNewExpense(Expense expense)
        {
            ExpenseList.Add(expense);
        }
        public static List<Expense> GetAllExpenses()
        {
            return ExpenseList; 
        }
    }
}
