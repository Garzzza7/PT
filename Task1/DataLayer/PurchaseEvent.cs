using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class PurchaseEvent : IEvent
    {
        private Client client { get; set; }

        private  LineItem lineitem { get; set; }

        private State state { get; set; }

        private  DateTime Timestamp { get; set; }

        public PurchaseEvent(Client client,LineItem lineitem,State state,DateTime Timestamp)
        {
            this.client = client;
            this.lineitem = lineitem;
            this.state = state;
            this.Timestamp = Timestamp;
        }
        public override toString()
        {
            return client+","+lineitem+","+state+","+Timestamp;
        }

    }
  
}
