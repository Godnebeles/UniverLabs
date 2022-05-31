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
    /// Interaction logic for BusCreatUserControl.xaml
    /// </summary>
    public partial class BusCreatUserControl : UserControl, IInterfaceDataReceiver<Vehicle>
    {
        public BusCreatUserControl()
        {
            InitializeComponent();
        }

        public Vehicle GetData()
        {
            return new Bus(/*name*/                 BusName.Text,
                           /*price*/                Convert.ToDouble(BusPrice.Text),
                           /*numbers of seats*/     Convert.ToInt32(NumbersOfSeats.Text),
                           /*fuel type*/            new CarFuel("A23"),
                           /*name*/                 Convert.ToInt32(PeopleCapacity.Text),
                           /*functionality*/        new CarFunctionality()
                           );
        }

    }
}
