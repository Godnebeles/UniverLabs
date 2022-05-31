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

namespace sale_of_vehicles
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private VehiclesShop _vehicleShop;
        private IDataLoader _dataLoader;
        public MainWindow()
        {
            _dataLoader = new DataLoader("fuels_type.txt", "vehicle_list.txt");
            _vehicleShop = new VehiclesShop(_dataLoader.LoadVehiclesData());

            InitializeComponent();

            MainFrame.NavigationUIVisibility = NavigationUIVisibility.Hidden;

        }

        private void PresentCarListPage()
        {
            VehiclesPage vehiclePage = new VehiclesPage(_vehicleShop.VehicleList);

            MainFrame.Content = vehiclePage;
        }

        private void ListViewMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int index = ListViewMenu.SelectedIndex;
            MoveCursorMenu(index);

            switch (index)
            {
                case 0:
                    PresentCarListPage();
                    break;
                case 1:
                    MainFrame.Content = new VehicleCreatorPage();
                    break;
            }
        }

        /// <summary>
        /// Custom interface
        /// </summary>
        private void ButtonFechar_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void ButtonFullScreen_Click(object sender, RoutedEventArgs e)
        {
            if (Application.Current.MainWindow.WindowState == WindowState.Normal)
                Application.Current.MainWindow.WindowState = WindowState.Maximized;
            else
                Application.Current.MainWindow.WindowState = WindowState.Normal;
        }

        private void ButtonMinimized_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.WindowState = WindowState.Minimized;

        }

        private void MoveCursorMenu(int index)
        {
            TrainsitionigContentSlide.OnApplyTemplate();
            GridCursor.Margin = new Thickness(0, (100 + (60 * index)), 0, 0);
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

       
    }
}
