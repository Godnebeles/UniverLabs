﻿using System;
using System.Collections;
using System.Collections.Generic;

namespace sale_of_vehicles
{
    public class VehiclesShop
    {
        private List<Vehicle> _vehicleList;     

        public VehiclesShop(List<Vehicle> cars)
        {
            if (cars == null)
                throw new Exception("Car list can't be a null");

            _vehicleList = cars;
        }

        public List<Vehicle> VehicleList
        {
            get
            {
                return _vehicleList;
            }
            private set
            {
                _vehicleList = value;
            }
        }

        public void AddVehicle(Vehicle car)
        {
            VehicleList.Add(car);
        }

        public void RemoveVehicle(Vehicle car)
        {
            VehicleList.Remove(car);
        }

        public List<Vehicle> GetVehiclesByFilters(List<FilterCarsDelegate> filterCars)
        {
            List<Vehicle> list = new List<Vehicle>();

            foreach (var vehicle in VehicleList)
            {
                bool canToAdd = false;

                foreach(var method in filterCars)
                {
                    canToAdd = method(vehicle);
                    if (!canToAdd)
                        break;
                }

                if(canToAdd)
                    list.Add(vehicle);
            }

            return list;
        }

        public List<Bus> GetBuses()
        {
            List<Bus> buses = new List<Bus>();

            foreach (var vehicle in VehicleList)
            {
                if (vehicle.CheckFunctionality() && vehicle is Bus)
                {
                    buses.Add((Bus)vehicle);
                }
            }

            return buses;
        }

        public List<Plane> GetPlanes()
        {
            List<Plane> buses = new List<Plane>();

            foreach (var vehicle in VehicleList)
            {
                if (vehicle.CheckFunctionality() && vehicle is Plane)
                {
                    buses.Add((Plane)vehicle);
                }
            }

            return buses;
        }

        public List<Truck> GetTrucks()
        {
            List<Truck> truck = new List<Truck>();

            foreach (var vehicle in VehicleList)
            {
                if (vehicle.CheckFunctionality() && vehicle is Truck)
                {
                    truck.Add((Truck)vehicle);
                }
            }

            return truck;
        }

        public List<PassengerPlane> GetPassengerPlanes()
        {
            List<PassengerPlane> truck = new List<PassengerPlane>();

            foreach (var vehicle in VehicleList)
            {
                if (vehicle.CheckFunctionality() && vehicle is PassengerPlane)
                {
                    truck.Add((PassengerPlane)vehicle);
                }
            }

            return truck;
        }

        public List<TransportPlane> GetTransportPlanes()
        {
            List<TransportPlane> truck = new List<TransportPlane>();

            foreach (var vehicle in VehicleList)
            {
                if (vehicle.CheckFunctionality() && vehicle is TransportPlane)
                {
                    truck.Add((TransportPlane)vehicle);
                }
            }

            return truck;
        }
    }

}
