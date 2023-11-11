using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Entities;

namespace BusinessLogicLayer.Repositories
{
    public class ShoppingCartRepos:GenericRepository<ShoppingCart>
    {
        //GenericRepository<Product> products = new GenericRepository<Product>();
        public void AddToCart(List<ShoppingCart>cart,int id, int customerid, CartProduct product)
        {
            foreach(var item in cart)
            {
                if(item.Id == id && item.CustomerId == customerid)
                {
                    item.Items.Add(product);
                }
            }
        }
        public void IncreaseCount(List<ShoppingCart> carts, int id, int customerid, int productid)
        {
            foreach (var cart in carts)
            {
                if (cart.Id == id && cart.CustomerId == customerid)
                {
                    foreach(var product in cart.Items)
                    {
                        if (product.Id == productid)
                            product.Count++;
                    }
                }
            }
        }
        public void DecreaseCount(List<ShoppingCart> carts, int id, int customerid, int productid)
        {
            foreach (var cart in carts)
            {
                if (cart.Id == id && cart.CustomerId == customerid)
                {
                    foreach (var product in cart.Items)
                    {
                        if (product.Id == productid)
                            product.Count--;
                    }
                }
            }
        }
    }
}
