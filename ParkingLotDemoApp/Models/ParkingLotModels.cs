namespace ParkingLotDemoApp.Models
{
    public class ParkingLotModels
    {
    }

    public static class Parking
    {
        public static VehicalDetail[] Vehicles { get; set; } = new VehicalDetail[0];
    }

    public class VehicalDetail
    {
        public string VehicalName { get; set; }
        public string VehicalNumber { get; set; }
        public string VehicalType { get; set; }
        public int TicketNumber { get; set; }
    }

    /*public class ParkingModel
    {
        public VehicalDetail[] Vehicles { get; set; } = new VehicalDetail[0];
    }*/

   

}
