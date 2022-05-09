using System;

using ShopSystem.Data.API;
using ShopSystem;
namespace ShopSystemTest
{
    internal class Test_Client : IClient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public Test_Client(int _id, string _name, string _surname)
        {
            this.Id = _id;
            this.Name = _name;
            this.Surname = _surname;
        }
    }
    internal class Test_Product : IProduct
    {
        public int Id { get; set; }
        public double Price { get; set; }
        public Category Category { get; set; }
        public Test_Product(int _id, double _price, Category _category)
        {
            this.Id = _id;
            this.Price = _price;
            this.Category = _category;
        }
    }
    internal class Test_State : IState
    {
        public IProduct Product { get; set; }
        public Test_State(IProduct _product)
        {
            this.Product = _product;
        }
    }
    internal class Test_EventPurchase : IEvent
    {
        public IState State { get; set; }
        public IClient Client { get; set; }
        public DateTime PurchaseDate { get; set; }
        public Test_EventPurchase(IState state1, IClient client1)
        {
            this.State = state1;
            this.Client = client1;
        }
    }
}
