using System.Collections.Generic;

namespace Data
{
    public interface IContent
    {
        List<IClient> NewClients();
        List<IEvent> NewEvents();
        List<IProduct> NewProducts();
    }

    internal class Content : IContent
    {
        private List<IClient> Clients = new List<IClient> ();
        private List<IEvent> Events = new List<IEvent> ();
        private List<IProduct> Products = new List<IProduct> ();    

        public List<IClient> NewClients()
        {
            return Clients;
        }

        public List<IEvent> NewEvents()
        {
            return Events;  
        }

        public List<IProduct> NewProducts()
        {
            return Products;
        }
    }
}
