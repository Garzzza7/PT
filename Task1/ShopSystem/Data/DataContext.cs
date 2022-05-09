using System;
using System.Collections.Generic;
using System.Text;

namespace ShopSystem.Data
{
    internal class DataContext
    {
        public Dictionary<int, IProduct> products = new Dictionary<int, IProduct>();
        public List<IEvent> events = new List<IEvent>();
        public List<IState> states = new List<IState>();
        public List<IClient> clients = new List<IClient>();

        
        public Dictionary<int, IProduct> Products {
            get { return products; }
        }

        public List<IEvent> Events { 
            get { return events; }
        }

        public List<IState> States { 
            get { return states; }
        }
        public List<IClient> Clients { 
            get { return clients; }
        }
       

    }
}
