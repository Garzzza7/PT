using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{  
    public class Client : IClient
    { 
        public string Name { get; set; }
        public string Surname { get; set; }

        public Client(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }
        override string introduce()
        {
            return Name + " " + Surname;
        }
    } 

}

 