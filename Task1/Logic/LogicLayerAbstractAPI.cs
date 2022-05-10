using System;
using System.Collections.Generic;
using Data;

namespace Logic
{
    public abstract class LogicLayerAbstractAPI
    {
        public abstract void AddClient(int id, string name, string surname);
        public abstract void DeleteClient(int id);
        public abstract List<IClient> GetAllClients();
        public abstract IClient GetClient(int id);
        public abstract List<IEvent> GetAllClientEvents(int id);
        public abstract void PurchaseProduct(int productId, int clientId);
        public abstract List<IEvent> GetAllProductEvents(IProduct product);
        public abstract void ReturnProduct(IProduct product, int clientId);
        public abstract void AddProduct(int id, double price, string category);
        public abstract void DeleteProduct(int id);
        public abstract IEnumerable<IProduct> GetAllProducts();
        public abstract IProduct GetProductById(int id);

        public static LogicLayerAbstractAPI CreateLayer(DataLayerAbstractAPI contentGenerator = default)
        {
            return new LogicLayer(contentGenerator ?? DataLayerAbstractAPI.CreateLayer());
        }

        private class LogicLayer : LogicLayerAbstractAPI
        {
            private Service service;
            private DataLayerAbstractAPI dataLayer;
            public LogicLayer(DataLayerAbstractAPI dataLayer)
            {
                this.dataLayer = dataLayer;
                service = new Service(this.dataLayer);
            }

            public override void AddClient(int id, string name, string surname)
            {
                service.AddClient(id, name, surname);
            }
            public override void DeleteClient(int id)
            {
                service.DeleteClient(id);
            }
            public override List<IClient> GetAllClients()
            {
                return service.GetAllClients();
            }
            public override IClient GetClient(int id)
            {
                return service.GetClient(id);
            }
            public override List<IEvent> GetAllClientEvents(int id)
            {
                return service.GetAllClientEvents(id);
            }
            public override void PurchaseProduct(int productId, int clientId)
            {
                service.PurchaseProduct(productId, clientId);
            }
            public override List<IEvent> GetAllProductEvents(IProduct product)
            {
                return service.GetAllProductEvents(product);
            }
            public override void ReturnProduct(IProduct product, int clientId)
            {
                service.ReturnProduct(product, clientId);
            }
            public override void AddProduct(int id, double price, string category)
            {
                service.AddProduct(id, price, category);
            }
            public override void DeleteProduct(int id)
            {
                service.DeleteProduct(id);
            }
            public override IEnumerable<IProduct> GetAllProducts()
            {
                return service.GetAllProducts();
            }
            public override IProduct GetProductById(int id)
            {
                return service.GetProductById(id);
            }
        }
        

    }
}
