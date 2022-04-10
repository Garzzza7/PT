using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{  
    public class Employee : IEmployee
    { 
        public string Name { get; set; }
        public string Surname { get; set; }

        public Employee(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }
    } 

}

 