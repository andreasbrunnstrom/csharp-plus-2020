using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Session07FilesExample
{
    class ProductNameComparer : IComparer<Product>
    {
        public int Compare([NotNull] Product x, [NotNull] Product y)
        {
            return x.ProductName.CompareTo(y.ProductName);

            //if (x == null && y == null) return 0;
            //if (x == null) return 1;
            //if (y == null) return -1;

            //if (x.Id > y.Id) return 1;
            //if (y.Id < y.Id) return -1;
        }
    }
}
