using System;
using System.Collections.Generic;
using System.Text;

using ShopSystem.Data;
namespace ShopSystem.Logic
{
    public abstract class LogicLayerAPI
    {
        public static LogicLayerAPI CreateLayer(DataLayerAbstractAPI contentGenerator = default)
        {
            return new LogicLayer(contentGenerator ?? DataLayerAbstractAPI.aPI());
        }

        public abstract void AddClient(int id, String name, String surname);
        public abstract void DeleteClient(IClient client);
        public abstract List<IClient> GetAllClients();
        public abstract IClient GetClient(int id);
        public abstract List<IEvent> GetAllClientEvents(int id);
        public abstract void PurchaseProduct(int productId, int clientId);
        public abstract List<IEvent> GetAllProductEvents(IProduct product);
        public abstract void ReturnProduct(IProduct product, int clientId);
        public abstract void AddProduct(int id, double price, Category category);
        public abstract void DeleteProduct(int id);
        public abstract IEnumerable<IProduct> GetAllProducts();
        public abstract IProduct GetProductById(int id);
        
        private class LogicLayer : LogicLayerAPI
        {
            private readonly DataLayerAbstractAPI _api;
            public LogicLayer(DataLayerAbstractAPI dataLayerAbstractAPI)
            {
                _api = dataLayerAbstractAPI;
            }
            public override void AddClient(int id, String name, String surname)
            {
                IClient client = new Client(id, name, surname);
                _api.AddClient(client);
            }
            public override void DeleteClient(IClient client)
            {
                _api.DeleteClient(client);
            }
            public override List<IClient> GetAllClients()
            {
                return _api.GetAllClients();
            }
            public override IClient GetClient(int id)
            {
                return _api.GetClientById(id);
            }
            public override List<IEvent> GetAllClientEvents(int id)
            {
                return _api.GetAllEvents();
            }
            public override void PurchaseProduct(int productId, int clientId)
            {

            }
            public override List<IEvent> GetAllProductEvents(IProduct product)
            {
                return null;
            }
            public override void ReturnProduct(IProduct product, int clientId)
            {

            }
            public override void AddProduct(int id, double price, Category category)
            {

            }
            public override void DeleteProduct(int id)
            {

            }
            public override IEnumerable<IProduct> GetAllProducts()
            {
                return null;
            }
            public override IProduct GetProductById(int id)
            {
                return null;
            }

        }
        
        

    }
    
}

