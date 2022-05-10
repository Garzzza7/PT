using Data;

namespace DataUnitTest
{
    class ContentGenerator : IContentGenerator
    {
        public DataLayerAbstractAPI Create()
        {

            DataLayerAbstractAPI dataLayerAbstractAPI = DataLayerAbstractAPI.CreateLayer();
            IClient client1 = new Client(1, "Piotr", "Czapla");
            IClient client2 = new Client(2, "Piotr", "Hynasiński");

            dataLayerAbstractAPI.AddClient(client1);
            dataLayerAbstractAPI.AddClient(client2);

            // add items 

            IProduct product1 = new Product(1, 20, "books");
            IProduct product2 = new Product(2, 30, "drugs");
            IProduct product3 = new Product(3, 40, "electronics");

            dataLayerAbstractAPI.AddProduct(product1);
            dataLayerAbstractAPI.AddProduct(product2);
            dataLayerAbstractAPI.AddProduct(product3);

            // add states

            IState state1 = new State(product1);
            IState state2 = new State(product2);

            dataLayerAbstractAPI.AddState(state1);
            dataLayerAbstractAPI.AddState(state2);

            // add events

            IEvent eventPurchase1 = new EventPurchase(state1, client1);
            IEvent eventPurchase2 = new EventPurchase(state2, client2);

            dataLayerAbstractAPI.AddEvent(eventPurchase1);
            dataLayerAbstractAPI.AddEvent(eventPurchase2);


            return dataLayerAbstractAPI;
        }
    }
}
