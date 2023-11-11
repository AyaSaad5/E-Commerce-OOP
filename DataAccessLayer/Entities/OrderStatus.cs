using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities
{
   public enum OrderStatus
    {
        processing = 1, shipped = 2, paid = 3, cancelled = 4 
    }
}
