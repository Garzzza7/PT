using System;
using System.Collections.Generic;
using System.Text;

namespace ShopSystem.Data
{
     public abstract class IEvent
    {
        private State state;
        private Client client;
        private DateTime purchaseDate;

        public State State => state;
        public Client Client => client;
        public DateTime PurchaseDate => purchaseDate;

        public IEvent(State _state, Client _client)
        {
            state = _state;
            client = _client;
            purchaseDate = DateTime.Now;
        }

    }
}
