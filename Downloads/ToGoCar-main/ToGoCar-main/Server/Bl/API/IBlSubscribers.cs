using Bl.BlServices;
using project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bl.BlApi
{
    public interface IBlSubscribers

    {
        public List<BlSubscriber> GatAll();
        public BlSubscriber GatById(string id);
        public BlSubscriber Add(BlSubscriber subscriber);
        public BlSubscriber Update(BlSubscriber subscriber);

    }
}
