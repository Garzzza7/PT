using Microsoft.VisualStudio.TestTools.UnitTesting;
using Data;


namespace DataUnitTest
{
    [TestClass]
    public class DataLayerTest
    {
        private ContentGenerator generator;
        private DataLayerAbstractAPI dataLayer;

        [TestInitialize]
        public void Testinitialize()
        {
            generator = new ContentGenerator();
            dataLayer = DataLayerAbstractAPI.CreateLayer(generator);
            generator.Create();

        }

        //ClientTests

        [TestMethod]
        public void AddClientTest()
        {
            IClient client = new Client(3, "Henryk", "Sienkiewicz");
            dataLayer.AddClient(client);
            Assert.AreEqual(dataLayer.GetAllClients().Count, 3);
        }
        
        [TestMethod]
        public void DeleteClientTest()
        {
            dataLayer.DeleteClient(dataLayer.GetClient(1));
            Assert.AreEqual(dataLayer.GetAllClients().Count, 1);
        }


        [TestMethod]
        public void GetClientTest()
        {
            IClient client = dataLayer.GetClient(1);
            Assert.AreEqual("Piotr", client.Name);
        }

        //ProductTests

        [TestMethod]
        public void AddProductTest()
        {
            IProduct product = new Product(10, 50, "food");
            dataLayer.AddProduct(product);
            Assert.AreEqual(dataLayer.GetAllProducts().Count, 4);
        }

        [TestMethod]
        public void DeleteProductTest()
        {
            dataLayer.DeleteProduct(dataLayer.GetProduct(2));
            Assert.AreEqual(dataLayer.GetAllProducts().Count, 2);
        }

        [TestMethod]
        public void GetProductTest()
        {
            IProduct product = dataLayer.GetProduct(0);
            Assert.AreEqual("books", product.Category);
        }

    }
}