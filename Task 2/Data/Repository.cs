using System;
using System.Collections.Generic;

namespace Data
{
    internal class Repository
    {
        internal DataContext DataContext { get; set; }

        internal Repository(DataContext dataContext)
        {
            DataContext = dataContext;
        }
        internal Repository()
        {
            DataContext = new DataContext();
        }
    }
}
