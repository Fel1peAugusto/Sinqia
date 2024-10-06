using Sinqia.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinqia.DAL.Models
{

    public class Cart
    {
        private static Cart ShoppingCart;
        public List<IObserver> _observers = new List<IObserver>();
        public List<string> Products;
        private Cart()
        {
            Products = new List<string>();
        }
        //Singleton
        public static Cart GetInstance
        {
            get
            {
                if (ShoppingCart == null)
                    ShoppingCart = new();

                return ShoppingCart;
            }
        }

        public void AddProduct(string product)
        {
            this.Products.Add(product);


        }
        public void RemovedProduct(string product)
        {
            this.Products.Remove(product);

        }

        public string NotifyObservers(string product)
        {
            string notify = string.Empty;
            foreach (IObserver observer in _observers)
            {
                notify += observer.Update(product) + "\n";
            }
            return notify;

        }
        public void RegisterObserver(IObserver observerName)
        {
            _observers.Add(observerName);
        }

        public void RemoveObserver(string observerName)
        {
            var toRemove = new ConcreteObserver(string.Empty);
            _observers.ForEach(c =>
            {
                var x = (ConcreteObserver)c;
                if (x._observerName == observerName)
                    toRemove = x;
            });

            _observers.Remove(toRemove);
        }
    }
}