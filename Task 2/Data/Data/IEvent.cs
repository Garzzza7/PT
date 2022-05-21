using System;

namespace Data
{
     public interface IEvent
     {
         int ClientID { get; set; }
         DateTime PurchaseDate { get; set; }
    }
}
