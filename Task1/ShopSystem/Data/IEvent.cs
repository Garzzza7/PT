using System;
using System.Collections.Generic;
using System.Text;

namespace ShopSystem.Data
{
     public abstract class IEvent
    {
        public State State { get; set; }
        public Client Client { get; set; }
        public DateTime PurchaseDate { get; set; }

        public IEvent(State _state, Client _client)
        {
            State = _state;
            Client = _client;
            PurchaseDate = DateTime.Now;
        }

    }
}
