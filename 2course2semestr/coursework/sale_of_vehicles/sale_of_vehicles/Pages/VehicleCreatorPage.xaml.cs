﻿using System;
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

            //selectedDelegates = new SelectedDelegate[4] { CreateBus, CreateTruck, CreatePassengerPlane, CreateTransportPlane };
            selectedDelegates = new SelectedDelegate[4] { () => AdditionFields.Children.Add(new BusCreatUserControl()) , 
                                                          () => AdditionFields.Children.Add(new TruckCreatUserControl()), 
                                                          () => AdditionFields.Children.Add(new PassengerPlaneCreatUserControl()), 
                                                          () => AdditionFields.Children.Add(new TransportPlaneCreatUserControl()) };
        }



        //public void CreateBus()
        //{
        //    AdditionFields.Children.Add(new BusCreatUserControl());
        //}

        //public void CreateTruck()
        //{
        //    AdditionFields.Children.Add(new TruckCreatUserControl());
        //}

        //public void CreatePassengerPlane()
        //{
        //    AdditionFields.Children.Add(new PassengerPlaneCreatUserControl());
        //}

        //public void CreateTransportPlane()
        //{
        //    TransportPlaneCreatUserControl userControl = new TransportPlaneCreatUserControl();
        //    AdditionFields.Children.Add(userControl);
        //}
        private T GetDataFromList<T>(IEnumerable<object> list)
        {
            foreach (var control in list)
            {
                if (control is IInterfaceDataReceiver<T> receiver)
                {
                    return receiver.GetData();
                }
            }

            throw new Exception("User Control is not defined!");
        }
        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            Vehicle vehicle = GetDataFromList<Vehicle>(AdditionFields.Children.Cast<UIElement>());

            Bus bus = (Bus)vehicle;
        }

        private void TypeOfVehicle_Selected(object sender, SelectionChangedEventArgs e)
        {
            AdditionFields.Children.Clear();
            selectedDelegates[TypeOfVehicle.SelectedIndex].Invoke();
        }


    }
}