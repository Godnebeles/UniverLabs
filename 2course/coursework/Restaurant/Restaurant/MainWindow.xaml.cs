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
        // my tests
        private Storage _storage = new Storage();
        private CookingPlan _cookingPlan = new CookingPlan();
        private BudgetCalculator _budgetCalculator;

        private DataLoader _dataLoader = new DataLoader("cooking_list.json", "storage.json");
        //
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Content = mainPage;

            Ingredient ingredient1 = new Ingredient(0, "Паштет", 100.0);
            Ingredient ingredient2 = new Ingredient(1, "Крутони", 210.0);
            Ingredient ingredient3 = new Ingredient(2, "Сало", 210.0);
            Ingredient ingredient4 = new Ingredient(3, "Гірчиця", 210.0);


            Dish dish1 = new Dish(0, "Паштет з ягідним джемом та крутонами", 90, new Weight(100, UnitOfWeight.G));
            dish1.AddIngredientInRecipe(new IngredientWeight(ingredient1, new Weight(220, UnitOfWeight.G)));
            dish1.AddIngredientInRecipe(new IngredientWeight(ingredient2, new Weight(60, UnitOfWeight.G)));
            dish1.ChangeWeightNeededIngredient(new IngredientWeight(ingredient2, new Weight(65, UnitOfWeight.G)));
            Dish dish2 = new Dish(1, "Сало з гірчицею", 107, new Weight(100, UnitOfWeight.G));
            dish2.AddIngredientInRecipe(new IngredientWeight(ingredient3, new Weight(60, UnitOfWeight.G)));
            dish2.AddIngredientInRecipe(new IngredientWeight(ingredient4, new Weight(60, UnitOfWeight.G)));

            _storage.Ingredients.Add(new IngredientWeight(ingredient1, new Weight(700.0, UnitOfWeight.G)));
            _storage.Ingredients.Add(new IngredientWeight(ingredient2, new Weight(633.0, UnitOfWeight.G)));
            _storage.Ingredients.Add(new IngredientWeight(ingredient3, new Weight(650, UnitOfWeight.G)));
            _storage.Ingredients.Add(new IngredientWeight(ingredient4, new Weight(120, UnitOfWeight.G)));

            _storage.Menu.Add(dish1);
            _storage.Menu.Add(dish2);

            _cookingPlan.AddOrder(new Order(new DateTimeContainer(12, 3, 2022), new DishCount(dish1, 2)));

            _dataLoader.SaveCookingPlan(_cookingPlan);
            _dataLoader.SaveStorage(_storage);
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
