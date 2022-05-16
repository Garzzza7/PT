using Microsoft.VisualStudio.TestTools.UnitTesting;
using Logic;
using Data;
using System.Collections.Generic;
using NSubstitute;

namespace LogicUnitTest
{
    [TestClass]
    public class TestLogicLayer
    {
        private readonly DataLayerAbstractAPI dataLayer = Substitute.For<DataLayerAbstractAPI>();


        [TestMethod]
        public void AddClientTest()
        {
            LogicLayerAbstractAPI logicLayer = LogicLayerAbstractAPI.CreateLogicLayer(dataLayer);

            logicLayer.AddClient(123456, "Kamil", "Ślimak");
            dataLayer.ClientExists(123456).Returns(true);
            Assert.ThrowsException<System.Exception>(() => logicLayer.AddClient(123456, "Kamil", "Ślimak"));
        }

        [TestMethod]
        public void RemoveClientTest()
        {
            LogicLayerAbstractAPI logicLayer = LogicLayerAbstractAPI.CreateLogicLayer(dataLayer);

            logicLayer.AddClient(123456, "Kamil", "Ślimak");
            dataLayer.ClientExists(123456).Returns(true);
            Assert.ThrowsException<System.Exception>(() => logicLayer.AddClient(123456, "Kamil", "Ślimak"));

            logicLayer.DeleteClient(123456);
            dataLayer.ClientExists(123456).Returns(false);
            Assert.ThrowsException<System.Exception>(() => logicLayer.DeleteClient(123456));
        }

        [TestMethod]
        public void AddProductTest()
        {
            LogicLayerAbstractAPI logicLayer = LogicLayerAbstractAPI.CreateLogicLayer(dataLayer);

            logicLayer.AddProduct(777, 20, "Vegetable");
            dataLayer.ProductExists(777).Returns(true);
            Assert.ThrowsException<System.Exception>(() => logicLayer.AddProduct(777, 20, "Fruit"));
        }

        [TestMethod]
        public void RemoveProductTest()
        {
            LogicLayerAbstractAPI logicLayer = LogicLayerAbstractAPI.CreateLogicLayer(dataLayer);

            logicLayer.AddProduct(777, 20, "Vegetable");
            dataLayer.ProductExists(777).Returns(true);
            Assert.ThrowsException<System.Exception>(() => logicLayer.AddProduct(777, 20, "Fruit"));

            logicLayer.DeleteProduct(777);
            dataLayer.ProductExists(777).Returns(false);
            Assert.ThrowsException<System.Exception>(() => logicLayer.DeleteClient(123456));
        }

    }
}