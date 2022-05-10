using System;
using Data;

namespace Logic
{
    internal class Client : IClient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public Client(int id, string name, string surname)
        {
            Id = id;
            Name = name;
            Surname = surname;
        }
    }

    internal class EventPurchase : IEvent
    {
        public IState State { get; set; }
        public IClient Client { get; set; }
        public DateTime PurchaseDate { get; set; }
        public EventPurchase(IState state, IClient client)
        {
            State = state;
            Client = client;
        }
    }

    internal class EventReturn : IEvent
    {
        public IState State { get; set; }
        public IClient Client { get; set; }
        public DateTime PurchaseDate { get; set; }
        public EventReturn(IState state, IClient client)
        {
            State = state;
            Client = client;
        }
    }

    internal class Product : IProduct
    {
        public int Id { get; set; }
        public double Price { get; set; }
        public string Category { get; set; }

        public Product(int id, double price, string category)
        {
            Id = id;
            Price = price;
            Category = category;
        }
    }

    internal class State : IState
    {
        public IProduct Product { get; set; }

        public State(IProduct _product)
        {
            Product = _product;
        }
    }
}
