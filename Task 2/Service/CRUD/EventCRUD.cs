﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Service.DTO;

namespace Service.CRUD
{
    public class EventCRUD
    {
        private DataLayerAbstractAPI dataLayer;

        public EventCRUD()
        {
            dataLayer = DataLayerAbstractAPI.CreateLayer();
        }

        public EventCRUD(DataLayerAbstractAPI dataLayer)
        {
            this.dataLayer = dataLayer;
        }

        public void AddEvent(int clientId, int productId, DateTime purchaseDate)
        {
            dataLayer.AddEvent(clientId, productId, purchaseDate);
        }

        public void DeleteEvent(int id)
        {
            dataLayer.DeleteEvent(id);
        }

        public void UpdateEventClient(int id, int clientId)
        {
            dataLayer.UpdateEventClient(id, clientId);
        }

        public void UpdateEventProduct(int id, int productId)
        {
            dataLayer.UpdateEventProduct(id, productId);
        }

        public void UpdateEventPurchaseDate(int id, DateTime purchaseDate)
        {
            dataLayer.UpdateEventPurchaseDate(id, purchaseDate); 
        }

        public EventDTO GetEvent(int id)
        {
            return (EventDTO) dataLayer.GetEvent(id);
        }

        public IEnumerable<EventDTO> GetAllEvents()
        {
            var clients = dataLayer.GetAllEvents();
            var result = new List<EventDTO>();

            foreach (var client in clients)
            {
                result.Add((EventDTO) client);
            }

            return result;
        }
    }

}
