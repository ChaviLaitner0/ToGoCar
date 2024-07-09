using Bl.BlServices;
using Bl;
using Microsoft.AspNetCore.Mvc;
using project.Models;
using Dal.Models;

namespace ToGoCar.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        BlCarsServices blCarsServices;
        public CarController(BlManager manager)
        {
            this.blCarsServices = manager.blCarsServices;
        }

        [HttpGet]
        public ActionResult<List<BlCar>> GetAll()
        {
            return blCarsServices.GatAll();
        }

        [HttpPost]

        public ActionResult<BlCar> Add(BlCar Car)
        {
            return blCarsServices.Add(Car);
        }

        [HttpGet("{ID}")]
        public ActionResult<BlCar> GetById(string carNumber)
        {
            return blCarsServices.GatById(carNumber);
        }

        [HttpPut("{ID}")]
        public ActionResult<BlCar> Update(BlCar car)
        {
            return blCarsServices.Update(car);
        }
    }
}

