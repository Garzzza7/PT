using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ShopSystem.Data
{
	public class State
	{
		public Product Product { get; set; }

		public State(Product _product)
		{
			Product = _product;
		}
    }
}

