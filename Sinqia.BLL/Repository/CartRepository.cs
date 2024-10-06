using Sinqia.BLL.Interfaces;
using Sinqia.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Sinqia.BLL.Repository
{
    public class CartRepository : ICartRepository
    {
        public void AddProduct(string product)
        {
            Cart.GetInstance.AddProduct(product);
        }

        public void RemoveProduct(string product)
        {

            Cart.GetInstance.RemovedProduct(product);

        }

        public Cart GetShoppingCart()
        {
            return Cart.GetInstance;
        }
    }
}