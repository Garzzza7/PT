using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public interface IEvent
    {
        Client client { get; set; }

        LineItem lineitem { get; set; }

        State state { get; set; }

        DateTime Timestamp { get; set; }

        string ToString();
    }

}

 