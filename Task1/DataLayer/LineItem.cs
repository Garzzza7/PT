using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class LineItem : ILineItem {
        private string productName { get; set; }
        private int quantity { get; set; }
        private decimal price { get; set; }
        private Category category { get; set; }

        public string ProductName => productName;
        public int Quantity => quantity;
        public decimal Price => price;
        public Category Category => category;

        public LineItem(string _productName, int _quantity, decimal _price, Category _category )
        {
            productName= _productName;
            quantity= _quantity;
            price= _price;
            category= _category;
        }

        public enum Category
        {
            vegeteble,
            fuit,
            beverage,
            food,
            appliance
        }
    }

}
