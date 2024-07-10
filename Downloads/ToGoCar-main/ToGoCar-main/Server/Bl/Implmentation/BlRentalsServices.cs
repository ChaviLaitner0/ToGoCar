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
    public class BlRentalsServices: IBlRentals
    {
        DalRentalsServices _Rentals;

        public BlRentalsServices(DalManger manger)
        {
            this._Rentals = manger.dalRentalsServices;
        }


        public BlRental Add(BlRental Rentals)
        {
            Rental r = new Rental();
            r.IdSubscriber = Rentals.IdSubscriber;
            r.CarNumber= Rentals.CarNumber;
            r.Routess= Rentals.Routess;
            r.Amount= Rentals.Amount;
            r.Km= Rentals.Km;

            _Rentals.Add(r);
            return Rentals;
        }


        public List<BlRental> GatAll()
        {
            List<Rental> list = _Rentals.GetAll();
            List<BlRental> result = new List<BlRental>();
            for (int i = 0; i < list.Count; i++)
            {
                result.Add(new BlRental(list[i].Id, list[i].IdSubscriber, list[i].CarNumber, list[i].Routess, list[i].Amount, list[i].Km));
            }
            return result;

        }

        public BlRental Delet(int id)
        {
            Rental r = _Rentals.Delet(id);
            return new BlRental() {Id = r.Id };
        }

        public BlRental GatById(int id)
        {

            Rental r = _Rentals.GetById(id);
            if (r == null)
                return null;
            BlRental rental = new BlRental(r.Id,r.IdSubscriber,r.Routess,r.CarNumber,r.Amount,r.Km);
            return rental;
        }

        public BlRental Update(BlRental rental)
        {
            Rental r= new Rental();
            r.Id = rental.Id;
            r.IdSubscriber = rental.IdSubscriber;
            r.Routess = rental.Routess;
            r.CarNumber = rental.CarNumber;
            r.Amount = rental.Amount;
            r.Km = rental.Km;
            _Rentals.Update(r);
            return rental;
        }

    }
}
