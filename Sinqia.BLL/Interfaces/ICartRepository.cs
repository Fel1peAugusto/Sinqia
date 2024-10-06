using Sinqia.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinqia.BLL.Interfaces
{
    public interface ICartRepository
    {
        Cart GetShoppingCart();

        void AddProduct(string product);

        void RemoveProduct(string product);
    }
}
