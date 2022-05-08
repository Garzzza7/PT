using System;
using System.Collections.Generic;
using System.Text;

namespace ShopSystem.Data
{
    internal interface IRepository
    {
        IEnumerable<IProduct> GetAllProducts();
        IEnumerable<int> GetAllProductIds();
        IProduct GetProductById(int id);
        void AddProduct(IProduct product);
        void DeleteProduct(int id);



        List<IClient> GetAllClients();
        List<int> GetAllClientsIds();
        IClient GetClientById(int id);
        void AddClient(IClient client);
        void DeleteClient(IClient client);



        List<IEvent> GetAllEvents();
        void AddEvent(IEvent IEvent);
        void DeleteEvent(IEvent IEvent);



        List<IState> GetAllStates();
        void AddState(IState state);
        void DeleteState(IState state);
    }
}
