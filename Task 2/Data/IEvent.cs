using System;

namespace Data
{
     public interface IEvent
     {
         IState State { get; set; }
         IClient Client { get; set; }
         DateTime PurchaseDate { get; set; }

    }
}
