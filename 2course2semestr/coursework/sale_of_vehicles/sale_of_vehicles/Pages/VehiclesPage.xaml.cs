using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    /// Interaction logic for CarsPage.xaml
    /// </summary>
    public partial class VehiclesPage : Page
    {
        private VehiclesShop _carShop;
        private GasStation _gasStation;
        public VehiclesPage(List<Vehicle> vehicleList, GasStation gasStation)
        {
            InitializeComponent();

            _gasStation = gasStation;
            _carShop = new VehiclesShop(vehicleList);

            InitializePage();        
        }

        public void InitializePage()
        {
            VehicleTypeFilter.SelectedIndex = 0;
            FuelsTypeFilter.SelectedIndex = 0;

            CarList.ItemsSource = _carShop.VehicleList;
        }

        private void VehicleTypeFilter_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            CarList.ItemsSource = null;
            if (VehicleTypeFilter.SelectedIndex == 0)
                CarList.ItemsSource = _carShop?.VehicleList;
            else if (VehicleTypeFilter.SelectedIndex == 1)
                CarList.ItemsSource = _carShop.GetBuses();
            else if (VehicleTypeFilter.SelectedIndex == 2)
                CarList.ItemsSource = _carShop.GetTrucks();
            else if (VehicleTypeFilter.SelectedIndex == 3)
                CarList.ItemsSource = _carShop.GetPassengerPlanes();
            else if (VehicleTypeFilter.SelectedIndex == 4)
                CarList.ItemsSource = _carShop.GetTransportPlanes();  
        }

        private void FuelsTypeFilter_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (FuelsTypeFilter.SelectedIndex > 0)
                FuelNameTypeFilter.IsEnabled = true;
            else
                FuelNameTypeFilter.IsEnabled = false;

            if (FuelsTypeFilter.SelectedIndex == 1)
            {
                DataContext = new ConnectionViewModel(_gasStation.GetCarFuels());
            }
            else if(FuelsTypeFilter.SelectedIndex == 2)
            {
                DataContext = new ConnectionViewModel(_gasStation.GetPlaneFuels());
            }
        }
    }
}
