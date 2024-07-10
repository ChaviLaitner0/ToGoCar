using project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bl.BlApi
{
    public interface IBlRentals
    {
        public BlRental Update(BlRental rental);
        public BlRental GatById(int id);
        public BlRental Delet(int id);
        public List<BlRental> GatAll();
        public BlRental Add(BlRental Rentals);

    }
}
