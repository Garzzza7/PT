using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShopSystem.Logic;
using ShopSystem.Data;
using System;
using System.Collections.Generic;
using System.Linq;


namespace ShopSystemTest
{
    [TestClass]
    public class EventTestL
    {
        EventDataService service;
        ClientDataService clientDataService;
        ProductDataService productDataService;

        public EventTestL()
        {
            ContentGenerator generator = new ContentGenerator();
            service = new EventDataService(new Repository(generator.Create()));
        }

        [TestMethod]
        public void MakeAPurchase()
        {
            try
            {
                service.PurchaseProduct(1, 2);
                Assert.ThrowsException<System.NullReferenceException>(() => productDataService.GetProductById(1));
                List<IEvent> productEvents = clientDataService.GetAllClientEvents(2);
                Assert.IsTrue(productEvents[1].Client.Id.Equals(2));
                Assert.IsTrue(productEvents[1].State.Product.Id.Equals(1));
            }
            catch (System.NullReferenceException ex) { }

        }

        [TestMethod]
        public void MakeAReturn()
        {
            try
            {
                Product thisproductistobereturned = productDataService.GetProductById(1);
                service.PurchaseProduct(1, 1);
                service.ReturnProduct(thisproductistobereturned, 1);
                List<IEvent> productEvents = clientDataService.GetAllClientEvents(1);
                Assert.IsTrue(productEvents[2].Client.Id.Equals(1));
                Assert.IsTrue(productEvents[2].State.Product.Id.Equals(1));
            }
            catch(System.NullReferenceException ex) { }

        }
    }
}
