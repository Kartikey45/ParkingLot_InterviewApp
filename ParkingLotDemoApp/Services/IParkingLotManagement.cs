using ParkingLotDemoApp.Models;

namespace ParkingLotDemoApp.Services
{
    public interface IParkingLotManagement
    {
        VehicalDetail[] Details();
        (VehicalDetail[], int) InitializeParkingLot(int totalSlots);
        (bool, int) Park(VehicalDetail vehicle);
        bool UnPark(int ticketNumber);

    }
}
