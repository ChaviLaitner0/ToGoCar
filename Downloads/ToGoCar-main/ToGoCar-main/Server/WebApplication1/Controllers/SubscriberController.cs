using Microsoft.AspNetCore.Mvc;
using Bl.BlServices;
using Bl;
using project.Models;
using Bl.BlApi;

namespace Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubscriberController : ControllerBase
    {
        BlSubscribersServices blSubscribersServices;
        public SubscriberController(BlManager manager)
        {
            this.blSubscribersServices = manager.blSubscribersServices;
        }

        [HttpGet]
        public ActionResult<List<BlSubscriber>> GetAll()
        {
            return blSubscribersServices.GatAll();
        }

        [HttpPost]

        public ActionResult<BlSubscriber> Add(BlSubscriber Subscriber)
        {
            return blSubscribersServices.Add(Subscriber);
        }

        [HttpPost("login")]
        public ActionResult Login(string id)
        {
            var subscriber = blSubscribersServices.GatById(id);
            if (subscriber == null)
            {
                return NotFound("Subscriber does not exist. Please register.");
            }
            return Ok(subscriber);
        }

        public class CheckSubscriberRequest
        {
            public string Id { get; set; }
        }

        [HttpPost("check")]
        public ActionResult<bool> CheckIfExists([FromBody] CheckSubscriberRequest request)
        {
            var exists = blSubscribersServices.GatById(request.Id) != null;
            return Ok(exists);
        }

        [HttpGet ("{ID}")]
        public ActionResult<BlSubscriber> GetById(string ID)
        {
            return blSubscribersServices.GatById(ID);
        }

        [HttpPut("{ID}")]
        public ActionResult<BlSubscriber> Update(BlSubscriber subscriber)
        {
            return blSubscribersServices.Update(subscriber);
        }
    }
}
