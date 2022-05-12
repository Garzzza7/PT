using System.Collections.Generic;

namespace Data
{
    public abstract class DataLayerAbstractAPI
    {
        public static DataLayerAbstractAPI DataLayerImplementation()
        {
            return new DataLayerConcrete();
        }
        public abstract void AddProduct(IProduct product);
        public abstract void DeleteProduct(IProduct product);
        public abstract IProduct GetProduct(int id);
        public abstract List<IProduct> GetAllProducts();
        public abstract List<int> GetAllProductIds();

        public abstract void AddClient(IClient client);
        public abstract void DeleteClient(IClient client);
        public abstract IClient GetClient(int id);
        public abstract List<IClient> GetAllClients();
        public abstract List<int> GetAllClientsIds();

        public abstract void AddEvent(IEvent IEvent);
        public abstract void DeleteEvent(IEvent IEvent);
        public abstract List<IEvent> GetAllEvents();

        public abstract void AddState(IState state);
        public abstract void DeleteState(IState state);
        public abstract List<IState> GetAllStates();



        public static DataLayerAbstractAPI CreateLayer()
        {
            return new DataLayerConcrete();
        }
        public static DataLayerAbstractAPI CreateLayer(IContentGenerator contentGenerator)
        {
            return contentGenerator.Create();
        }
        private class DataLayerConcrete : DataLayerAbstractAPI
        {
            private Repository repository;
            public DataLayerConcrete()
            {
                repository = new Repository();
            }

            //Product

            public override void AddProduct(IProduct product)
            {
                repository.DataContext.AddProduct(product);
            }
            public override void DeleteProduct(IProduct product)
            {
                repository.DataContext.DeleteProduct(product);
            }
            public override IProduct GetProduct(int id)
            {
                return repository.DataContext.GetProduct(id);
            }
            public  override List<IProduct> GetAllProducts()
            {
                return repository.DataContext.GetAllProducts();
            }
            public override List<int> GetAllProductIds()
            {
                return repository.DataContext.GetAllProductIds();
            }

            //Client

            public override void AddClient(IClient client)
            {
                repository.DataContext.AddClient(client);
            }
            public override void DeleteClient(IClient client)
            {
                repository.DataContext.DeleteClient(client);
            }
            public override IClient GetClient(int id)
            {
                return repository.DataContext.GetClient(id);
            }
            public override List<IClient> GetAllClients()
            {
                return repository.DataContext.GetAllClients();
            }
            public override List<int> GetAllClientsIds()
            {
                return repository.DataContext.GetAllClientsIds();
            }

            //Event

            public override void AddEvent(IEvent IEvent)
            {
                repository.DataContext.AddEvent(IEvent);
            }
            public override void DeleteEvent(IEvent IEvent)
            {
                repository.DataContext.DeleteEvent(IEvent);
            }
            public override List<IEvent> GetAllEvents()
            {
                return repository.DataContext.GetAllEvents();
            }

            //State

            public override void AddState(IState state)
            {
                repository.DataContext.AddState(state);
            }
            public override void DeleteState(IState state)
            {
                repository.DataContext.DeleteState(state);
            }
            public override List<IState> GetAllStates()
            {
                return repository.DataContext.GetAllStates();
            }
        }

    }
}
