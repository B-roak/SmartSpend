using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartSpend
{
    internal class Expense
    {
        public Categories Category { get; set; }

        public SubCategories SubCategory { get; set; }

        public double Value { get; set; }

        public Expense(Categories category, SubCategories subcategory, double value)
        {
            Category = category;
            SubCategory = subcategory;
            Value = value;
        }
    }
}
