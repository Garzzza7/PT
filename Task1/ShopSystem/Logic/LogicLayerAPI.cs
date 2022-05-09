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
                IClient client = _api.GetClientById(id);

                if (client != null)
                {
                    throw new Exception($"Client with id {id} already exists");
                }

                IClient newClient = new Client(id, name, surname);
                _api.AddClient(newClient);
            }
            public override void DeleteClient(IClient client)
            {
                IClient client = _api.GetClientById(client.Id);

                if (client != null)
                {
                    throw new Exception($"Client with id {client.Id} already exists");
                }

                _api.DeleteClient(client);
            }
            public override List<IClient> GetAllClients()
            {
                
            }
            public override IClient GetClient(int id)
            {
                IClient client = _api.GetClientById(id);

                if (client == null)
                {
                    throw new Exception($"Client with id {id} does not exist");
                }

                return client;
            }
            public override List<IEvent> GetAllClientEvents(int id)
            {
                
            }
            public override void PurchaseProduct(int productId, int clientId)
            {
                IProduct product = _api.GetProductById(productId);
                IClient client = _api.GetClientById(clientId);

                if (product == null)
                {
                    throw new Exception($"Product with id {productId} does not exist");
                }

                if (client == null)
                {
                    throw new Exception($"Client with id {clientId} does not exist");
                }

                _api.AddState(new State(product))
                _api.AddEvent(new EventPurchase())

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
                IProduct product = new Product(id, price, category);
                _api.AddProduct(product);
            }
            public override void DeleteProduct(int id)
            {
                _api.DeleteProduct(id);
            }
            public override IEnumerable<IProduct> GetAllProducts()
            {
                return _api.GetAllProducts();
            }
            public override IProduct GetProductById(int id)
            {
                return _api.GetProductById(id);
            }

        }
        
        

    }
    
}

