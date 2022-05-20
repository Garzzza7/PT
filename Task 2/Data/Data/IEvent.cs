using System;

namespace Data
{
     public interface IEvent
     {
         IClient Client { get; set; }
         DateTime PurchaseDate { get; set; }
    }
}
