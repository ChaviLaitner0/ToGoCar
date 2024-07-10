
using Dal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.DalApi
{
    public interface IDalSubscribers
    {

        public List<Subscriber> GetAll();
        public Subscriber GetById(string id);
        public Subscriber Add(Subscriber subscriber);
        public void DeletSubscribers(Subscriber subscriber);
    }
}
