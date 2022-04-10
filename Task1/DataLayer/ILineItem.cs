using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public interface ILineItem 
    {
         string ProductName { get; set; }
         int Quantity { get; set; }
         decimal Sum { get; set; } 
    }


}
