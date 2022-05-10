using System;
using System.Collections.Generic;
using System.Linq;
using Data;

namespace Logic
{
    internal class Service
    {
        private DataLayerAbstractAPI dataLayer;

        internal Service(DataLayerAbstractAPI dataLayer)
        {
            this.dataLayer = dataLayer;
        }

        //Client 

        internal void AddClient(int id, string name, string surname)
        {
            IClient client = dataLayer.GetClient(id);

            if (client != null)
            {
                throw new Exception($"Client with id {id} already exists");
            }

            IClient newClient = new Client(id, name, surname);
            dataLayer.AddClient(newClient);
        }
        internal void DeleteClient(int id)
        {
            IClient clientToRemove = dataLayer.GetClient(id);

            if (clientToRemove == null)
            {
                throw new Exception($"Client with id {clientToRemove.Id} does not exist");
            }

            dataLayer.DeleteClient(clientToRemove);
        }

        internal IClient GetClient(int id)
        {
            IClient client = dataLayer.GetClient(id);

            if (client == null)
            {
                throw new Exception($"Client with id {id} does not exist");
            }

            return client;
        }

        internal List<IClient> GetAllClients()
        {
            return dataLayer.GetAllClients();
        }

        internal List<IEvent> GetAllClientEvents(int id)
        {
            return dataLayer.GetAllEvents().Where(x => x.Client == dataLayer.GetClient(id)).ToList();
        }

        //Product events

        internal void PurchaseProduct(int productId, int clientId)
        {
            IProduct product = dataLayer.GetProduct(productId);
            IClient client = dataLayer.GetClient(clientId);

            if (product == null)
            {
                throw new Exception($"Product with id {productId} does not exist");
            }

            if (client == null)
            {
                throw new Exception($"Client with id {clientId} does not exist");
            }

            dataLayer.AddState(new State(product));
            dataLayer.AddEvent(new EventPurchase(dataLayer.GetAllStates().FirstOrDefault(x => x.Product == product), client));

        }
        internal List<IEvent> GetAllProductEvents(IProduct product)
        {
            return dataLayer.GetAllEvents().Where(x => x.State.Product == product).ToList();
        }
        internal void ReturnProduct(IProduct product, int clientId)
        {
            IClient client = dataLayer.GetClient(clientId);

            if (product == null)
            {
                throw new Exception($"Product with id {product.Id} does not exist");
            }

            if (client == null)
            {
                throw new Exception($"Client with id {clientId} does not exist");
            }

            dataLayer.AddState(new State(product));
            dataLayer.AddEvent(new EventReturn(dataLayer.GetAllStates().FirstOrDefault(x => x.Product == product), client));
        }

        //Product

        internal void AddProduct(int id, double price, string category)
        {
            IProduct product = new Product(id, price, category);
            dataLayer.AddProduct(product);
        }
        internal void DeleteProduct(int id)
        {
            IProduct productToRemove = dataLayer.GetProduct(id);

            if (productToRemove != null)
            {
                throw new Exception($"Client with id {id} does not exist");
            }

            dataLayer.DeleteProduct(productToRemove);
        }
        internal List<IProduct> GetAllProducts()
        {
            return dataLayer.GetAllProducts();
        }
        internal IProduct GetProductById(int id)
        {
            IProduct product = dataLayer.GetProduct(id);

            if (product == null)
            {
                throw new Exception($"Product with id {id} does not exist");
            }

            return product;
        }
    }

}

