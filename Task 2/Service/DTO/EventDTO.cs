using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.DTO
{
    internal class EventDTO
    {
        int EventID { get; set; }    
        int ClientID { get; set; }
        DateTime PurchaseDate { get; set; }
    }
}
