using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{

    public interface IInvoice
    {
         DateTime DateTime { get; set; }
         string InvoiceNumber { get; set; }
         List<LineItem> Items { get; set; }
         Employee IssuedBy { get; set; }
         decimal Sum { get; set; }

    }


}
