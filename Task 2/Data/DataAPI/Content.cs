using System.Collections.Generic;

namespace Data
{
    internal class Content
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
