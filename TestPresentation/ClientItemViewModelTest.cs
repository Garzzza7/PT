using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Presentation.ViewModels;
using System.Windows.Input;

namespace TestPresentation
{
    [TestClass]
    public class ClientItemViewModelTest
    {
        [TestMethod]
        public void ConstructorTest()
        {
            ClientItemViewModel viewModel = new ClientItemViewModel(10, "Kamil", "Ślimak");

            Assert.AreEqual(10, viewModel.ClientID);
            Assert.AreEqual("Kamil", viewModel.Name);
            Assert.AreEqual("Ślimak", viewModel.Surname);
        }

        [TestMethod]
        public void CanUpdateTest()
        {
            ClientItemViewModel viewModel = new ClientItemViewModel(20, "Janusz", "Kowalski");

            Assert.IsTrue(viewModel.CanUpdate);
        }

        [TestMethod]
        public void CannotUpdateTest()
        {
            ClientItemViewModel viewModel = new ClientItemViewModel(20, "Janusz", "Kowalski");
            viewModel.Name = null;
            viewModel.Surname = null;

            Assert.IsFalse(viewModel.CanUpdate);
        }
    }
}
