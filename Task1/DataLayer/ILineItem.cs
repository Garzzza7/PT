using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public interface ILineItem 
    {
         string productName { get; set; }
         int quantity { get; set; }
         decimal price { get; set; }
         Category category { get; set; }
    }
    public enum Category {}

}
