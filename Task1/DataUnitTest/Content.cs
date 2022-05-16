using Data;
using System.Collections.Generic;

namespace DataUnitTest
{
    class Content : IContent
    {
        private List<IClient> clients = new List<IClient>();
        private List<IProduct> products = new List<IProduct>();
        private List<IState> states = new List<IState>();
        private List<IEvent> events = new List<IEvent>();

        public DataLayerAbstractAPI Create()
        {
            DataLayerAbstractAPI dataLayerAbstractAPI = DataLayerAbstractAPI.CreateLayer();
            clients.Add(new Client(1, "Piotr", "Czapla"));
            clients.Add(new Client(2, "Piotr", "Hynasiński"));

            products.Add(new Product(1, 20, "books"));
            products.Add(new Product(2, 30, "drugs"));
            products.Add(new Product(3, 40, "electronics"));

            states.Add(new State(products[0]));
            states.Add(new State(products[1]));


            events.Add(new EventPurchase(states[0], clients[0]));
            events.Add(new EventPurchase(states[1], clients[1]));

            return dataLayerAbstractAPI;
        }

        public List<IClient> NewClients()
        {
            return clients;
        }

        public List<IEvent> NewEvents()
        {
            return events;
        }

        public List<IProduct> NewProducts()
        {
            return products;
        }

        public List<IState> NewStates()
        {
            return states;
        }
    }
}
