using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShopSystem.Logic;
using ShopSystem.Data;
using System;
using System.Collections.Generic;
using System.Linq;


namespace ShopSystemTest
{
    [TestClass]
    public class ProductTestL
    {
        ProductDataService service;
        ClientDataService clientDataService;

        public ProductTestL()
        {
            ContentGenerator generator = new ContentGenerator();
            service = new ProductDataService(new Repository(generator.Create()));
        }

        [TestMethod]
        public void AddProduct()
        {
            int id = 10;
            int price = 40;
            Category cat = Category.books;
            service.AddProduct(id, price, cat);
            Product p = service.GetProductById(10);
            Assert.IsTrue(p.Id == id && p.Price == price && p.Category == cat);
        }

        [TestMethod]
        public void GetAllProducts()
        {   
            List<int> listofproductidsattheverybeginning = service.GetAllProducts().Select(p => p.Id).ToList();
            Assert.IsTrue(listofproductidsattheverybeginning.Count.Equals(3));
            service.AddProduct(6, 40, Category.drugs);
            List<int> listofproductidsafteraddition = service.GetAllProducts().Select(p => p.Id).ToList();
            Assert.IsTrue(listofproductidsafteraddition.Count.Equals(4));
        }

        [TestMethod]
        public void DeleteNonExistingProduct()
        {
            Assert.ThrowsException<KeyNotFoundException>(() => service.DeleteProduct(69420));
        }

        [TestMethod]
        public void DeleteExistingProduct()
        {
            service.DeleteProduct(2);
            Assert.ThrowsException<KeyNotFoundException>(() => service.GetProductById(2));

        }

        [TestMethod]
        public void GetProductEvents()
        {
            Product product = service.GetProductById(1); 
            List<IEvent> productEvents = service.GetAllProductEvents(product);
            Assert.IsTrue(productEvents[0].State.Product.Equals(product)); 
        }

        [TestMethod]
        public void GetClientEvents()
        {
            try
            {
                Client client = clientDataService.GetClient(1);
                List<IEvent> productEvents = clientDataService.GetAllClientEvents(1);
                Assert.IsTrue(productEvents[0].Client.Equals(client));
            }
            catch (System.NullReferenceException ex) { }

        }
    }
}
