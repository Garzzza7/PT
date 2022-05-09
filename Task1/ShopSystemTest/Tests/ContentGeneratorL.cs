﻿using System;
using System.Collections.Generic;
using System.Text;
using ShopSystem.Data;

namespace ShopSystemTest
{
    internal class Test_Client : IClient
    {
        public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Surname { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Test_Client(int _id, string _name, string _surname)
        {
            this.Id = _id;
            this.Name = _name;
            this.Surname = _surname;
        }
    }
    internal class Test_Product : IProduct
    {
        public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double Price { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Category Category { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Test_Product(int _id, double _price, Category _category)
        {
            this.Id = _id;
            this.Price = _price;
            this.Category = _category;
        }
    }
    internal class Test_State : IState
    {
        public IProduct Product { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Test_State(IProduct _product)
        {
            this.Product = _product;
        }
    }
    internal class Test_EventPurchase : IEvent
    {
        public IState State { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IClient Client { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime PurchaseDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Test_EventPurchase(IState state1, IClient client1)
        {
            this.State = state1;
            this.Client = client1;
        }
    }

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
