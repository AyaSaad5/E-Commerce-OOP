using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogicLayer.Interfaces;
using BusinessLogicLayer.Repositories;
using DataAccessLayer.Entities;

namespace PresintationLayer
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericRepository<Customer> cust = new GenericRepository<Customer>();
            Customer c = new Customer
            {
                Id = 1,
                Name = "Aya",
                PhoneNumber = "01025190810",
                Address = "Mansoura"
            };
            cust.Add(c);
            
            foreach (var customer in cust.GetAll())
            {
                Console.WriteLine($"Id = {customer.Id} Name = {customer.Name} PhoneNumber = {customer.PhoneNumber}" +
                    $" Address = {customer.Address}");
            }
            Customer c1 = new Customer
            {
                Id = 2,
                Name = "Ziad",
                PhoneNumber = "01025190810",
                Address = "MG"
            };
            cust.Add(c1);

            cust.Delete(c);
            Console.WriteLine("After Delete");
            foreach (var customer in cust.GetAll())
            {
                Console.WriteLine($"Id = {customer.Id} Name = {customer.Name} ");
            }

            CustomerRepos customerrepo = new CustomerRepos();
            List<Customer> customers = customerrepo.GetAll();

            Console.WriteLine("After Updated ");
            c1.Name = "Taha";
            c1.PhoneNumber = "01023456778";
            c1.Address = "MG";
            customerrepo.Update(customers,c1);
            foreach (var item in cust.GetAll())
            {
                Console.WriteLine($"Id = {item.Id} Name = {item.Name} ");
            }

            /*BrandRepos brandrepo = new BrandRepos();
            List<Brand> brands = brandrepo.GetAll();*/

            //cartproduct

            Customer c3 = new Customer
            {
                Id = 4,
                Name = "Doha",
                PhoneNumber = "01025190810",
                Address = "Dekrnes"
            };
            ShoppingCart cart = new ShoppingCart
            {
                Id = 1,
                CustomerId = 4,
                Items = new List<CartProduct>()
                {
                    new CartProduct()
                    {
                        Id = 1,
                        Name ="shoes",
                        Price= 300
                    }
                }
            };
            ShoppingCartRepos shopingcartrepo = new ShoppingCartRepos();
            shopingcartrepo.Add(cart);

            List<ShoppingCart> CartList = shopingcartrepo.GetAll();

            // product that i want to add
            CartProduct prod = new CartProduct()
            {
                Id = 5,
                Name = "Dress",
                Price = 500
            };
            shopingcartrepo.AddToCart(CartList, cart.Id, c3.Id, prod);

            foreach (var item in cart.Items)
            {
                Console.WriteLine($" ID {item.Id} Price {item.Price} Name {item.Name} Count {item.Count}");
            }


            //make order
            Order order = new Order()
            {
                Id = 5,
                orderCreatedDateTime = DateTime.Now,
                predictedOrderDeliveryDateTime = new DateTime(2023, 12, 1),
                orderStatus = OrderStatus.processing,
                cart = cart,
                orderDetails = new OrderDetails()
                {
                    CustomerName = "Doha",
                    CustomerNumber = "010234567",
                    Country = "Daqahlia",
                    PostalCode = "23456"
                },
                carrier = new Carrier()
                {
                    Id = 1,
                    Name = "Ahmed",
                    PhoneNumber = "0123345578",
                    Address = "Cairo"
                }
            };

            OrderRepos orderepos = new OrderRepos();
            orderepos.Add(order);
            double price = orderepos.TotalPrice(cart);

            List<Order> orderlist = orderepos.GetAll();
            foreach (var item in orderlist)
            {
                Console.WriteLine($"ID Product {item.Id} Orderstatus {item.orderStatus} " +
                    $" CustomerName {item.orderDetails.CustomerName} DeliveryMan {item.carrier.Name}");
            }
            Console.ReadLine();
        }
    }
}
