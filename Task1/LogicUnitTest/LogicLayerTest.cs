using Microsoft.VisualStudio.TestTools.UnitTesting;
using Logic;

namespace LogicUnitTest
{
    [TestClass]
    internal class TestLogicLayer
    {
        ArtificialDataLayerAPI dataLayer = new ArtificialDataLayerAPI();
        LogicLayerAbstractAPI logicLayer = LogicLayerAbstractAPI.CreateLayer(/*datalayer*/);

        [TestMethod]
        public void RemoveNonExistingClient()
        {

        }

        [TestMethod]
        public void RemoveNonExistingProduct()
        {

        }

        [TestMethod]
        public void RemoveNonExistingEvent()
        {

        }

        [TestMethod]
        public void RemoveNonExistingState()
        {
            
        }
    }
}