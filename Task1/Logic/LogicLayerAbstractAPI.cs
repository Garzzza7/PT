using System;
using System.Collections.Generic;
using Data;

namespace Logic
{
    public abstract class LogicLayerAbstractAPI
    {
        private Service service;
        private DataLayerAbstractAPI dataLayer;
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
        public abstract IProduct GetProduct(int id);

        public static LogicLayerAbstractAPI CreateLogicLayer(DataLayerAbstractAPI datalayer = default(DataLayerAbstractAPI))
        {
            return new LogicLayer(datalayer == null ? DataLayerAbstractAPI.CreateLayer() : datalayer);
        }

        private class LogicLayer : LogicLayerAbstractAPI
        {

            public LogicLayer(DataLayerAbstractAPI dataLayer)
            {
                this.dataLayer = dataLayer;
                service = new Service();
            }

            public override void AddClient(int id, string name, string surname)
            {
                service.AddClient(id, name, surname, dataLayer);
            }
            public override void DeleteClient(int id)
            {
                service.DeleteClient(id, dataLayer);
            }
            public override List<IClient> GetAllClients()
            {
                return service.GetAllClients(dataLayer);
            }
            public override IClient GetClient(int id)
            {
                return service.GetClient(id, dataLayer);
            }
            public override List<IEvent> GetAllClientEvents(int id)
            {
                return service.GetAllClientEvents(id, dataLayer);
            }
            public override void PurchaseProduct(int productId, int clientId)
            {
                service.PurchaseProduct(productId, clientId, dataLayer);
            }
            public override List<IEvent> GetAllProductEvents(IProduct product)
            {
                return service.GetAllProductEvents(product, dataLayer);
            }
            public override void ReturnProduct(IProduct product, int clientId)
            {
                service.ReturnProduct(product, clientId, dataLayer);
            }
            public override void AddProduct(int id, double price, string category)
            {
                service.AddProduct(id, price, category, dataLayer);
            }
            public override void DeleteProduct(int id)
            {
                service.DeleteProduct(id,dataLayer);
            }
            public override IEnumerable<IProduct> GetAllProducts()
            {
                return service.GetAllProducts(dataLayer);
            }
            public override IProduct GetProduct(int id)
            {
                return service.GetProduct(id, dataLayer);
            }
        }
        

    }
}
