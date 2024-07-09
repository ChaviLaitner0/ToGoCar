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
