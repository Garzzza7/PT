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

        /*
        public Dictionary<int, Product> Products {
            get { return products; }
        }

        public List<IEvent> Events { 
            get { return events; }
        }

        public List<State> States { 
            get { return states; }
        }
        public List<Client> Clients { 
            get { return clients; }
        }
        */

    }
}
