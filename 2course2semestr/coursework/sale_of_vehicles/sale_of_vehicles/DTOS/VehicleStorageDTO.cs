using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sale_of_vehicles
{
    public class VehicleStorageDTO
    {
        public List<BusDTO> Buses { get; set; }
        public List<TruckDTO> Trucks { get; set; }
        public List<PassengerPlaneDTO> PassengerPlanes { get; set; }
        public List<TransportPlaneDTO> TransportPlanes { get; set; }

        public VehicleStorageDTO()
        {
            Buses = new List<BusDTO>();
            Trucks = new List<TruckDTO>();
            PassengerPlanes = new List<PassengerPlaneDTO>();
            TransportPlanes = new List<TransportPlaneDTO>();
        }

        public void AddVehicle(Vehicle vehicle)
        {
            IDataConvertor<Bus, BusDTO> busAdapter = new BusDataConvertor();
            IDataConvertor<Truck, TruckDTO> truckAdapter = new TruckDataConvertor();
            IDataConvertor<PassengerPlane, PassengerPlaneDTO> passengerPlaneAdapter = new PassengerDataConvertor();
            IDataConvertor<TransportPlane, TransportPlaneDTO> transportPlaneAdapter = new TransportDataConvertor();


            if (vehicle is Bus)
                Buses.Add(busAdapter.ConvertToDTO((Bus)vehicle));
            else if (vehicle is Truck)
                Trucks.Add(truckAdapter.ConvertToDTO((Truck)vehicle));
            else if (vehicle is PassengerPlane)
                PassengerPlanes.Add(passengerPlaneAdapter.ConvertToDTO((PassengerPlane)vehicle));
            else if (vehicle is TransportPlane)
                TransportPlanes.Add(transportPlaneAdapter.ConvertToDTO((TransportPlane)vehicle));

        }
    }
}
