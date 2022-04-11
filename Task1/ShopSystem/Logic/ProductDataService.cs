using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using ShopSystem.Data;

namespace ShopSystem.Logic
{
    public class ProductDataService
    {
        private IRepository irepo;

        public ProductDataService(IRepository irepo)
        {
            this.irepo = irepo;
        }
        public void AddProduct(int id, double price, Category category)
        {
            irepo.AddProduct(new Product(id, price, category));
        }

        public void DeleteProduct(int id)
        {
            irepo.DeleteProduct(id);
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return irepo.GetAllProducts();
        }

        public Product GetProductById(int id)
        {
            return irepo.GetProductById(id);
        }

        public List<IEvent> GetAllProductEvents(Product product)
        {
            List<IEvent> listofeventinterfaces = new List<IEvent>();

            foreach (IEvent e in irepo.GetAllEvents())
            {
                if (e.State.Product.Equals(product))
                {
                    listofeventinterfaces.Add(e);
                }
            }
            return listofeventinterfaces;
        }
    }
}
