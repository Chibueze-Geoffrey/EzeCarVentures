using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EzeCarVentures.Models
{
    public interface IOrderRepo
    {
      public  void CreateOrder(Order order);
    }
}
