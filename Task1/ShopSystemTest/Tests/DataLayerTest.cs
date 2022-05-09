using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShopSystem.Logic;
using ShopSystem.Data;
using System;
using System.Collections.Generic;
using System.Linq;


namespace ShopSystemTest
{
    [TestClass]
    public class DataLayerTest
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

        [TestMethod]
        public void MakeAPurchase()
        {
            /*
            try
            {
                data.PurchaseProduct(1, 2);
                Assert.ThrowsException<System.NullReferenceException>(() => productDataService.GetProductById(1));
                List<IEvent> productEvents = clientDataService.GetAllClientEvents(2);
                Assert.IsTrue(productEvents[1].Client.Id.Equals(2));
                Assert.IsTrue(productEvents[1].State.Product.Id.Equals(1));
            }
            catch (System.NullReferenceException ex) { }
            */
        }

        [TestMethod]
        public void MakeAReturn()
        {/*
            try
            {
                IProduct thisproductistobereturned = data.GetProductById(1);
                 data.PurchaseProduct(1, 1);
                service.ReturnProduct(thisproductistobereturned, 1);
                List<IEvent> productEvents = clientDataService.GetAllClientEvents(1);
                Assert.IsTrue(productEvents[2].Client.Id.Equals(1));
                Assert.IsTrue(productEvents[2].State.Product.Id.Equals(1));
            }
            catch(NullReferenceException ex) { }
            */
        }
        [TestMethod]
        public void AddProduct()
        {
            try
            {
                int id = 10;
                int price = 40;
                Category cat = Category.books;
                IProduct p = new Test_Product(id, price, cat);
                data.AddProduct(p);
                IProduct t = data.GetProductById(10);
                Assert.IsTrue(p.Id == id && p.Price == price && p.Category == cat);
            }
            catch (Exception ex) { }

        }

        [TestMethod]
        public void GetAllProducts()
        {
            try
            {
                List<int> listofproductidsattheverybeginning = data.GetAllProducts().Select(p => p.Id).ToList();
                Assert.IsTrue(listofproductidsattheverybeginning.Count.Equals(3));
                Category cat = Category.books;
                IProduct p = new Test_Product(1, 2, cat);
                data.AddProduct(p);
                List<int> listofproductidsafteraddition = data.GetAllProducts().Select(p => p.Id).ToList();
                Assert.IsTrue(listofproductidsafteraddition.Count.Equals(4));
            }
            catch (Exception ex) { }

        }

        [TestMethod]
        public void DeleteNonExistingProduct()
        {
            try
            {
                Assert.ThrowsException<KeyNotFoundException>(() => data.DeleteProduct(69420));
            }
            catch { }
        }

        [TestMethod]
        public void DeleteExistingProduct()
        {
            try
            {
                data.DeleteProduct(2);
                Assert.ThrowsException<KeyNotFoundException>(() => data.GetProductById(2));
            }
            catch (Exception ex) { }


        }

        [TestMethod]
        public void GetProductEvents()
        {/*
            IProduct product = data.GetProductById(1);
           
            List<IEvent> productEvents = data.GetAllEvents(product);
            Assert.IsTrue(productEvents[0].State.Product.Equals(product));
            */
        }

        [TestMethod]
        public void GetClientEvents()
        {/*
            try
            {
                IClient client = data.GetClient(1);
                List<IEvent> productEvents = clientDataService.GetAllClientEvents(1);
                Assert.IsTrue(productEvents[0].Client.Equals(client));
            }
            catch (NullReferenceException ex) { }
            */
        }
        /*
        private Repository repository;

        public RepositoryTest()
        {
            ContentGenerator generator = new ContentGenerator();
            repository = new Repository(generator.Create());
        }


        [TestMethod]
        public void CheckInitialState()
        {
            Assert.IsTrue(repository.GetAllClients().Count.Equals(2));
            Assert.IsTrue(repository.GetAllEvents().Count.Equals(2));
            Assert.IsTrue(repository.GetAllStates().Count.Equals(2));
        }

        //ClientTest

        [TestMethod]
        public void AddClients()
        {
            Client client = new Client(6, "John", "Watson");
            repository.AddClient(client);
            Assert.IsTrue(repository.GetClientById(6).Equals(client));
        }

        [TestMethod]
        public void RemoveClient()
        {   
            Client client1 = repository.GetClientById(1);
            repository.DeleteClient(client1);
            Assert.ThrowsException<KeyNotFoundException>(
                () => repository.GetClientById(1));
          
            Client client2 = new Client(3, "K", "M");
            Assert.ThrowsException<KeyNotFoundException>(
                () => repository.DeleteClient(client2));
        }


        [TestMethod]
        public void GetAllClientsIds()
        {
            List<int> idList = repository.GetAllClients().Select(c => c.Id).ToList();
            CollectionAssert.AreEqual(repository.GetAllClientsIds(), idList);
        }

        //ProductTest


        [TestMethod]
        public void AddProduct()
        {
            Product sofa = new Product(10, 25, Category.furniture);
            repository.AddProduct(sofa);
            Assert.IsTrue(repository.GetProductById(10).Equals(sofa));
        }


        [TestMethod] 
        public void RemoveProduct()
        {
            repository.DeleteProduct(2);
            Assert.ThrowsException<KeyNotFoundException>(
                () => repository.GetProductById(2));
        }
        [TestMethod]
        public void NoSuchProductId()
        {
            Assert.IsTrue(repository.NoSuchProductId(2147483647));
            Assert.IsFalse(repository.NoSuchProductId(1));
        }

        [TestMethod]
        public void GetAllProducts()
        {
            List<int> idListFromProducts = repository.GetAllProducts().Select(p => p.Id).ToList();
            List<int> idList = repository.GetAllProductIds().ToList();
            CollectionAssert.AreEqual(idListFromProducts, idList);
        }

        //EventTest


        [TestMethod]
        public void CheckClientPurchaseEvents()
        {   
            Client client = new Client(9, "Sherlock", "Holmes");
            Product product = new Product(15, 90, Category.books);
            State state = new State(product);
            EventPurchase eventPurchase = new EventPurchase(state, client);
            repository.AddEvent(eventPurchase);
            Assert.IsTrue(repository.GetAllEvents().Contains(eventPurchase));
            repository.DeleteEvent(eventPurchase);
            Assert.IsFalse(repository.GetAllEvents().Contains(eventPurchase));
        }

        //StateTest


        [TestMethod]
        public void CheckStates()
        {
            Product product = new Product(69, 420, Category.electronics);
            State state = new State(product);
            Assert.ThrowsException<Exception>(() => repository.DeleteState(state));
            Assert.IsTrue(repository.NoSuchState(state));
            repository.AddState(state);
            Assert.IsTrue(repository.GetAllStates().Contains(state));
            repository.DeleteState(state);
            Assert.IsFalse(repository.GetAllStates().Contains(state));
        }      
        */
    }
}