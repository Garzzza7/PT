using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using ShopSystem.Data;

namespace ShopSystem.Logic
{
    public class ClientDataService
    {
        private IRepository irepo;

        public ClientDataService(IRepository irepo) { this.irepo = irepo; }

        public void AddClient(int id, String name, String surname) { irepo.AddClient(new Client(id, name, surname)); }

        public void DeleteClient(Client client) {irepo.DeleteClient(client);}

        public List<Client> GetAllClients() {return irepo.GetAllClients();}

        public Client GetClient(int id) { return irepo.GetClientById(id);}

        public List<IEvent> GetAllClientEvents(int id)
        {
            List<IEvent> listofevents = new List<IEvent>();
            Client client = irepo.GetClientById(id);

            foreach (IEvent events in irepo.GetAllEvents())
            {
                if (events.Client.Equals(client))
                {
                    listofevents.Add(events);
                }
            }
            return listofevents;
        }
    }
}
