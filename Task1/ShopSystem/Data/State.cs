using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ShopSystem.Data
{
	internal class State:IState
	{
		public Product Product { get; set; }

		public State(Product _product)
		{
			Product = _product;
		}
    }
}

