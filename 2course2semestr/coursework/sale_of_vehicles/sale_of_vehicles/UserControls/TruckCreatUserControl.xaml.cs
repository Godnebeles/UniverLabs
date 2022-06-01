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
    /// Interaction logic for TruckCreatUserControl.xaml
    /// </summary>
    public partial class TruckCreatUserControl : UserControl, IInterfaceDataReceiver<Vehicle>
    {
        public TruckCreatUserControl()
        {
            InitializeComponent();
        }

        public Vehicle GetData()
        {
            return new Truck(/*name*/                 Guid.NewGuid(),
                             /*model*/                Name.Text,
                             /*model*/                Model.Text,
                             /*price*/                Convert.ToDouble(Price.Text),
                             /*numbers of seats*/     Convert.ToInt32(NumbersOfSeats.Text),
                             /*fuel type*/            new CarFuel("A23"),
                             /*functionality*/        new CarFunctionality(),
                             /*max weight of cargo*/  Convert.ToDouble(MaxWeightOfCargo.Text),
                             /*name*/                 (TypeOfCargo)CargoTypeSelector.SelectedIndex
                           );
        }
    }
}
