using project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bl.BlApi
{
    public interface IBlParking
    {
        public BlParking Add(BlParking parking);
        public List<BlParking> GatAll();
        public BlParking Delet(int parkingNumber);
        public BlParking GatById(int parkingNumber);
        public BlParking Update(BlParking parking);
    }
}
