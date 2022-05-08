using System;
using System.Collections.Generic;
using System.Text;

namespace ShopSystem.Data
{
    public  interface IProduct
    {
         int Id { get; set; }
         double Price { get; set; }
         Category Category { get; set; }
    }

}
