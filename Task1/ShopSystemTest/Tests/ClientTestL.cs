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
        DataLayerAbstractAPI data = DataLayerAbstractAPI.aPI();
        ContentGenerator generator = new ContentGenerator();


        [TestInitialize]
        public void testinitialize()
        {
            data = DataLayerAbstractAPI.aPI();
        }

        //ClientTests

        [TestMethod]
        public void AddClient()
        {
            try
            {
                IClient client1 = new Test_Client(3, "Henryk", "Sienkiewicz");
                data.AddClient(client1);
                Assert.AreEqual(data.GetAllClients().Count, 3);
            }
            catch (Exception ex)
            {

            }
        }
            
   
            
        

        [TestMethod]
        public void AddClientRepeatedId()
        {
            try
            {
                IClient client1 = new Test_Client(2, "DummyName", "DummySurname");
                Assert.ThrowsException<Exception>(() => data.AddClient(client1));
            }
            catch(Exception ex)
            {

            }

        }

        [TestMethod]
        public void RemoveClient()
        {
            try
            {
                IClient client1 = data.GetClientById(1);

                data.DeleteClient(client1);
                Assert.AreEqual(data.GetAllClients().Count, 1);
            }
            catch(Exception ex) { }
   
        }

        [TestMethod]
        public void RemoveNonexistentClient()
        {
            try
            {
                IClient thisdudedoesnotexists = new Test_Client(69420, "John", "Cena");
                Assert.ThrowsException<KeyNotFoundException>(() => data.DeleteClient(thisdudedoesnotexists));
                Assert.AreEqual(data.GetAllClients().Count, 2);
            }
            catch (Exception ex)
            {

            }

        }
    }
}