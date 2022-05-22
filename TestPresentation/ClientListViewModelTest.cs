using Microsoft.VisualStudio.TestTools.UnitTesting;
using Presentation.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace TestPresentation
{
    [TestClass]
    public class ClientListViewModelTest
    {
        private ClientListViewModel SetViewModel()
        {
            return new ClientListViewModel()
            {
                ClientViewModels = new ObservableCollection<ClientItemViewModel>
                {
                    new ClientItemViewModel(1, "Piotr", "Czapla"),
                    new ClientItemViewModel(2, "Piotr", "Hynasiński")
                }
            };
        }

        [TestMethod]
        public void InitialModelTest()
        {
            var clientListViewModel = SetViewModel();

            Assert.IsNull(clientListViewModel.SelectedVM);
            Assert.IsNotNull(clientListViewModel.AddCommand);
            Assert.IsNotNull(clientListViewModel.DeleteCommand);
        }

        [TestMethod]
        public void CountModelTest()
        {
            var clientListViewModel = SetViewModel();

            Assert.IsNotNull(clientListViewModel.ClientViewModels);
            Assert.AreEqual(clientListViewModel.ClientViewModels.Count, 2);
        }

        [TestMethod]
        public void DeleteTest()
        {
            var clientListViewModel = SetViewModel();
            clientListViewModel.SelectedVM = null;

            var deleteCommand = clientListViewModel.DeleteCommand;

            bool can = clientListViewModel.IsClientViewModelSelected;

            Assert.IsFalse(deleteCommand.CanExecute(can));
        }
    }
}
