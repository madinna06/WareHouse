using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WareHouse1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Product Product1 = new Product
            {
                Name = "aa",
                SKU = 1,
                Description = "sweet",
                Price = 250,
                Count = 20
            };
            Product Product2 = new Product
            {
                Name = "bb",
                SKU = 2,
                Description = "sweet",
                Price = 250,
                Count = 15
            };

            OpenWareHouse W = new OpenWareHouse();

            Console.WriteLine(W.AddProduct(Product1));
            Console.WriteLine(W.AddProduct(Product2));

            Console.ReadKey();
        }
    }
}
