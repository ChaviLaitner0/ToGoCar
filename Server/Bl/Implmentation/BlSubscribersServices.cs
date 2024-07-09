using Bl.BlApi;
using Dal;
using Dal.DalApi;
using Dal.DalServices;
using Dal.Models;
using project;
using project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bl.BlServices
{
    public class BlSubscribersServices: IBlSubscribers
    {
        DalSubscribersServices _dalSubscribers;

       public BlSubscribersServices (DalManger manger)
        {
           this._dalSubscribers = manger.dalSubscribersServices;
        }

        public List<BlSubscriber> Read()
        {
            throw new NotImplementedException();
        }

        public BlSubscriber Add(BlSubscriber subscriber)
        {
            Subscriber s = new Subscriber();
            s.Id = subscriber.Id;
            s.Age = subscriber.Age;
            s.FirstName = subscriber.FirstName;
            s.LastName = subscriber.LastName;
            s.Phone = subscriber.Phone;
            s.LicenseNumber = subscriber.LicenseNumber;
            _dalSubscribers.Add(s);
            return subscriber;
        }

     
        public List<BlSubscriber> GatAll()
        {
            List<Subscriber> list = _dalSubscribers.GetAll();
            List<BlSubscriber> result= new List<BlSubscriber>();
            for(int i=0; i<list.Count; i++)
            {
                result.Add(new BlSubscriber(list[i].Id, list[i].Age, list[i].FirstName, list[i].LastName,list[i].Phone, list[i].LicenseNumber)) ;
            }
            return result;
        }



        public BlSubscriber GatById(string id)
        {
            Subscriber s= _dalSubscribers.GetById(id);
            if (s == null)
                return null;
            BlSubscriber subscriber=new BlSubscriber(s.Id,s.Age,s.FirstName,s.LastName,s.Phone,s.LicenseNumber);    
            return subscriber;
        }

        public BlSubscriber Update(BlSubscriber subscriber)
        {
            Subscriber s = new Subscriber();
            s.Id = subscriber.Id;
            s.Age = subscriber.Age;
            s.FirstName = subscriber.FirstName;
            s.LastName = subscriber.LastName;
           s.Phone = subscriber.Phone;
            s.LicenseNumber = subscriber.LicenseNumber;
            _dalSubscribers.Update(s);
            return subscriber;
        }



    }
}
