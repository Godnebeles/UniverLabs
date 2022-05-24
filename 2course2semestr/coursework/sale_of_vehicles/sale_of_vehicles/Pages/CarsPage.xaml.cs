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
    /// Interaction logic for CarsPage.xaml
    /// </summary>


    public partial class CarsPage : Page
    {

        private VehiclesShop _carShop;
        private FilterCarsDelegate[] filterFunctions = {
                                                         (car) =>(car is Bus),
                                                         (car) => (car is Truck)
                                                       };
        public CarsPage()
        {
            InitializeComponent();

            VehicleTypeFilter.SelectedIndex = 0;
            FuelTypeFilter.SelectedIndex = 0;

            List<Vehicle> cars = new List<Vehicle>();
            Vehicle car1 = new Truck("ok", 5, 10, TypesOfFuel.Gasoline, 4, TypeOfCargo.Fragile);
            Vehicle car2 = new Bus("Bus", 1, 2, TypesOfFuel.Gasoline, 4);
            cars.Add(car1);
            cars.Add(car2);

            _carShop = new VehiclesShop(cars);

            CarList.ItemsSource = _carShop.VehicleList;
        }

    }
}
