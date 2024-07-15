using Dal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.DalApi
{
    public interface IDalRentals
    {
        public Rental Update(Rental rental);
        public BridalContext GetContext();
        public List<Rental> GetAll();
        public Rental Delet(int id);
        public Rental Add(Rental rental);
    }
}
