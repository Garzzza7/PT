using System.Collections.Generic;
using System.Linq;
using Data.DataBase;

namespace Data
{
    public abstract class DataLayerAbstractAPI
    {
        private DataClasses1DataContext context;
        //////////////////////////////////////////
        public abstract void AddProduct(IProduct product);
        public abstract void DeleteProduct(IProduct product);
        public abstract IProduct GetProduct(int id);
        public abstract List<IProduct> GetAllProducts();
        //////////////////////////////////////////
        public abstract void AddClient(IClient client);
        public abstract void DeleteClient(IClient client);
        public abstract IClient GetClient(int id);
        public abstract bool ClientExists(int id);
        public abstract List<IClient> GetAllClients();
        //////////////////////////////////////////
        public abstract void AddEvent(IEvent IEvent);
        public abstract void DeleteEvent(IEvent IEvent);
        public abstract List<IEvent> GetAllEvents();

        /*
        public static DataLayerAbstractAPI CreateLayer(IContent inc = default(Content))
        {
            return new DataLayerConcrete(inc == null ? new Content() : inc);
        }
        */
        private class DataLayerConcrete : DataLayerAbstractAPI
        {
            public DataLayerConcrete()
            {
                context = new DataClasses1DataContext();
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
            public override bool ProductExists(int id)
            {
                return repository.DataContext.ProductExists(id);
            }
            public  override List<IProduct> GetAllProducts()
            {
                return repository.DataContext.GetAllProducts();
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
            public override bool ClientExists(int id)
            {
                return repository.DataContext.ClientExists(id);
            }
            public override List<IClient> GetAllClients()
            {
                return repository.DataContext.GetAllClients();
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
        }

    }
}
