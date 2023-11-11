using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogicLayer.Interfaces;
using DataAccessLayer.Entities;

namespace BusinessLogicLayer.Repositories
{
    public class GenericRepository<T> : IGenaricInterface<T>
    {
        List<T> item = new List<T>();
        public void Add(T T)
        {
            item.Add(T);
        }
        public void Delete(T T)
        {
            item.Remove(T);
        }
        public List<T> GetAll()
        {
            return item;
        }
    }
}
