using Microsoft.VisualStudio.TestTools.UnitTesting;
using Data;

namespace DataUnitTest
{
    [TestClass]
    public class DataLayerTest
    {
        //ClientTests

        [TestMethod]
        public void AddClientTest()
        {
            var datalayer = DataLayerAbstractAPI.CreateLayer(new Content());
            IClient client = new Client(3, "Henryk", "Sienkiewicz");
            datalayer.AddClient(client);
            Assert.AreEqual(datalayer.GetAllClients().Count, 1);
        }
        
        [TestMethod]
        public void DeleteClientTest()
        {
            var dataLayer = DataLayerAbstractAPI.CreateLayer(new Content());
            IClient client = new Client(1, "Henryk", "Sienkiewicz");
            dataLayer.AddClient(client);
            dataLayer.DeleteClient(dataLayer.GetClient(1));
            Assert.AreEqual(dataLayer.GetAllClients().Count, 0);
        }


        [TestMethod]
        public void GetClientTest()
        {
            var dataLayer = DataLayerAbstractAPI.CreateLayer(new Content());
            IClient client = new Client(1, "Henryk", "Sienkiewicz");
            dataLayer.AddClient(client);
            IClient client1 = dataLayer.GetClient(1);
            Assert.AreEqual("Henryk", client1.Name);
        }

        //ProductTests

        [TestMethod]
        public void AddProductTest()
        {
            var dataLayer = DataLayerAbstractAPI.CreateLayer(new Content());
            IProduct product = new Product(10, 50, "food");
            dataLayer.AddProduct(product);
            Assert.AreEqual(dataLayer.GetAllProducts().Count, 1);
        }

        [TestMethod]
        public void DeleteProductTest()
        {
            var dataLayer = DataLayerAbstractAPI.CreateLayer(new Content());
            IProduct product1 = new Product(1, 20, "books");
            IProduct product2 = new Product(2, 30, "drugs");
            IProduct product3 = new Product(3, 40, "electronics");

            dataLayer.AddProduct(product1);
            dataLayer.AddProduct(product2);
            dataLayer.AddProduct(product3);
            dataLayer.DeleteProduct(dataLayer.GetProduct(1));
            Assert.AreEqual(dataLayer.GetAllProducts().Count, 2);
        }

        [TestMethod]
        public void GetProductTest()
        {
            var dataLayer = DataLayerAbstractAPI.CreateLayer(new Content());
            IProduct product1 = new Product(0, 20, "books");


            dataLayer.AddProduct(product1);
   

            IProduct product5 = dataLayer.GetProduct(0);
            Assert.AreEqual(20, product5.Price);
            
            IProduct produc6 = dataLayer.GetProduct(0);
            Assert.AreEqual("books", produc6.Category);
        }

    }
}