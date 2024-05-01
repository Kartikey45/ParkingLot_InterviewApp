using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ParkingLotDemoApp.Models;
using ParkingLotDemoApp.Services;

namespace ParkingLotDemoApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParkingLotController : ControllerBase
    {
        private readonly IParkingLotManagement _parkingLotManagement;
        public ParkingLotController(IParkingLotManagement parkingLotManagement) {
            _parkingLotManagement = parkingLotManagement;
        }

        [HttpGet]
        public IActionResult ParkingDetails() {
            var _parking = Parking.Vehicles;
            return Ok(_parking);
        }

       /* [HttpPost]
        public IActionResult InitializeParking([FromBody] CommonModel commonModel, [])
        {
            return Ok();
        }*/



    }
}
