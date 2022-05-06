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
        MainPage mainPage = new MainPage();
        ListOfOrdersPage listOfOrdersPage = new ListOfOrdersPage();
        BudgetCalculatorPage budgetCalculatorPage = new BudgetCalculatorPage();
        class Dishes
        {
            public int id { get; set; }
            public string dishName { get; set; }
            public int price { get; set; }
            public int count { get; set; }
        }

        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Content = mainPage;

            Dish dish = new Dish(3,"Soup", 13.0, new Weight(500, UnitOfWeight.G));

            DateTimeContainer d1 = new DateTimeContainer(5, 2, 2022);
            DateTimeContainer d2 = new DateTimeContainer(5, 2, 2022);
            DateTimeContainer d3 = new DateTimeContainer(6, 2, 2022);

            Dictionary<DateTimeContainer, int> dictionary = new Dictionary<DateTimeContainer, int>();
            dictionary.Add(d1, 2);        

            bool result = d1.Equals(d2);
            bool result1 = d1.Equals(d3);

            mainPage.DataGridDishes.ItemsSource = new List<Dishes>() { new Dishes() { id = 6, dishName = "Ketchup", price = 204320, count = 3 } };
            
        }
      

        private void ToMenuButton_Click(object sender, RoutedEventArgs e)
        {
            ChangePage((Button)sender, mainPage);
        }

        private void ToListOfOrders_Click(object sender, RoutedEventArgs e)
        {
            ChangePage((Button)sender, listOfOrdersPage);
        }

        private void ToCalculatorButton_Click(object sender, RoutedEventArgs e)
        {
            ChangePage((Button)sender, budgetCalculatorPage);
        }

        public void ChangePage(Button btn, Page page)
        {
            MainFrame.Content = page;
        }
    }
}
