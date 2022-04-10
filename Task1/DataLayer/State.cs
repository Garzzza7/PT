using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{  
    public class State : IState
    { 
        private string state { get; set; } 

        public State(string _state)
        {
            state= _state;
        }
        public override string ShowState()
        {
            return state;
        }
    } 

}

 