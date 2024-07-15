using Dal.DalApi;
using Dal.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.DalServices
{
    public class DalSubscribersServices : IDalSubscribers
    {
        BridalContext _GoToContext;
        public DalSubscribersServices(BridalContext _goToContext) 
        {
           this._GoToContext = _goToContext;
        }




        public Subscriber Add(Subscriber subscriber)
        {
           
            _GoToContext.Subscribers.Add(subscriber);
            _GoToContext.SaveChanges();
            return subscriber;

        }

 

        public void DeletSubscribers(Subscriber subscriber)
        {
            _GoToContext.Subscribers.Remove(subscriber);
            _GoToContext.SaveChanges();
        }


        public List<Subscriber> GetAll()
        {
          return _GoToContext.Subscribers.ToList();
        }
        public Subscriber GetById(string id)
        {
            try
            {
            return _GoToContext.Subscribers.FirstOrDefault(x => x.Id == id);
              
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

  


        public Subscriber Update(Subscriber subscriber)
        {
           foreach (Subscriber s in _GoToContext.Subscribers.ToList())
            {
                if(s.Id == subscriber.Id)
                {
                    s.Phone = subscriber.Phone;
                    break;

                }
            }
            _GoToContext.SaveChanges();
            return subscriber;
            
        }


    }
}
