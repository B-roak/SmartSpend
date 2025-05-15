using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Collections.Generic;
using LiveChartsCore;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.WPF;
using Microsoft.Win32;
using System.Security.Cryptography;


namespace SmartSpend
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const float InnerRadius = 50;
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;

            UpdateExpensesChart();
            UpdateExpensesList();
        }

        public IList<ISeries> PieSeries { get; set; }

        //Events
        private void CloseClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void AddExpense(object sender, RoutedEventArgs e)
        {
            AddExpense addexp = new()
            {
                Owner = this
            };

            addexp.ShowDialog();
        }

        public void UpdateExpensesList()
        {
            ExpensesList.Items.Clear();
            List<Expense> expenses = DataManager.GetAllExpenses();

            foreach (Expense expense in expenses)
            {
                ExpensesList.Items.Add(expense);
            }
        }

        public void UpdateExpensesChart()
        {
            List<Expense> expenses = DataManager.GetAllExpenses();
            Dictionary<Categories, double> sumedCategoriesExpenses = new Dictionary<Categories, double>();
            foreach (Expense expense in expenses)
            {
                if (sumedCategoriesExpenses.ContainsKey(expense.Category))
                {
                    sumedCategoriesExpenses[expense.Category] += expense.Value;
                }
                else
                {
                    sumedCategoriesExpenses[expense.Category] = expense.Value;
                }
            }

            IList<ISeries> ChartData = new List<ISeries>();

            foreach (KeyValuePair<Categories, double> entry in sumedCategoriesExpenses)
            {
                PieSeries<double> data = new PieSeries<double> { Values = new[] { entry.Value }, Name = entry.Key.ToString(), InnerRadius = InnerRadius };
                ChartData.Add(data);
            }
            PieSeries = ChartData;
            ExpensesChart.Series = null;
            ExpensesChart.Series = PieSeries;
        }
    }
}