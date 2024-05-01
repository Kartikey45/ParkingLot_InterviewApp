using ParkingLotDemoApp.Models;

namespace ParkingLotDemoApp.Services
{
    public interface IParkingLotManagement
    {
        void InitializeParkingLot(int totalSlots, string vehicalType);
        (bool, int) CheckSlot();
        bool Park(string vehicalType , string vehicalName);
        bool UnPark(string vehicalType , string vehicalName);

    }
}
