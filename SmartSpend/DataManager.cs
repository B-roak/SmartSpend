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
        public static Expense GetExpenseById(int id) 
        {
            return new Expense(Categories.DailyLife,SubCategories.Rent,600);
        }

        public static void AddNewExpense(Expense expense)
        {
            Debug.WriteLine($"Added new expense {expense}");
        }
        public static List<Expense> GetAllExpenses()
        {
            return new List<Expense>() 
            {
                new Expense(Categories.DailyLife,SubCategories.Books,600),
                new Expense(Categories.DailyLife,SubCategories.Rent,5000)
        };
        }
      
    }
}
