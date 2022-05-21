using Presentation.ViewModels.MVVNLight;
using Service.CRUD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Presentation.ViewModels
{
    internal class EventItemViewModel : ViewModelBase
    {
        private int eventID;
        private int clientID;
        private DateTime purchaseDate;

        private EventCRUD service;
        private ICommand updateCommand;

        public EventItemViewModel(int eventID, int clientID, DateTime purchaseDate)
        {
            this.eventID = eventID;
            this.clientID = clientID;
            this.purchaseDate = purchaseDate;
        }

        public EventItemViewModel()
        {
            service = new EventCRUD();
            updateCommand = new RelayCommand(e => { UpdateCatalog(); }, c => CanUpdate);
        }

        public int EventID
        {
            get => eventID;

            set
            {
                eventID = value;
                OnPropertyChanged(nameof(clientID));
            }
        }

        public int ClientID
        {
            get => clientID;
            set
            {
                clientID = value;

                OnPropertyChanged(nameof(clientID));
            }
        }

        public DateTime PurchaseDate
        {
            get => purchaseDate;
            set
            {
                purchaseDate = value;

                OnPropertyChanged(nameof(purchaseDate));
            }
        }

        public ICommand UpdateCommand
        {
            get => updateCommand;
        }

        public bool CanUpdate => !(
            string.IsNullOrWhiteSpace(eventID.ToString()) ||
            string.IsNullOrWhiteSpace(clientID.ToString()) ||
            string.IsNullOrWhiteSpace(purchaseDate.ToString())
        );

        private void UpdateCatalog()
        {
            service.UpdateEventClient(eventID, clientID);
            service.UpdateEventPurchaseDate(eventID, purchaseDate);
        }
    }
}
