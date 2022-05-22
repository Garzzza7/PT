using System;

namespace Data
{
     public interface IEvent
     {
         int EventID { get; set; }
         int ClientID { get; set; }
         int ProductID { get; set; }
         DateTime PurchaseDate { get; set; }
    }
}
