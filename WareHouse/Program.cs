using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WareHouse1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product A = new Product
            {
                Name = "aa",
                SKU = 1,
                Description = "sweet",
                Price = 250,
                Count = 20
            };
            Product B = new Product
            {
                Name = "bb",
                SKU = 2,
                Description = "sweet",
                Price = 250,
                Count = 15
            };

            OpenWareHouse W = new OpenWareHouse();

            Console.WriteLine(W.AddProduct(A, 10));
            Console.WriteLine(W.AddProduct(B, 5));

            Console.ReadKey();
        }
    }
}
