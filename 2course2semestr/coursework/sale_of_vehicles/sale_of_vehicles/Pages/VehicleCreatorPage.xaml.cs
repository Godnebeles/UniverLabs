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
    /// Interaction logic for CarCreatorPage.xaml
    /// </summary>
    /// 
    public delegate void SelectedDelegate();
    public partial class VehicleCreatorPage : Page
    {
        private SelectedDelegate[] selectedDelegates;

        public VehicleCreatorPage()
        {
            InitializeComponent();
            
            selectedDelegates = new SelectedDelegate[2] { CreateBus, CreateTruck };
        }


        public void CreateBus()
        {
            CurrentVehicleFields.Children.Clear();
            CurrentVehicleFields.Children.Add(new BusCreatUserControl());
        }

        public void CreateTruck()
        {
            CurrentVehicleFields.Children.Clear();
            CurrentVehicleFields.Children.Add(new TruckCreatUserControl());
        }

        private void TypeOfVehicle_Selected(object sender, SelectionChangedEventArgs e)
        {
            selectedDelegates[TypeOfVehicle.SelectedIndex].Invoke();
        }



    }
}
