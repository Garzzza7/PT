using System;
using System.Collections.Generic;
using System.Text;

namespace ShopSystem.Data
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public Client(int _id, string _name, string _surname)
        {
            Id = _id;
            Name = _name;
            Surname = _surname;
        }


    }
}
