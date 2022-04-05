using Microsoft.VisualStudio.TestTools.UnitTesting;
using LogicLayer;
using DataLayer;
using System;
using System.Linq;
using System.Collections.Generic;

namespace UnitTest
{
    [TestClass]
    public class UnitTest
    {
        private IShopAbstractAPI _shopApi;
           
        public UnitTest()
        {
            _shopApi = new ShopConcreteAPI(new FruitConcreteSupplier());
        } 

        [TestMethod]
        public void Test_Purchase_One_Item()
        { 
            var firstProduct = _shopApi.GetProducts().First();

            var invoice = _shopApi.Purchase(new List<Product>() { firstProduct });
             
            Assert.AreEqual(1, invoice.Items.Count);
            Assert.AreEqual(firstProduct.Price, invoice.Items[0].Sum);
            Assert.AreEqual(firstProduct.Price, invoice.Sum);
        }
    }
}