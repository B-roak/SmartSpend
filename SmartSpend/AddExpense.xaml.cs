using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace SmartSpend
{
    /// <summary>
    /// Interaction logic for AddExpense.xaml
    /// </summary>
    public partial class AddExpense : Window
    {
        public string[] Categories {  get; set; }
        
        public string[] SubCategories { get; set; }

        public AddExpense()
        {
            InitializeComponent();

            Categories = Enum.GetNames(typeof(Categories));
            DataContext = this;

        }
        //Events
        private void IsNum(object sender, TextCompositionEventArgs e)
        {
            char inputChar = e.Text[0];

            if (!Char.IsDigit(inputChar) && inputChar != ',')
            {
                e.Handled = true; // block input
                return;
            }

            TextBox textBox = sender as TextBox;

            if (inputChar == ',' && textBox.Text.Contains(","))
            {
                e.Handled = true;
            }
        }
        private void Drag_Window(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
        }
        private void CloseClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void SubcategoriesBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void CategoriesBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            SubcategoriesBox.Items.Clear();
            SubcategoriesBox.SelectedItem = null;

            string selectedText = (string)CategoriesBox.SelectedItem;
            Categories selectedcategories = (Categories)Enum.Parse(typeof(Categories), selectedText);
            SubCategories = CategoriesDictionary.GetSubcatNames(selectedcategories);
            foreach (string category in SubCategories)
                {
                    SubcategoriesBox.Items.Add(category);
                }
        }

        private void AddExpenseButton_Click(object sender, RoutedEventArgs e)
        {
            
            string CategoryText = (string)CategoriesBox.SelectedItem;
            string SubCategoryText = (string)SubcategoriesBox.SelectedItem;
            string ValueText = ExpensesValueTextBox.Text;

            Categories category = (Categories)Enum.Parse (typeof(Categories), CategoryText);
            SubCategories subcategory = (SubCategories)Enum.Parse(typeof (SubCategories), SubCategoryText);
            double value = double.Parse(ValueText);

            Expense expense = new Expense(category, subcategory, value);
            DataManager.AddNewExpense(expense);
            ((MainWindow)Application.Current.MainWindow).UpdateExpensesChart();
            ((MainWindow)Application.Current.MainWindow).UpdateExpensesList();

           
            
            SubcategoriesBox.Items.Clear();
            SubcategoriesBox.SelectedItem = null;
            ExpensesValueTextBox.Clear();
        }

        private void ExpensesValueTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {

        }
    }
}
