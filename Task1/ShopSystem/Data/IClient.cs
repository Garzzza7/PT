using System;
using System.Collections.Generic;
using System.Text;

namespace ShopSystem.Data
{
    public interface IClient
    {
         int Id { get; set; }
         string Name { get; set; }
         string Surname { get; set; }

    }
}
