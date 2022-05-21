using Data;
using Service.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    internal class ClientCRUD
    {
        private DataLayerAbstractAPI dataLayer;

        internal ClientCRUD()
        {
            dataLayer = DataLayerAbstractAPI.CreateLayer();
        }

        public ClientCRUD(DataLayerAbstractAPI dataLayer)
        {
            this.dataLayer = dataLayer;
        }

        public void AddClient(string name, string surname)
        {
            dataLayer.AddClient(name, surname);
        }

        public void DeleteClient(int id)
        {
            dataLayer.DeleteClient(id);
        }

        public void UpdateClientName(int id, string name)
        {
            dataLayer.UpdateClientName(id, name);
        }

        public void UpdateClientSurname(int id, string surname)
        {
            dataLayer.UpdateClientSurname(id, surname);
        }

        public ClientDTO GetClient(int id)
        {
            return (ClientDTO) dataLayer.GetClient(id);
        }

        public IEnumerable<ClientDTO> GetAllClients()
        {
            var clients = dataLayer.GetAllClients();
            var result = new List<ClientDTO>();

            foreach (var client in clients)
            {
                result.Add((ClientDTO) client);
            }

            return result;
        }
    }
}
