using Data;
using Service.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.CRUD
{
    public class ProductCRUD
    {
        private DataLayerAbstractAPI dataLayer;

        public ProductCRUD()
        {
            dataLayer = DataLayerAbstractAPI.CreateLayer();
        }

        public ProductCRUD(DataLayerAbstractAPI dataLayer)
        {
            this.dataLayer = dataLayer;
        }

        public void AddProduct(decimal price, string category)
        {
            dataLayer.AddProduct(price, category);
        }

        public void DeleteProduct(int id)
        {
            dataLayer.DeleteProduct(id);
        }

        public void UpdateProductPrice(int id, decimal price)
        {
            dataLayer.UpdateProductPrice(id, price);
        }

        public void UpdateProductCategory(int id, string category)
        {
            dataLayer.UpdateProductCategory(id, category);
        }

        public ProductDTO GetProduct(int id)
        {
            return (ProductDTO) dataLayer.GetProduct(id);
        }

        public IEnumerable<ProductDTO> GetAllProducts()
        {
            var clients = dataLayer.GetAllProducts();
            var result = new List<ProductDTO>();

            foreach (var client in clients)
            {
                result.Add((ProductDTO) client);
            }

            return result;
        }
    }
}
