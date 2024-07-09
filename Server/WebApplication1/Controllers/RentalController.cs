using Bl.BlServices;
using Bl;
using Microsoft.AspNetCore.Mvc;
using project.Models;
using Dal.Models;

namespace ToGoCar.Controllers
{
   
        [Route("api/[controller]")]
        [ApiController]
        public class RentalController : ControllerBase
        {
            BlRentalsServices blRentalsServices;
            public RentalController(BlManager manager)
            {
                this.blRentalsServices = manager.blRentalsServices;
            }

            [HttpGet]
            public ActionResult<List<BlRental>> GetAll()
            {
                return blRentalsServices.GatAll();
            }

            [HttpPost]

            public ActionResult<BlRental> Add(BlRental Rental)
            {
                return blRentalsServices.Add(Rental);
            }

            [HttpGet("{ID}")]
            public ActionResult<BlRental> GetById(int ID)
            {
                return blRentalsServices.GatById(ID);
            }

            [HttpPut("{ID}")]
            public ActionResult<BlRental> Update(BlRental rental)
            {
                return blRentalsServices.Update(rental);
            }
        }
}
