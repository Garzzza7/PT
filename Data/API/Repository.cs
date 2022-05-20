using System;
using System.Collections.Generic;

namespace Data
{
    internal class Repository
    {
        internal DataContext DataContext;

        public Repository(IContent content)
        {
            DataContext = new DataContext(
                content.NewClients()
                ,content.NewEvents()
                ,content.NewProducts()
                ,content.NewStates());
        }
    }
}
