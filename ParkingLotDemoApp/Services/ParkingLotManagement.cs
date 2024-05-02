using ParkingLotDemoApp.Models;

namespace ParkingLotDemoApp.Services
{
    public class ParkingLotManagement : IParkingLotManagement
    {
        public ParkingLotManagement()
        {

        }


        public VehicalDetail[] Details()
        {
            var _parking = Parking.Vehicles;
            return _parking;
        }

        public (VehicalDetail[], int) InitializeParkingLot(int totalSlots)
        {
            return (Parking.Vehicles = new VehicalDetail[totalSlots], totalSlots);
        }

        public (bool, int) Park(VehicalDetail vehicle)
        {
            (bool isAvailable, int slot) = CheckSlot();
            if (isAvailable)
            {
                vehicle.TicketNumber = slot;
                Parking.Vehicles[slot] = vehicle;
                return (true, vehicle.TicketNumber);
            }
            return (false, 0);
        }

        public bool UnPark(int ticketNumber)
        {
            bool isUnparked = false;
            int totalSlots = Parking.Vehicles.Count();
            for(int slot = 0; slot < totalSlots; slot++)
            {
                if (Parking.Vehicles[slot].TicketNumber == ticketNumber)
                {
                    Parking.Vehicles[slot] = null;
                    isUnparked = true;
                }
            }
            return isUnparked;
        }

        private (bool, int) CheckSlot()
        {
            int _totalSlots = Parking.Vehicles.Count();
            if (_totalSlots == 0)
            {
                return (false, 0);
            }
            for (int slot = 0; slot < _totalSlots; slot++)
            {
                if (Parking.Vehicles[slot] == null)
                {
                    return (true, slot);
                }
            }
            return (false, 0);
        }

    }
}
