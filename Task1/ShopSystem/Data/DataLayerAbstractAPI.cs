using System;
using System.Collections.Generic;
using System.Text;

namespace ShopSystem.Data
{
    public abstract class DataLayerAbstractAPI
    {
        public static DataLayerAbstractAPI datalayerimp()
        {
            return new DataLayerImp();
        }
        public abstract IEnumerable<IProduct> GetAllProducts();
        public abstract IEnumerable<int> GetAllProductIds();
        public abstract IProduct GetProductById(int id);
        public abstract void AddProduct(IProduct product);
        public abstract void DeleteProduct(int id);
        public abstract List<IClient> GetAllClients();
        public abstract List<int> GetAllClientsIds();
        public abstract IClient GetClientById(int id);
        public abstract void AddClient(IClient client);
        public abstract void DeleteClient(IClient client);
        public abstract List<IEvent> GetAllEvents();
        public abstract void AddEvent(IEvent IEvent);
        public abstract void DeleteEvent(IEvent IEvent);
        public abstract List<IState> GetAllStates();
        public abstract void AddState(IState state);
        public abstract void DeleteState(IState state);



        public static DataLayerAbstractAPI aPI()
        {
            return new DataLayerImp();
        }
        public static DataLayerAbstractAPI aPI(IContentGenerator contentGenerator)
        {
            return contentGenerator.Create();
        }
        private class DataLayerImp : DataLayerAbstractAPI
        {
            private Repository repo;
           // public DataLayerImp()
           // {
           //     this.repo = new Repository;
           // }
            public  override IEnumerable<IProduct> GetAllProducts()
            {
                return this.repo.GetAllProducts();
            }
            public override IEnumerable<int> GetAllProductIds()
            {
                return this.repo.GetAllProductIds();
            }
            public override IProduct GetProductById(int id)
            {
                return this.repo.GetProductById(id);
            }

            public override void AddProduct(IProduct product)
            {
                 this.repo.AddProduct(product);
            }
            public override void DeleteProduct(int id)
            {
                 this.repo.DeleteProduct(id);
            }
            public override List<IClient> GetAllClients()
            {
                return this.repo.GetAllClients();
            }

            public override List<int> GetAllClientsIds()
            {
                return this.repo.GetAllClientsIds();
            }
            public override IClient GetClientById(int id)
            {
                return this.repo.GetClientById(id);
            }
            public override void AddClient(IClient client)
            {
                 this.repo.AddClient(client);
            }
            public override void DeleteClient(IClient client)
            {
                 this.repo.DeleteClient(client);
            }
            public override List<IEvent> GetAllEvents()
            {
                return this.repo.GetAllEvents();
            }
            public override void AddEvent(IEvent IEvent)
            {
                 this.repo.AddEvent(IEvent);
            }
            public override void DeleteEvent(IEvent IEvent)
            {
                this.repo.DeleteEvent(IEvent);
            }
            public override List<IState> GetAllStates()
            {
                return this.repo.GetAllStates();
            }
            public override void AddState(IState state)
            {
                this.repo.AddState(state);
            }
            public override void DeleteState(IState state)
            {
                this.repo.DeleteState(state);
            }

        }

    }
}
