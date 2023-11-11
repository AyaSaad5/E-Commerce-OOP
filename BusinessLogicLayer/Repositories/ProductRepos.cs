using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Entities;

namespace BusinessLogicLayer.Repositories
{
    public class ProductRepos:GenericRepository<Product>
    {
        public void Update(List<Product> products, Product product)
        {
            foreach (var prod in products)
            {
                if (prod.Id == product.Id)
                {
                    if (product.Name != null)
                    {
                        prod.Name = product.Name;
                        if (product.Price != 0)
                            prod.Price = product.Price;
                    }
                }
            }
        }
    }
}
