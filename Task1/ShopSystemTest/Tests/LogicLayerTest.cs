using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShopSystem.Logic;
using ShopSystem.Data;
using System;
using System.Collections.Generic;
using System.Linq;


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
        public void Addclienttest()
        {
            
            service.AddClient(2, "Jamie", "Olivier");
            Assert.AreEqual(service.GetClient(2).Name, "Jamie");
            Assert.AreEqual(service.GetAllClients().Count(), 1);
        }

        [TestMethod]
        public void RemoveClienttest()
        {
            Assert.AreEqual(service.GetAllClients().Count(), 0);
            service.AddClient(2, "Jamie", "Olivier");
           
        }

        [TestMethod]
        public void test1()
        {

        }

        [TestMethod]
        public void test2()
        {

        }

        [TestMethod]
        public void test3()
        {

        }

        [TestMethod]
        public void test4()
        {

        }

        [TestMethod]
        public void test5()
        {

        }

        [TestMethod]
        public void test6()
        {

        }

        [TestMethod]
        public void test7()
        {

        }


    }
}