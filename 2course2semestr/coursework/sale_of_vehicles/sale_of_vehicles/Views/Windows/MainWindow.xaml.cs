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

namespace sale_of_vehicles.Views.Windows
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
            PresentCarListPage();
        }

        private void PresentCarListPage()
        {
            VehiclesPage vehiclePage = new VehiclesPage(_vehicleShop, _dataLoader.LoadFuelData());
            vehiclePage.OnDataChangedEvent += SaveData;
            MainFrame.Content = vehiclePage;
        }

        private void AddVehicle(Vehicle obj)
        {
            _vehicleShop.AddVehicle(obj);
            SaveData();
        }

        private void SaveData()
        {
            _dataLoader.SaveVehiclesData(_vehicleShop.VehicleList);
        }

        private void ListViewMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int index = ListViewMenu.SelectedIndex;

            switch (index)
            {
                case 0:
                    PresentCarListPage();
                    break;
                case 1:
                    var vehiclePage = new VehicleCreatorPage();
                    vehiclePage.OnVehicleCreatedEvent += AddVehicle;
                    MainFrame.Content = vehiclePage;
                    break;
            }
        }

        
    }
}
