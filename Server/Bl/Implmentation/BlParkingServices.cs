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
    public class BlParkingServices: IBlParking
    {
        DalParkingServices _Parkings;

        public BlParkingServices(DalManger manger)
        {
            this._Parkings = manger.dalParkingServices;
        }


        public BlParking Add(BlParking parking)
        {
            Parking p = new Parking();
            p.Street = parking.Street;
            p.City = parking.City;
            p.ParkingNumber = parking.ParkingNumber;
            p.PostalCode = parking.PostalCode;
            _Parkings.Add(p);
            return parking;
          
        }


        public List<BlParking> GatAll()
        {
            List<Parking> list = _Parkings.GetAll();
            List<BlParking> result = new List<BlParking>();
            for (int i = 0; i < list.Count; i++)
            {
                result.Add(new BlParking(list[i].ParkingNumber,list[i].City, list[i].Street, list[i].PostalCode ));
            }
            return result;

        }

        public BlParking Delet(int parkingNumber)
        {
            Parking p = _Parkings.Delet(parkingNumber);
            return new BlParking() { ParkingNumber = p.ParkingNumber };
        }

        public BlParking GatById(int parkingNumber)
        {

            Parking p = _Parkings.GetById(parkingNumber);
            if (p == null)
                return null;
            BlParking Parking = new BlParking(p.ParkingNumber,p.Street,p.City,p.PostalCode);
            return Parking;
        }

        public BlParking Update(BlParking parking)
        {
            Parking p = new Parking();
            p.Street = parking.Street;
            p.City = parking.City;
            p.PostalCode = parking.PostalCode;
            _Parkings.Update(p);
            return parking;
        }
    }
}
