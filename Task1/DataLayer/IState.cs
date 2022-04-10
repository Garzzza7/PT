using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public interface IState
    {
        string state { get; set; }
        string ShowState();
    }

}

 