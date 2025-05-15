using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartSpend
{
    internal class DataManager 
    {
        public Expense GetExpenseById(int id) 
        {
            return new Expense(Categories.DailyLife,SubCategories.Rent,600);
        }

        public void AddNewExpense(Expense expense)
        {
            
        }
        public List<Expense> GetAllExpenses()
        {
            return new List<Expense>();
        }
      
    }
}
