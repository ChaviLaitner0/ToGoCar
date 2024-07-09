using project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bl.BlApi
{
   public interface IBlCars
    {
        public BlCar Add(BlCar cars);
        public BlCar Update(BlCar cars);
        public BlCar GatById(string carNumber);
        public BlCar Delet(string carNumber);
        public List<BlCar> GatAll();

    }
}
