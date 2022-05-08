using System;
using System.Collections.Generic;
using System.Text;

namespace ShopSystem.Data
{
     public interface IEvent
    {
         IState State { get; set; }
         IClient Client { get; set; }
         DateTime PurchaseDate { get; set; }

    }
}
