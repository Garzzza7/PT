using System;
using System.Collections.Generic;
using System.Text;

namespace ShopSystem.Data
{
    public interface IState
    {
         IProduct Product { get; set; }

    }
}
