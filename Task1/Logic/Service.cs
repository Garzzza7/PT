using System;
using System.Collections.Generic;
using System.Linq;
using Data;

namespace Logic
{
    internal class Service
    {
        //Client 

        internal void AddClient(int id, string name, string surname, DataLayerAbstractAPI dataLayer)
        {
            if (!dataLayer.ClientExists(id))
            {
                dataLayer.AddClient(new Client(id, name, surname));
            }
            else
            {
                throw new Exception($"Client with id {id} already exists");
            }
        }
        internal void DeleteClient(int id, DataLayerAbstractAPI dataLayer)
        {
            if (dataLayer.ClientExists(id))
            {
                dataLayer.DeleteClient(dataLayer.GetClient(id));
            }
            else
            {
                throw new Exception($"Client with id {id} does not exist");
            }
        }

        internal IClient GetClient(int id, DataLayerAbstractAPI dataLayer)
        {
            IClient client = dataLayer.GetClient(id);

            if (client == null)
            {
                throw new Exception($"Client with id {id} does not exist");
            }

            return client;
        }

        internal bool ClientExists(int id, DataLayerAbstractAPI dataLayer)
        {
            if (dataLayer.GetClient(id) == null)
            {
                throw new Exception($"Client does not exist");
            }

            return true;
        }

        internal List<IClient> GetAllClients(DataLayerAbstractAPI dataLayer)
        {
            return dataLayer.GetAllClients();
        }

        internal List<IEvent> GetAllClientEvents(int id, DataLayerAbstractAPI dataLayer)
        {
            return dataLayer.GetAllEvents().Where(x => x.Client == dataLayer.GetClient(id)).ToList();
        }

        //Product events

        internal void PurchaseProduct(int productId, int clientId, DataLayerAbstractAPI dataLayer)
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

        internal bool ProductExists(int id, DataLayerAbstractAPI dataLayer)
        {
            if (dataLayer.GetProduct(id) == null)
            {
                throw new Exception($"Product does not exist");
            }

            return true;
        }

        internal List<IEvent> GetAllProductEvents(IProduct product, DataLayerAbstractAPI dataLayer)
        {
            return dataLayer.GetAllEvents().Where(x => x.State.Product == product).ToList();
        }
        internal void ReturnProduct(IProduct product, int clientId, DataLayerAbstractAPI dataLayer)
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

        internal void AddProduct(int id, double price, string category, DataLayerAbstractAPI dataLayer)
        {
            if (!dataLayer.ProductExists(id))
            {
                dataLayer.AddProduct(new Product(id, price, category));
            }
            else
            {
                throw new Exception($"Product with id {id} already exists");
            }
        }
        internal void DeleteProduct(int id, DataLayerAbstractAPI dataLayer)
        {
            if (dataLayer.ProductExists(id))
            {
                dataLayer.DeleteProduct(dataLayer.GetProduct(id));
            }
            else
            {
                throw new Exception($"Product with id {id} does not exist");
            }
        }
        internal List<IProduct> GetAllProducts(DataLayerAbstractAPI dataLayer)
        {
            return dataLayer.GetAllProducts();
        }
        internal IProduct GetProduct(int id, DataLayerAbstractAPI dataLayer)
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

