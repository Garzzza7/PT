using System;
using System.Collections.Generic;
using System.Linq;
using Data.DataBase;

namespace Data
{
    public abstract class DataLayerAbstractAPI
    {
        public abstract void AddClient(string name, string surname);
        public abstract void DeleteClient(int id);
        public abstract void UpdateClientName(int id, string name);
        public abstract void UpdateClientSurname(int id, string surname);
        public abstract IClient GetClient(int id);
        public abstract IEnumerable<IClient> GetAllClients();
        //////////////////////////////////////////
        public abstract void AddProduct(decimal price, string category);
        public abstract void DeleteProduct(int id);
        public abstract void UpdateProductPrice(int id, decimal price);
        public abstract void UpdateProductCategory(int id, string category);
        public abstract IProduct GetProduct(int id);
        public abstract IEnumerable<IProduct> GetAllProducts();
        //////////////////////////////////////////
        public abstract void AddEvent(int clientId, DateTime purchaseDate);
        public abstract void DeleteEvent(int id);
        public abstract void UpdateEventClient(int id, int clientId);
        public abstract void UpdateEventPurchaseDate(int id, DateTime purchaseDate);
        public abstract IEvent GetEvent(int id);
        public abstract IEnumerable<IEvent> GetAllEvents();

        public static DataLayerAbstractAPI CreateLayer()
        {
            return new DataLayerConcrete();
        }

        public static DataLayerAbstractAPI CreateLayer(string sqlString)
        {
            return new DataLayerConcrete(sqlString);
        }

        private class DataLayerConcrete : DataLayerAbstractAPI
        {
            private DataClasses1DataContext context;
            public DataLayerConcrete()
            {
                context = new DataClasses1DataContext();
            }

            public DataLayerConcrete(string sqlString)
            {
                context = new DataClasses1DataContext(sqlString);
            }

            public override void AddClient(string name, string surname)
            {
                var client = new Client 
                { 
                    ClientID = context.Clients.Count() + 1, 
                    ClientName = name, 
                    ClientSurname = surname 
                };

                context.Clients.InsertOnSubmit(client);
                context.SubmitChanges();
            }

            public override void DeleteClient(int id)
            {
                Client client = context.Clients.FirstOrDefault(x => x.ClientID == id);

                context.Clients.DeleteOnSubmit(client);
                context.SubmitChanges();
            }

            public override void UpdateClientName(int id, string name)
            {
                Client client = context.Clients.FirstOrDefault(x => x.ClientID == id);
                client.ClientName = name;

                context.SubmitChanges();
            }

            public override void UpdateClientSurname(int id, string surname)
            {
                Client client = context.Clients.FirstOrDefault(x => x.ClientID == id);
                client.ClientName = surname;

                context.SubmitChanges();
            }

            public override IClient GetClient(int id)
            {
                return (IClient) context.Clients.FirstOrDefault(x => x.ClientID == id);
            }

            public override IEnumerable<IClient> GetAllClients()
            {
                var clients = from x in context.Clients
                              select (IClient) x;

                return clients;
            }

            //////////////////////////////////////////
            public override void AddProduct(decimal price, string category)
            {
                var product = new Product
                {
                    ProductID = context.Clients.Count() + 1,
                    ProductPrice = price,
                    ProductCategory = category
                };
                context.Products.InsertOnSubmit(product);
                context.SubmitChanges();
            }

            public override void DeleteProduct(int id)
            {
                Product product = context.Products.FirstOrDefault(x => x.ProductID == id);

                context.Products.DeleteOnSubmit(product);
                context.SubmitChanges();
            }

            public override void UpdateProductPrice(int id, decimal price)
            {
                Product product = context.Products.FirstOrDefault(x => x.ProductID == id);
                product.ProductPrice = price;

                context.SubmitChanges();
            }

            public override void UpdateProductCategory(int id, string category)
            {
                Product product = context.Products.FirstOrDefault(x => x.ProductID == id);
                product.ProductCategory = category;

                context.SubmitChanges();
            }

            public override IProduct GetProduct(int id)
            {
                return (IProduct) context.Products.FirstOrDefault(x => x.ProductID == id);
            }

            public override IEnumerable<IProduct> GetAllProducts()
            {
                var products = from x in context.Clients
                               select (IProduct) x;

                return products;
            }
            //////////////////////////////////////////
            public override void AddEvent(int clientId, DateTime purchaseDate)
            {
                Event newEvent = new Event
                {
                    EventID = context.Clients.Count() + 1,
                    ClientID = clientId,
                    Date = purchaseDate
                };
                context.Events.InsertOnSubmit(newEvent);
                context.SubmitChanges();
            }

            public override void DeleteEvent(int id)
            {
                Event thisEvent = context.Events.FirstOrDefault(x => x.EventID == id);

                context.Events.DeleteOnSubmit(thisEvent);
                context.SubmitChanges();
            }

            public override void UpdateEventClient(int id, int clientId)
            {
                Event thisEvent = context.Events.FirstOrDefault(x => x.EventID == id);
                thisEvent.ClientID = clientId;

                context.SubmitChanges();
            }

            public override void UpdateEventPurchaseDate(int id, DateTime purchaseDate)
            {
                Event thisEvent = context.Events.FirstOrDefault(x => x.EventID == id);
                thisEvent.Date = purchaseDate;

                context.SubmitChanges();
            }

            public override IEvent GetEvent(int id)
            {
                return (IEvent) context.Events.FirstOrDefault(x => x.EventID == id);
            }

            public override IEnumerable<IEvent> GetAllEvents()
            {
                var events = from x in context.Events
                             select (IEvent) x;

                return events;
            }
        }
    }
}
