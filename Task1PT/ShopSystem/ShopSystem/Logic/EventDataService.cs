using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using ShopSystem.Data;

namespace ShopSystem.Logic
{
    public class EventDataService
    {
        private IRepository irepo;

        public EventDataService(IRepository irepo)
        {
            this.irepo = irepo;
        }

        public void PurchaseProduct(int productId, int clientId)
        {
            Product product = irepo.GetProductById(productId);
            Client client = irepo.GetClientById(clientId);
            State state = new State(product);

            irepo.DeleteProduct(productId);
            irepo.AddEvent(new EventPurchase(state, client));
            irepo.AddState(state);
        }
        //this one belongs to ProductDataService but was added cuz it is essential for what is below to work
        public List<IEvent> GetAllProductEvents(Product product)
        {
            List<IEvent> listofeventinterfaces = new List<IEvent>();

            foreach (IEvent e in irepo.GetAllEvents())
            {
                if (e.State.Product.Equals(product))
                {
                    listofeventinterfaces.Add(e);
                }
            }
            return listofeventinterfaces;
        }


        public void ReturnProduct(Product product, int clientId)
        {
            Client client = irepo.GetClientById(clientId);

            List<IEvent> productEvents = GetAllProductEvents(product);

            if (productEvents.Last<IEvent>() is EventReturn) {throw new Exception("This program is yet to be purchased!!!");}

            State state = new State(product);

            irepo.AddProduct(product);
            irepo.AddEvent(new EventReturn(state, client));
            irepo.AddState(state);
        }
    }
}
