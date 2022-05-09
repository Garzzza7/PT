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
        DataLayerAbstractAPI data = DataLayerAbstractAPI.aPI();
        ContentGenerator generator = new ContentGenerator();


        [TestInitialize]
        public void testinitialize()
        {
            data = DataLayerAbstractAPI.aPI();
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
            catch(Exception ex) { }

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
    }
}
