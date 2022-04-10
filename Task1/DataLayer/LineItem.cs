using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class LineItem : ILineItem {
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public decimal Sum { get; set; }

        public LineItem(string productName, int quantity, decimal sum)
        {
            ProductName = productName;
            Quantity = quantity;
            Sum = sum;
        }
    }

}
