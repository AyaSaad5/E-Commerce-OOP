using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Entities;
namespace BusinessLogicLayer.Repositories
{
    public class CustomerRepos:GenericRepository<Customer>
    {
        public void Update(List<Customer> customers, Customer customer)
        {
            foreach (var cust in customers)
            {
                if(cust.Id == customer.Id)
                {
                    if(customer.Name != null)
                    {
                        cust.Name = customer.Name;
                        if(customer.PhoneNumber != null)
                        {
                            cust.PhoneNumber = customer.PhoneNumber;
                            if (customer.Address != null)
                                cust.Address = customer.Address;
                        }
                    }
                }
            }
        }
    }
}
