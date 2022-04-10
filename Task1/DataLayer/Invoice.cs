using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{

    public class Invoice : IInvoice
    {
        public DateTime DateTime { get; set; }
        public string InvoiceNumber { get; set; }
        public List<LineItem> Items { get; set; }
        public Employee IssuedBy { get; set; }
        public decimal Sum { get; set; }

    }


}
