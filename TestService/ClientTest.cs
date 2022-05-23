using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestService
{
    internal class ClientTest : IClient
    {
        public int ClientID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public ClientTest(int clientId, string name, string surname)
        {
            ClientID = clientId;
            Name = name;
            Surname = surname;
        }
    }
}
