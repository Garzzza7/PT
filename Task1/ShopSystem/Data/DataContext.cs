using System.Collections.Generic;

using ShopSystem.Data.API;

namespace ShopSystem.Data
{
    internal class DataContext
    {
        public Dictionary<int, IProduct> products = new Dictionary<int, IProduct>();
        public List<IEvent> events = new List<IEvent>();
        public List<IState> states = new List<IState>();
        public List<IClient> clients = new List<IClient>();
    }
}
