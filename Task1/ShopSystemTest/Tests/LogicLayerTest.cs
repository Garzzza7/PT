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
            
        }

        [TestMethod]
        public void RemoveClienttest()
        {

        }
        /*
        [TestMethod]
        public void test()
        {

        }

        [TestMethod]
        public void test()
        {

        }

        [TestMethod]
        public void test()
        {

        }

        [TestMethod]
        public void test()
        {

        }

        [TestMethod]
        public void test()
        {

        }

        [TestMethod]
        public void test()
        {

        }

        [TestMethod]
        public void test()
        {

        }
        */

    }
}