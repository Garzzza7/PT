using ShopSystem.Data.API;

namespace ShopSystem.Data
{
	internal class State : IState
	{
		public IProduct Product { get; set; }

		public State(IProduct _product)
		{
			Product = _product;
		}
    }
}

