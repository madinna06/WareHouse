using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WareHouse1
{
    static class Extention
    {
        /* public static void SKUExtention(this Product product, string name)
         {
             int sku = Product.Where(x => x.Name == name).FirstOrDefault().SKU;
             Console.WriteLine($"{name}, {sku}");
         }
         public static void ProductInTwoWarehousesExtention(this WareHouse wareHouse)
         {

         }

         public static void SortedCountExtention(this Product product)
         {
             var sortedProductsCount = Product.Where(x => x.Count >= 3).OrderBy(x => x.Count);
         }
         public static bool SortedNameExtention(this Product product)
         {
             var sortedProductsName = Product.OrderBy(u => u.Name);
             return 
         }
         public static void SortedMax3Extention(this Product product)
         {
             var sortedProductsMax3 = Product.OrderByDescending(u => u.Count).ThenBy(u => u.Name);
             int i = 0;
             foreach (var u in sortedProductsMax3)
             {
                 if (i == 3) break;
                 Console.WriteLine($"{u.Name} - {u.Count}");
                 i++;
             }
         }*/
    }
}
