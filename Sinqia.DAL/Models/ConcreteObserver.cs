using Sinqia.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinqia.DAL.Models
{
    public class ConcreteObserver : IObserver
    {
        //Observer
        public string _observerName;

        public ConcreteObserver(string observerName)
        {
            _observerName = observerName;
        }

        public string Update(string product)
        {
            return $"Observer {_observerName} receive a update about a product: {product}";
        }
    }
}
 