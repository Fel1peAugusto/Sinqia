using Microsoft.AspNetCore.Mvc;
using Sinqia.BLL.Interfaces;
using Sinqia.BLL.Repository;
using Sinqia.DAL.Models;
using Swashbuckle.AspNetCore.Annotations;

namespace Sinqia.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CartController
    {
        //Dependecy Injection Service
        private readonly ICartRepository _cartRepository;

        public CartController(ICartRepository cartRepository)   
        {
            _cartRepository = cartRepository;
        } 


        [HttpGet(Name = "GetShoppingCart")]
        [SwaggerOperation(Description = "Return a unique Cart to shopping", Summary = "GetShoppingCart")]
        public string GetShoppingCart()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(_cartRepository.GetShoppingCart());
        }

        [SwaggerOperation(Description = "Add products to a Cart to shopping")]
        [HttpPost("AddProductsToCart/{product}")]
        public string AddProductsToCart(string product)
        {
            if (!Cart.GetInstance.Products.Contains(product))
            {
                _cartRepository.AddProduct(product);
                return Cart.GetInstance.NotifyObservers(product);
            }
            return product + " allready included at the Cart";
        }

        [SwaggerOperation(Description = "Remove product from Cart")]
        [HttpPost("RemoveProductsToCart/{product}")]
        public string RemoveProductsToCart(string product)
        {
            if (Cart.GetInstance.Products.Contains(product))
            {
                _cartRepository.RemoveProduct(product);
                return Cart.GetInstance.NotifyObservers(product);
            }
            return product + " does not exists in the Cart";        
        }


        [SwaggerOperation(Description = "Add a observer to be notified of a change in the Cart")]
        [HttpPost("RegisterObserver/{name}")]
        public void RegisterObserver(string name)
        {
            Cart.GetInstance.RegisterObserver(new ConcreteObserver(name));
        }

        [SwaggerOperation(Description = "Remove a observer to not be notified of a change in the Cart")]
        [HttpPost("RemoveObserver/{name}")]
        public void RemoveObserver(string name)
        {
            Cart.GetInstance.RemoveObserver(name);
        }
    }
}
