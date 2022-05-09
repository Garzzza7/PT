using System;

using ShopSystem.Data.API;

namespace ShopSystem.Data
{
    internal class EventPurchase : IEvent 
    {
       public IState State { get; set; }
        public IClient Client { get; set; }
        public DateTime PurchaseDate { get; set; }
        public EventPurchase(IState state1, IClient client1)
        {
            this.State = state1;
            this.Client = client1;
        }
    }
}
