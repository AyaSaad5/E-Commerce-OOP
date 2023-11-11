using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Entities;

namespace BusinessLogicLayer.Repositories
{
    public class OrderRepos : GenericRepository<Order>
    {
        double price = 0;
        public double TotalPrice(ShoppingCart orders)
        {
            foreach (var order in orders.Items)
            {
                    price += (double)order.Count * order.Price;
            }
            return price;
        }

    }
}
