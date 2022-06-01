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
    /// Interaction logic for TransportPlaneCreatUserControl.xaml
    /// </summary>
    public partial class TransportPlaneCreatUserControl : UserControl, IInterfaceDataReceiver<Vehicle>
    {
        public TransportPlaneCreatUserControl()
        {
            InitializeComponent();
        }

        public Vehicle GetData()
        {
            return new TransportPlane(/*name*/                   Name.Text,
                                        /*model*/                Model.Text,
                                        /*price*/                Convert.ToDouble(Price.Text),
                                        /*numbers of seats*/     Convert.ToInt32(NumbersOfSeats.Text),
                                        /*fuel type*/            new AviationFuel("A23"),
                                        /*max weight of cargo*/  Convert.ToDouble(MaxWeightOfCargo.Text),
                                        /*name*/                 (TypeOfCargo)CargoTypeSelector.SelectedIndex,
                                        /*functionality*/        new PlaneFunctionality()
                                      );
        }
    }
}
