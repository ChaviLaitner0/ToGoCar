using Dal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.DalApi
{
    public interface IDalCars
    {
        public List<Car> GetAll();
        public Car GetById(string carNumber);
        public Car Add(Car car);
        public Car Delet(string carNumber);
    }
}

