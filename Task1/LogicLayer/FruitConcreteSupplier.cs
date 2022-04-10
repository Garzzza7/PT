using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer
{
    public class FruitConcreteSupplier : ISupplier
    {
        static string[] fruits = new[] { "Banana", "Apple", "StrawBerry", "Plum" };
        public List<Product> GetProducts()
        {
            var products = new List<Product>();
            var random = new Random();

            for(int i=0; i<20; i++)
            {
                string fruit = fruits[random.Next(fruits.Length)];

                products.Add(new Product(fruit, random.Next(10)) /*{ Name = fruit, Price = random.Next(10) }*/); 
            }

            return products;
        }
    }


}
