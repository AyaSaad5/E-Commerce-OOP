using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Entities;


namespace BusinessLogicLayer.Repositories
{
    public class BrandRepos:GenericRepository<Brand>
    {
        public void Update(List<Brand> brands, Brand brand)
        {
            foreach (var b in brands)
            {
                if (b.Id == brand.Id)
                {
                    if (brand.Name != null)
                        b.Name = brand.Name;
                }
            }
        }
    }
}
