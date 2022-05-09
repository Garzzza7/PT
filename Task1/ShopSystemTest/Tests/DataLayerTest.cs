using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using ShopSystem;

using ShopSystem.Data.API;
using ShopSystemTest.Generator;


namespace ShopSystemTest.Data
{
    [TestClass]
    public class DataLayerTest
    {
        ContentGenerator generator;
        DataLayerAbstractAPI data;


        [TestInitialize]
        public void Testinitialize()
        {
            generator = new ContentGenerator();
            data = DataLayerAbstractAPI.aPI(generator);
            generator.Create();

        }

        //ClientTests

        [TestMethod]
        public void AddClient()
        {
            IClient client1 = new Test_Client(3, "Henryk", "Sienkiewicz");
            data.AddClient(client1);
            Assert.AreEqual(data.GetAllClients().Count, 3);
        }
        
        [TestMethod]
        public void AddClientRepeatedId()
        {
            IClient client1 = new Test_Client(2, "DummyName", "DummySurname");
            Assert.ThrowsException<Exception>(() => data.AddClient(client1));
        }

        [TestMethod]
        public void RemoveClient()
        {
            IClient client1 = data.GetClientById(1);
            data.DeleteClient(client1);
            Assert.AreEqual(data.GetAllClients().Count, 1);
        }

        [TestMethod]
        public void RemoveNonexistentClient()
        {
            IClient thisdudedoesnotexists = new Test_Client(69420, "John", "Cena");
            Assert.ThrowsException<KeyNotFoundException>(() => data.DeleteClient(thisdudedoesnotexists));
            Assert.AreEqual(data.GetAllClients().Count, 2);
        }

        [TestMethod]
        public void AddProduct()
        {

            int id = 10;
            int price = 40;
            Category cat = Category.books;
            IProduct p = new Test_Product(id, price, cat);
            data.AddProduct(p);
            IProduct t = data.GetProductById(10);
            Assert.IsTrue(p.Id == id && p.Price == price && p.Category == cat);

        }

        [TestMethod]
        public void DeleteNonExistingProduct()
        {
            Assert.ThrowsException<KeyNotFoundException>(() => data.DeleteProduct(69420));
        }

        [TestMethod]
        public void DeleteExistingProduct()
        {
            data.DeleteProduct(2);
            Assert.ThrowsException<KeyNotFoundException>(() => data.GetProductById(2));


        }
    }
}