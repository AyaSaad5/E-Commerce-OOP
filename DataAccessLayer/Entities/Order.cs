using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public OrderDetails orderDetails { get; set; }
        public ShoppingCart cart { get; set; }
        public DateTime orderCreatedDateTime { get; set; }
        public DateTime predictedOrderDeliveryDateTime { get; set; }
        public OrderStatus orderStatus { get; set; }
        public Carrier carrier { get; set; }
    }
}
