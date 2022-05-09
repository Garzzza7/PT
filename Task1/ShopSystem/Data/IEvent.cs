using System;

namespace ShopSystem.Data.API
{
     public interface IEvent
    {
         IState State { get; set; }
         IClient Client { get; set; }
         DateTime PurchaseDate { get; set; }

    }
}
