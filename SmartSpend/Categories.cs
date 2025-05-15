using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartSpend
{
    enum Categories
    {
        Utilities,
        DailyLife, 
        Transport,
        Entertainment, 
        Savings,
        Miscellaneous
    }

    enum SubCategories 
    {
        //Utilities
        Electricity,
        Water,
        Rent,
        Gas,
        Heating,
        Internet,
        //DailyLife
        Grocery,
        CleaningSupplies,
        PetFood,
        Toiletries,
        //Transport
        PublicTransport,
        Fuel,
        ParkingFees,
        CarMaintenance,
        Insurance,
        //Entertainment
        Hobbies,
        Books,
        Events,
        //Savings
        EmergencyFund,
        LoanPayments,
        //Miscellaneous
        UnexpectedExpenses,
        Gifts,
        SpecialOccasions

    }

    static class CategoriesDictionary
    {
        private static Dictionary<Categories, List<SubCategories>> categoriesmapping = new Dictionary<Categories, List<SubCategories>>();

        static CategoriesDictionary()
        {
            categoriesmapping[Categories.Utilities]= new List<SubCategories>() 
            { 
              SubCategories.Electricity,
              SubCategories.Water,
              SubCategories.Rent,
              SubCategories.Gas,
              SubCategories.Heating,
              SubCategories.Internet,
            };

            categoriesmapping[Categories.DailyLife] = new List<SubCategories>()
            {
                SubCategories.Grocery,
                SubCategories.CleaningSupplies,
                SubCategories.PetFood,
                SubCategories.Toiletries,
            };

            categoriesmapping[Categories.Transport] = new List<SubCategories>()
            { 
                SubCategories.PublicTransport,
                SubCategories.Fuel,
                SubCategories.ParkingFees,
                SubCategories.CarMaintenance,
                SubCategories.Insurance,
            };

            categoriesmapping[Categories.Entertainment] = new List<SubCategories>()
            {
                SubCategories.Hobbies,
                SubCategories.Books,
                SubCategories.Events
            };

            categoriesmapping[Categories.Savings] = new List<SubCategories>()
            {
                SubCategories.EmergencyFund,
                SubCategories.LoanPayments
            };

            categoriesmapping[Categories.Miscellaneous] = new List<SubCategories>()
            {
                SubCategories.UnexpectedExpenses,
                SubCategories.Gifts,
                SubCategories.SpecialOccasions
            };
        }
        
        public static string[] GetSubcatNames(Categories category)
        {
            
            return categoriesmapping[category].Select(sc=>sc.ToString()).ToArray();
        }
        

    }
}
