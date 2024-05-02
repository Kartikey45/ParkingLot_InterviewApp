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

        [Route("ParkingDetails")]
        [HttpGet]
        public IActionResult ParkingDetails() {
            var details = _parkingLotManagement.Details();
            if(details == null)
            {
                return NotFound("Parking is empty !");
            }
            return Ok(details);
        }

        [Route("InitializeParking")]
        [HttpPost]
        public IActionResult InitializeParking([FromBody] int size)
        {
            (var _data, int _size) = _parkingLotManagement.InitializeParkingLot(size);
            return Ok($"Total {_size} slots created in the Parking");
        }

        [Route("Park")]
        [HttpPost]
        public IActionResult Park([FromBody] VehicalDetail Vehical)
        {
            (bool isParked, int ticketNumber) = _parkingLotManagement.Park(Vehical);
            if(isParked)
            {
                return Ok("Vehical Parked in the parking");
            }
            else
            {
                return Ok("Vehicle was unable to Park");
            }
        }

        [Route("UnPark")]
        [HttpPost]
        public IActionResult UnPark([FromBody] int TicketNumber)
        {
            bool isUnParked = _parkingLotManagement.UnPark(TicketNumber);
            if (isUnParked)
            {
                return Ok("Vehical Unparked in the parking");
            }
            else
            {
                return Ok("Vehicle was unable to Unparked");
            }
        }


    }
}
