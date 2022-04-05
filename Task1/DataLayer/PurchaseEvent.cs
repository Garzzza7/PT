using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class PurchaseEvent
    {
        public Invoice Invoice { get; set; }    
        public DateTime DateTime { get; set; }

    }
}
