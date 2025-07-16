using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartSpend
{
    public class Expense
    {
        public Categories Category { get; set; }

        public SubCategories SubCategory { get; set; }

        public double Value { get; set; }
        
        public int ID { get; set; }

        public Expense(Categories category, SubCategories subcategory, double value, int id)
        {
            Category = category;
            SubCategory = subcategory;
            Value = value;
            ID = id;
        }

        public override string ToString()
        {
            return $"Category:          {Category}\nSubCategory:    {SubCategory}\nValue:                {Value} zł";
        }
    }
}
