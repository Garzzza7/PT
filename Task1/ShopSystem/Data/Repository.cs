using System;
using System.Collections.Generic;

namespace ShopSystem.Data
{
    public class Repository : IRepository
    {
        public DataContext DataContext { get; set; }

        public Repository(DataContext dataContext)
        {
            this.DataContext = dataContext;
        }

        //Client

        public void AddClient(Client client)
        {
            if (!NoSuchClientId(client.Id))
            {
                throw new Exception("Client with an id " + client.Id + " already exists");
            }

            DataContext.Clients.Add(client);
        }

        public void DeleteClient(Client client)
        {
            if (NoSuchClientId(client.Id))
            {
                throw new KeyNotFoundException("Client with an id " + client.Id + " does not exist");
            }

            DataContext.Clients.Remove(client);
        }

        public Client GetClientById(int id)
        {
            if (NoSuchClientId(id))
            {
                throw new KeyNotFoundException("Client with an id " + id + " does not exist");
            }
            return DataContext.Clients.Find(client => client.Id == id);
        }

        public List<Client> GetAllClients()
        {
            return DataContext.Clients;
        }

        public List<int> GetAllClientsIds() 
        {
            List<int> ids = new List<int>();

            foreach(Client client in DataContext.Clients)
            {
                ids.Add(client.Id);
            }
            return ids;
        }

        public bool NoSuchClientId(int id)
        {
            return !DataContext.Clients.Exists(c => c.Id == id);
        }

        //Product

        public void AddProduct(Product product)
        {
            if (!NoSuchProductId(product.Id))
            {
                throw new Exception("Product with an id " + product.Id + " already exists");
            }
            DataContext.Products.Add(product.Id, product);
        }

        public void DeleteProduct(int id)
        {
            if (NoSuchProductId(id))
            {
                throw new KeyNotFoundException("Product with an id " + id + " does not exist");
            }

            DataContext.Products.Remove(id);
        }

        public Product GetProductById(int id)
        {
            if (NoSuchProductId(id))
            {
                throw new KeyNotFoundException("Product with an id " + id + " does not exist");
            }

            return DataContext.Products[id];
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return DataContext.Products.Values;
        }

        public IEnumerable<int> GetAllProductIds()
        {
            return DataContext.Products.Keys;
        }

        public bool NoSuchProductId(int id)
        {
            return !DataContext.Products.ContainsKey(id);
        }

        //Event

        public void AddEvent(IEvent IEvent)
        {
            DataContext.Events.Add(IEvent);
        }

        public void DeleteEvent(IEvent IEvent)
        {
            DataContext.Events.Remove(IEvent);
        }

        public List<IEvent> GetAllEvents()
        {
            return DataContext.Events;
        }

        //State

        public void AddState(State state)
        {
            DataContext.States.Add(state);
        }

        public void DeleteState(State state)
        {
            if (NoSuchState(state))
            {
                throw new Exception();
            }

            DataContext.States.Remove(state);
        }

        public List<State> GetAllStates()
        {
            return DataContext.States;
        }

        public bool NoSuchState(State state)
        {
            return !DataContext.States.Exists(s => s.Equals(state));
        } 

    }
}
