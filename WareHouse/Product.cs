using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WareHouse1
{
    public class Product
    {
        public string Name { get; set; }
        public int SKU { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Count { get; set; }

        internal static object Where(Func<object, bool> p)
        {
            throw new NotImplementedException();
        }

    }
}
