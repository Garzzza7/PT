using System.Collections.Generic;

namespace Data
{
    internal class DataContext
    {
        private List<IProduct> products;
        private List<IEvent> events;
        private List<IState> states;
        private List<IClient> clients;

        internal DataContext(List<IClient> _client, List<IEvent> _events, List<IProduct> _products, List<IState> _states)
        {
            clients = _client;
            events = _events;
            products = _products;
            states = _states;
        }

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

        public bool ClientExists(int id)
        {
            return clients.Contains(GetClient(id));
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

        public bool ProductExists(int id)
        {
            return products.Contains(GetProduct(id));
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
