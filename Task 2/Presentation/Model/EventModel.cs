using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2.Model
{
    internal class EventModel
    {
        internal int Id { get; set; }
        internal IState State { get; set; }
        internal IClient Client { get; set; }
        internal DateTime PurchaseDate { get; set; }
    }
}
