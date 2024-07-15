using Dal.DalApi;
using Dal.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.DalServices
{
    public class DalCarsServices: IDalCars
    {
        BridalContext _GoToContext;
        public DalCarsServices(BridalContext _goToContext)
        {
            this._GoToContext = _goToContext;
        }




        public Car Add(Car car)
        {

            _GoToContext.Cars.Add(car);
            _GoToContext.SaveChanges();
            return car;

        }

 

        public Car Delet(string carNumber)
        {
            try
            {
                var carToDelete = _GoToContext.Cars.Where(c => c.CarNumber== carNumber).FirstOrDefault();
                _GoToContext.Cars.Remove(carToDelete);
                _GoToContext.SaveChanges();
                return carToDelete;
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                throw new Exception($"Error in deleting car {carNumber} data");
            }
            
        }

        public List<Car> GetAll()
        {
            return _GoToContext.Cars.ToList();
        }

        //public List<Car> GetAll()
        //{
        //    return _GoToContext.Cars.ToList();
        //}
        public Car GetById(string carNumber)
        {
            try
            {
                return _GoToContext.Cars.Where(x => x.CarNumber == carNumber).FirstOrDefault();

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                throw new Exception($"Error in getting single Gown {carNumber} data");
            }
        }
        public BridalContext GetContext()
        {
            return _GoToContext;
        }




        public Car Update(Car car)
        {
            foreach (Car c in _GoToContext.Cars.ToList())
            {
                if (c.CarNumber == car.CarNumber)
                {
                    c.Amount = car.Amount;
                    c.ParkingNumber = c.ParkingNumber;
                    break;

                }
            }
            _GoToContext.SaveChanges();
            return car;

        }
    }
}
