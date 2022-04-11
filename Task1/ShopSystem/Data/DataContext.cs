using System;
using System.Collections.Generic;
using System.Text;

namespace ShopSystem.Data
{
    public class DataContext
    {
        private Dictionary<int, Product> products = new Dictionary<int, Product>();
        private List<IEvent> events = new List<IEvent>();
        private List<State> states = new List<State>();
        private List<Client> clients = new List<Client>();

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


    }
}
