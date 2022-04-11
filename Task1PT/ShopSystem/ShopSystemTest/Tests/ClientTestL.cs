using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShopSystem.Logic;
using ShopSystem.Data;
using System;
using System.Collections.Generic;
using System.Linq;


namespace ShopSystemTest
{
    [TestClass]
    public class ClientTest
    {
        ClientDataService service;

        public ClientTest()
        {
            ContentGenerator generator = new ContentGenerator();
            service = new ClientDataService(new Repository(generator.Create()));
        }

        //ClientTests

        [TestMethod]
        public void AddClient()
        {
            service.AddClient(3, "Henryk", "Sienkiewicz");
            Assert.AreEqual(service.GetAllClients().Count, 3);
        }

        [TestMethod]
        public void AddClientRepeatedId()
        {
            Assert.ThrowsException<Exception>(() => service.AddClient(2, "DummyName", "DummySurname"));
        }

        [TestMethod]
        public void RemoveClient()
        {
            Client newClient = service.GetClient(1);
            service.DeleteClient(newClient);
            Assert.AreEqual(service.GetAllClients().Count, 1); 
        }

        [TestMethod]
        public void RemoveNonexistentClient()
        {
            Client thisdudedoesnotexists = new Client(69420, "John", "Cena");
            Assert.ThrowsException<KeyNotFoundException>(() => service.DeleteClient(thisdudedoesnotexists));

            Assert.AreEqual(service.GetAllClients().Count, 2);
        }
    }
}
