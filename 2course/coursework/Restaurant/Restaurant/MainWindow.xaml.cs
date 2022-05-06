using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Restaurant
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Dish dish = new Dish("Soup", 13.0, new Weight(500, UnitOfWeight.G));

            DateTimeContainer d1 = new DateTimeContainer(5, 2, 2022);
            DateTimeContainer d2 = new DateTimeContainer(5, 2, 2022);
            DateTimeContainer d3 = new DateTimeContainer(6, 2, 2022);
            Dictionary<DateTimeContainer, int> dictionary = new Dictionary<DateTimeContainer, int>();
            dictionary.Add(d1, 2);

           

            bool result = d1.Equals(d2);
            bool result1 = d1.Equals(d3);
        }

        

        private void ToMenuButton_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new MainPage();
        }
        private void ToListOfOrders_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new ListOfOrdersPage();
        }

        private void ToCalculatorButton_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new BudgetCalculatorPage();
        }
    }
}
