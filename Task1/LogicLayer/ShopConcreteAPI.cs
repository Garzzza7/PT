using DataLayer;
using System.Linq;

namespace LogicLayer
{
    public class ProductCountAndSum
    {
        public int Count { get; set; }
        public decimal Sum { get; set; }
    }

    public class ShopConcreteAPI : IShopAbstractAPI
    {
        public event Action<PurchaseEvent> OnPurchase;

        private List<Employee> _employees = new List<Employee>();
        private List<Product> _products = new List<Product>(); 
        private List<Invoice> _invoices = new List<Invoice>();

        ISupplier _supplier;

        int _lastInvoiceNumber = 0; 

        public ShopConcreteAPI(ISupplier supplier)
        {
            _employees.Add(new Employee() {  Name = "Jan", Surname = "Kowalski"});
            _employees.Add(new Employee() {  Name = "Aleksandra", Surname = "Nowak"});

            _supplier = supplier;

            _products.AddRange(_supplier.GetProducts());
        }


        public List<Employee> GetEmployees()
        {
            return _employees;
        }

        public List<Invoice> GetInvoices()
        {
            return _invoices;
        }
         
        public List<Product> GetProducts()
        {
            return _products;
        } 

        public ISupplier GetSupplier()
        {
            return _supplier;
        }
         
        public Invoice Purchase(List<Product> products)
        {
            var random = new Random();

            var handlingEmployee = _employees[random.Next(0, _employees.Count)]; 
             
            var invoice = new Invoice();
            invoice.DateTime = DateTime.Now;
            _lastInvoiceNumber++;
            invoice.InvoiceNumber = $"{_lastInvoiceNumber}/{DateTime.Now.ToString("yyyy-MM-dd")}";

            var lineitems = new List<LineItem>();

            Dictionary<string, ProductCountAndSum> productCalculations = new Dictionary<string, ProductCountAndSum>();
              
            foreach(var p in products)
            {
                if (!productCalculations.ContainsKey(p.Name))
                {
                    productCalculations[p.Name] = new ProductCountAndSum();
                }

                productCalculations[p.Name].Count++; 
                productCalculations[p.Name].Sum += p.Price;
            }

            invoice.Items = new List<LineItem>();
            foreach(var (key, val) in productCalculations )
            {
                invoice.Items.Add(new LineItem()
                {
                    ProductName = key,
                    Quantity = val.Count,
                    Sum = val.Sum
                });
            }

            invoice.Sum = invoice.Items.Sum(x => x.Sum);
            invoice.IssuedBy = handlingEmployee;

            OnPurchase?.Invoke(new PurchaseEvent()
            {
                Invoice = invoice,
                DateTime = DateTime.Now
            }); 

            return invoice;
        } 
    }
}