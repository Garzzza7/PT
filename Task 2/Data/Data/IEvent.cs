using System;

namespace Data
{
     public interface IEvent
     {
         int Id { get; set; }
         int ClientID { get; set; }
         DateTime PurchaseDate { get; set; }
    }
}
