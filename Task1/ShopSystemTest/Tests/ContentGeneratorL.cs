using ShopSystem.Data.API;

namespace ShopSystemTest.Generator
{
    class ContentGenerator : IContentGenerator
    {
        public DataLayerAbstractAPI Create()
        {

            DataLayerAbstractAPI dataLayerAbstractAPI = DataLayerAbstractAPI.aPI();
            IClient client1 = new Test_Client(1, "Piotr", "Czapla");
            IClient client2 = new Test_Client(2, "Piotr", "Hynasiński");

            dataLayerAbstractAPI.AddClient(client1);
            dataLayerAbstractAPI.AddClient(client2);

            // add items 

            IProduct product1 = new Test_Product(1, 20, Category.books);
            IProduct product2 = new Test_Product(2, 30, Category.drugs);
            IProduct product3 = new Test_Product(3, 40, Category.electronics);

            dataLayerAbstractAPI.AddProduct(product1);
            dataLayerAbstractAPI.AddProduct(product2);
            dataLayerAbstractAPI.AddProduct(product3);

            // add events and states 

            IState state1 = new Test_State(product1);
            IState state2 = new Test_State(product2);

            IEvent eventPurchase1 = new Test_EventPurchase(state1, client1);
            IEvent eventPurchase2 = new Test_EventPurchase(state2, client2);

            dataLayerAbstractAPI.AddState(state1);
            dataLayerAbstractAPI.AddState(state2);
            dataLayerAbstractAPI.AddEvent(eventPurchase1);
            dataLayerAbstractAPI.AddEvent(eventPurchase2);


            return dataLayerAbstractAPI;
        }
    }
}
