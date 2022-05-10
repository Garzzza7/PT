using System.Collections.Generic;

namespace Data
{
    internal class DataContext
    {
        private List<IProduct> products = new List<IProduct>();
        private List<IEvent> events = new List<IEvent>();
        private List<IState> states = new List<IState>();
        private List<IClient> clients = new List<IClient>();

        //Client

        public void AddClient(IClient client)
        {
            clients.Add(client);
        }

        public void DeleteClient(IClient client)
        {
            clients.Remove(client);
        }

        public IClient GetClient(int id)
        {
            return clients.Find(client => client.Id == id);
        }

        public List<IClient> GetAllClients()
        {
            return clients;
        }

        public List<int> GetAllClientsIds()
        {
            List<int> ids = new List<int>();

            foreach (IClient client in clients)
            {
                ids.Add(client.Id);
            }
            return ids;
        }

        //Product

        public void AddProduct(IProduct product)
        {
            products.Add(product);
        }

        public void DeleteProduct(IProduct product)
        {
            products.Remove(product);
        }

        public IProduct GetProduct(int id)
        {
            return products[id];
        }

        public List<IProduct> GetAllProducts()
        {
            return products;
        }

        public List<int> GetAllProductIds()
        {
            List<int> ids = new List<int>();

            foreach (IProduct product in products)
            {
                ids.Add(product.Id);
            }

            return ids;
        }

        //Event

        public void AddEvent(IEvent IEvent)
        {
            events.Add(IEvent);
        }

        public void DeleteEvent(IEvent IEvent)
        {
            events.Remove(IEvent);
        }

        public List<IEvent> GetAllEvents()
        {
            return events;
        }

        //State

        public void AddState(IState state)
        {
            states.Add(state);
        }

        public void DeleteState(IState state)
        {
            states.Remove(state);
        }

        public List<IState> GetAllStates()
        {
            return states;
        }
    }
}
