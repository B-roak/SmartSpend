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


namespace SmartSpend
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;

            PieSeries = new List<ISeries>
            {
                new PieSeries<double> { Values = new[] { 40.0 }, Name = "Fixed Charges", InnerRadius = 50},
                new PieSeries<double> { Values = new[] { 30.0 }, Name = "Daily Life",InnerRadius = 50 },
                new PieSeries<double> { Values = new[] { 20.0 }, Name = "Transport",InnerRadius = 50 },
                new PieSeries<double> { Values = new[] { 10.0 }, Name = "Entertainment" , InnerRadius = 50},
                new PieSeries<double> { Values = new[] { 40.0 }, Name = "Savings", InnerRadius = 50},
                new PieSeries<double> { Values = new[] { 40.0 }, Name = "Unexpected Expenses", InnerRadius = 50}


            };
        }

        public IEnumerable<ISeries> PieSeries { get; set; }

        private void CloseClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

       

    }
}