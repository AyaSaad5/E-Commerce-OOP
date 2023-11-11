using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Entities;

namespace BusinessLogicLayer.Interfaces
{
    interface IGenaricInterface<T>
    {
         void Add(T T);
         void Delete(T T);
         List<T> GetAll();
    }
}
