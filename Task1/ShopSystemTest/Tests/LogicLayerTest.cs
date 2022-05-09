using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShopSystem.Logic;
using ShopSystem.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using ShopSystem.Logic.API;
using ShopSystem;
namespace ShopSystemTest
{
    [TestClass]
    public class LogicLayerTest
    {


        private LogicLayerAPI logic;
        private Service service;

        [TestInitialize]
        public void testinitialize()
        {
            logic = LogicLayerAPI.CreateLayer();
            service = new Service(logic);

        }
        [TestMethod]
        public void AddProductTest()
        {
            Category cat = Category.books;
            Assert.AreEqual(service.GetAllProducts().Count(), 0);
            service = new Service(logic);
            service.AddProduct(2, 3, cat);
            Assert.AreEqual(service.GetAllProducts().Count(), 1);
        }

        [TestMethod]
        public void DeleteNonExistingProductTest()
        {
            Assert.ThrowsException<KeyNotFoundException>(() => service.DeleteProduct(69420));
        }

        [TestMethod]
        public void test4()
        {
            service = new Service(logic);
            Category cat = Category.books;
            Assert.AreEqual(service.GetAllProducts().Count(), 0);
            service.AddProduct(2, 3, cat);
            service.GetProductById(2);
            Assert.AreEqual(service.GetAllProducts().Count(), 1);
            Assert.AreEqual(service.GetProductById(2).Price, 3);

        }

    }
}