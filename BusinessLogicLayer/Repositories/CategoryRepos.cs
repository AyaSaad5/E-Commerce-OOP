using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Entities;

namespace BusinessLogicLayer.Repositories
{
    public class CategoryRepos:GenericRepository<Category>
    {
        public void Update(List<Category> categories, Category category)
        {
            foreach (var cat in categories)
            {
                if (cat.Id == category.Id)
                {
                    if (category.Name != null)
                        cat.Name = category.Name;
                }
            }
        }
    }
}
