using System;
using System.Collections.Generic;
using System.Text;
using ShopSystem.Data;

namespace ShopSystemTest
{
    class ContentGenerator : IContentGenerator
    {
        public DataContext Create()
        {
            DataContext context = new DataContext();

            Client client1 = new Client(1, "Piotr", "Czapla");
            Client client2 = new Client(2, "Piotr", "Hynasiński");

            context.Clients.Add(client1);
            context.Clients.Add(client2);

            // add items 

            Product product1 = new Product(1, 20, Category.books);
            Product product2 = new Product(2, 30, Category.drugs);
            Product product3 = new Product(3, 40, Category.electronics);

            context.Products.Add(1, product1);
            context.Products.Add(2, product2);
            context.Products.Add(3, product3);

            // add events and states 

            State state1 = new State(product1);
            State state2 = new State(product2);

            EventPurchase eventPurchase1 = new EventPurchase(state1, client1);
            EventPurchase eventPurchase2 = new EventPurchase(state2, client2);

            context.States.Add(state1);
            context.States.Add(state2);

            context.Events.Add(eventPurchase1);
            context.Events.Add(eventPurchase2);

            return context;
        }
    }
}
