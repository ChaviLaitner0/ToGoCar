using Dal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.DalApi
{
    public interface IDalParking
    {
        public Parking Add(Parking Parking);
        public Parking Delet(int parkingNumber);
        public List<Parking> GetAll();
        public Parking Update(Parking parking);
    }
}
