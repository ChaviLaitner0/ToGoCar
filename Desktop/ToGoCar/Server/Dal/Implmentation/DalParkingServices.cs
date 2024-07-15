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
    public class DalParkingServices: IDalParking
    {
        BridalContext _GoToContext;
        public DalParkingServices(BridalContext _goToContext)
        {
            this._GoToContext = _goToContext;
        }




        public Parking Add(Parking Parking)
        {

            _GoToContext.Parkings.Add(Parking);
            _GoToContext.SaveChanges();
            return Parking;

        }



        public Parking Delet(int parkingNumber)
        {
            try
            {
                var ParkingToDelete = _GoToContext.Parkings.Where(c => c.ParkingNumber == parkingNumber).FirstOrDefault();
                _GoToContext.Parkings.Remove(ParkingToDelete);
                _GoToContext.SaveChanges();
                return ParkingToDelete;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                throw new Exception($"Error in deleting car {parkingNumber} data");
            }

        }


        public List<Parking> GetAll()
        {
            return _GoToContext.Parkings.ToList();
        }
        public Parking GetById(int parkingNumber)
        {
            try
            {
                return _GoToContext.Parkings.Where(x => x.ParkingNumber == parkingNumber).FirstOrDefault();

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                throw new Exception($"Error in getting single Gown {parkingNumber} data");
            }
        }
        public BridalContext GetContext()
        {
            return _GoToContext;
        }

        public Parking Update(Parking parking)
        {
            foreach (Parking p in _GoToContext.Parkings.ToList())
            {
                if (p.ParkingNumber == parking.ParkingNumber)
                {
                   p.City=parking.City;
                   p.Street=parking.Street;
                   p.ParkingNumber=parking.ParkingNumber;
                   break;
                }
            }
            _GoToContext.SaveChanges();
            return parking;

        }
    }
}
