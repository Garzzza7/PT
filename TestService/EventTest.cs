using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestService
{
    internal class EventTest : IEvent
    {
        public int EventID { get; set; }
        public int ClientID { get; set; }
        public int ProductID { get; set; }
        public DateTime PurchaseDate { get; set; }

        public EventTest(int eventID, int clientID, int productID, DateTime purchaseDate)
        {
            EventID = eventID;
            ClientID = clientID;
            ProductID = productID;
            PurchaseDate = purchaseDate;
        }
    }
}
