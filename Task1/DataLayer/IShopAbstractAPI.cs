using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{ 
    public interface IShopAbstractAPI
    {
        public event Action<PurchaseEvent> OnPurchase;
        ISupplier GetSupplier();
        Invoice Purchase(List<Product> products); 
        List<Employee> GetEmployees();
        List<Product> GetProducts();
        List<Invoice> GetInvoices(); 
    }
}
 