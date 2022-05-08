using System;
using System.Collections.Generic;

namespace ShopSystem.Data
{
    internal class Repository : IRepository
    {
        private DataContext DataContext;

        public Repository(DataContext dataContext)
        {
            this.DataContext = dataContext;
        }

        //Client

        public void AddClient(IClient client)
        {
            if (!NoSuchClientId(client.Id))
            {
                throw new Exception("Client with an id " + client.Id + " already exists");
            }

            DataContext.clients.Add(client);
        }

        public void DeleteClient(IClient client)
        {
            if (NoSuchClientId(client.Id))
            {
                throw new KeyNotFoundException("Client with an id " + client.Id + " does not exist");
            }

            DataContext.clients.Remove(client);
        }

        public IClient GetClientById(int id)
        {
            if (NoSuchClientId(id))
            {
                throw new KeyNotFoundException("Client with an id " + id + " does not exist");
            }
            return DataContext.clients.Find(client => client.Id == id);
        }

        public List<IClient> GetAllClients()
        {
            return DataContext.clients;
        }

        public List<int> GetAllClientsIds() 
        {
            List<int> ids = new List<int>();

            foreach(IClient client in DataContext.clients)
            {
                ids.Add(client.Id);
            }
            return ids;
        }

        public bool NoSuchClientId(int id)
        {
            return !DataContext.clients.Exists(c => c.Id == id);
        }

        //Product

        public void AddProduct(IProduct product)
        {
            if (!NoSuchProductId(product.Id))
            {
                throw new Exception("Product with an id " + product.Id + " already exists");
            }
            DataContext.products.Add(product.Id, product);
        }

        public void DeleteProduct(int id)
        {
            if (NoSuchProductId(id))
            {
                throw new KeyNotFoundException("Product with an id " + id + " does not exist");
            }

            DataContext.products.Remove(id);
        }

        public IProduct GetProductById(int id)
        {
            if (NoSuchProductId(id))
            {
                throw new KeyNotFoundException("Product with an id " + id + " does not exist");
            }

            return DataContext.products[id];
        }

        public IEnumerable<IProduct> GetAllProducts()
        {
            return DataContext.products.Values;
        }

        public IEnumerable<int> GetAllProductIds()
        {
            return DataContext.products.Keys;
        }

        public bool NoSuchProductId(int id)
        {
            return !DataContext.products.ContainsKey(id);
        }

        //Event

        public void AddEvent(IEvent IEvent)
        {
            if (DataContext.events.Contains(IEvent))
            {
                throw new Exception();
            }
            DataContext.events.Add(IEvent);
        }

        public void DeleteEvent(IEvent IEvent)
        {
            if (!DataContext.events.Contains(IEvent))
            {
                throw new Exception();
            }
            DataContext.events.Remove(IEvent);
        }

        public List<IEvent> GetAllEvents()
        {
            return DataContext.events;
        }

        //State

        public void AddState(IState state)
        {
            DataContext.states.Add(state);
        }

        public void DeleteState(IState state)
        {
            if (NoSuchState(state))
            {
                throw new Exception();
            }

            DataContext.states.Remove(state);
        }

        public List<IState> GetAllStates()
        {
            return DataContext.states;
        }

        public bool NoSuchState(IState state)
        {
            return !DataContext.states.Exists(s => s.Equals(state));
        } 

    }
}
