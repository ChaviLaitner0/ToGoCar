using Dal.DalApi;
using Dal.DalServices;
using Dal.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.DalServices
{
    public class DalRentalsServices : IDalRentals
    {
        BridalContext _GoToContext;
        public DalRentalsServices(BridalContext _goToContext)
        {
            this._GoToContext = _goToContext;
        }

        public Rental Add(Rental rental)
        {

            _GoToContext.Rentals.Add(rental);
            _GoToContext.SaveChanges();
            return rental;

        }

        public Rental Delet (int id )
        {
            try
            {
                var rentalToDelete = _GoToContext.Rentals.Where(c => c.Id == id).FirstOrDefault();
                _GoToContext.Rentals.Remove(rentalToDelete);
                _GoToContext.SaveChanges();
                return rentalToDelete;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                throw new Exception($"Error in deleting car {id} data");
            }

        }

        public List<Rental> GetAll()
        {
            return _GoToContext.Rentals.ToList();
        }
        public Rental GetById(int id)
        {
            try
            {
                return _GoToContext.Rentals.Where(x => x.Id == id).FirstOrDefault();

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                throw new Exception($"Error in getting single Gown {id} data");
            }
        }
        public BridalContext GetContext()
        {
            return _GoToContext;
        }




        public Rental Update(Rental rental)
        {
            foreach (Rental r in _GoToContext.Rentals.ToList())
            {
                if (r.Id == rental.Id)
                {
                    r.Routess = rental.Routess;
                    r.CarNumber = rental.CarNumber;
                    r.Km= rental.Km;
                    r.Amount = rental.Amount;
                    break;
                }
            }
            _GoToContext.SaveChanges();
            return rental;
        }

    }
}
