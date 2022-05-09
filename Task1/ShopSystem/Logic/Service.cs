using System;
using System.Collections.Generic;
using System.Text;
using ShopSystem.Data;
namespace ShopSystem.Logic
{
    public class Service
    {
        private LogicLayerAPI logicLayer;
        public Service(LogicLayerAPI lol)
        {
            this.logicLayer = lol;
        }

        public  void AddClient(int id, String name, String surname)
        {
          this.logicLayer.AddClient(id, name, surname);
        }
        public void DeleteClient(IClient client)
        {
            this.logicLayer.DeleteClient(client);
        }
        public  List<IClient> GetAllClients()
        {
            return this.logicLayer.GetAllClients();
        }
        public  IClient GetClient(int id)
        {
            return this.logicLayer.GetClient(id);
        }
        public  List<IEvent> GetAllClientEvents(int id)
        {
            return this.logicLayer.GetAllClientEvents(id);
        }
        public  void PurchaseProduct(int productId, int clientId)
        {
            this.logicLayer.PurchaseProduct(productId, clientId);   
        }
        public  List<IEvent> GetAllProductEvents(IProduct product)
        {
            return this.logicLayer.GetAllProductEvents(product);
        }
        public  void ReturnProduct(IProduct product, int clientId)
        {
            this.logicLayer.ReturnProduct(product, clientId);
        }
        public  void AddProduct(int id, double price, Category category)
        {
            this.logicLayer.AddProduct(id, price, category);
        }
        public  void DeleteProduct(int id)
        {
            this.logicLayer.DeleteProduct(id);
        }
        public  IEnumerable<IProduct> GetAllProducts()
        {
            return this.logicLayer.GetAllProducts();
        }
        public  IProduct GetProductById(int id)
        {
            return this.logicLayer.GetProductById(id);
        }

    }
}
