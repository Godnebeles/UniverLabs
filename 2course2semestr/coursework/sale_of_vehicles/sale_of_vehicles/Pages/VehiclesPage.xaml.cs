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
    public class ConnectionViewModel : INotifyPropertyChanged
    {
        private readonly CollectionView _fuelTypes;
        private string _fuelType = String.Empty;

        public ConnectionViewModel(IList<FuelType> fuelTypes)
        {
            IList<FuelType> list = fuelTypes;
            _fuelTypes = new CollectionView(list);
        }

        public CollectionView FuelTypeEntries
        {
            get { return _fuelTypes; }
        }

        public string FuelTypeEntry
        {
            get { return _fuelType; }
            set
            {
                if (_fuelType == value) return;
                _fuelType = value;
                OnPropertyChanged("FuelTypeEntry");
            }
        }

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler? PropertyChanged;
    }

    public partial class VehiclesPage : Page
    {
        private VehiclesShop _carShop;
        private List<FuelType> _fuelTypes;
        private GasStation _gasStation;
        public VehiclesPage(List<Vehicle> vehicleList)
        {
            InitializeComponent();

            VehicleTypeFilter.SelectedIndex = 0;
            FuelsTypeFilter.SelectedIndex = 0;

            FuelType fuel1 = new CarFuel("Diesel");
            FuelType fuel2 = new CarFuel("Gasoline");
            FuelType fuel3 = new CarFuel("Electricity");

            _fuelTypes = new List<FuelType>();
            _fuelTypes.Add(fuel1);
            _fuelTypes.Add(fuel2);
            _fuelTypes.Add(fuel3);

            ConnectionViewModel fuelTypesCollection = new ConnectionViewModel(_fuelTypes);
            DataContext = fuelTypesCollection;

            ((ConnectionViewModel)DataContext).FuelTypeEntry = fuel1.Name;


            List<Vehicle> cars = new List<Vehicle>();

            IFunctionality functionality = new CarFunctionality();

            Vehicle car1 = new Truck("Truck?&^(", "YT 1" , 500000, 10, fuel1, 4, TypeOfCargo.Fragile, functionality);
            Vehicle car2 = new Bus("School Bus", "Ford B350",  100000, 22, fuel2, 32, functionality);
            Vehicle plane1 = new PassengerPlane("Plane \"Mriya\"", "B-P S543", 10000000, 50, fuel2, functionality);
            cars.Add(car1);
            cars.Add(car2);
            cars.Add(plane1);


            _carShop = new VehiclesShop(cars);

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

            if (FuelsTypeFilter.SelectedIndex > 0)
                FuelNameTypeFilter.IsEnabled = true;
            else
                FuelNameTypeFilter.IsEnabled = false;
        }

        private void FuelTypeFilter_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }
    }
}
