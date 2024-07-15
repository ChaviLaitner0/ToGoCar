using Bl.BlApi;
using Dal.DalServices;
using Dal.Models;
using Dal;
using project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Bl.BlServices
{
   public class BlCarsServices: IBlCars
    {
        DalCarsServices _Cars;

        public BlCarsServices(DalManger manger)
        {
            this._Cars = manger.dalCarsServices;
        }


        public BlCar Add(BlCar cars)
        {
            Car c = new Car();
            c.CarNumber = cars.CarNumber;
            c.ParkingNumber= cars.ParkingNumber;
            c.Model=cars.Model; 
            c.Amount=cars.Amount;
            c.CarType = cars.CarType;
            _Cars.Add(c);
            return cars;
        }

        public List<BlCar> GatAll()
        {
            List<Car> list = _Cars.GetAll();
            List<BlCar> result = new List<BlCar>();
            for (int i = 0; i < list.Count; i++)
            {
                result.Add(new BlCar(list[i].CarNumber, list[i].Model, list[i].CarType, list[i].ParkingNumber, list[i].Amount));
            }
            return result;
        }


        //public List<BlCar> GatAll()
        //{
        //    List<Car> list = _Cars.GetAll();
        //    List<BlCar> result = new List<BlCar>();
        //    for (int i = 0; i < list.Count; i++)
        //    {
        //        result.Add(new BlCar(list[i].CarNumber, list[i].Model, list[i].CarType, list[i].ParkingNumber, list[i].Amount));
        //    }
        //    return result;
           
        //}

        public BlCar Delet(string carNumber)
        {
           Car c = _Cars.Delet(carNumber);
            return new BlCar() { CarNumber = c.CarNumber };
        }

        public BlCar GatById(string carNumber)
        {

            Car c = _Cars.GetById(carNumber);
            if (c == null)
                return null;
            BlCar car = new BlCar(c.Model,c.CarNumber,c.ParkingNumber,c.Amount,c.CarType);
            return car;
        }

        public BlCar Update(BlCar car)
        {
            Car c= new Car();
            c.Model = car.Model;
            c.CarNumber = car.CarNumber;
            c.ParkingNumber = car.ParkingNumber;
            c.Amount = car.Amount;
            c.CarType = car.CarType;
            _Cars.Update(c);
            return car;
        }

    }
}
