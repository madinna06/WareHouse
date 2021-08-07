using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WareHouse1
{
    class Sorted
    {
        public void SortedCountExtention(List<Product> product)
        {
            var sortedProductsCount = product.Where(x => x.Count >= 3).OrderBy(x => x.Count);
        }
        public void SortedNameExtention(List<Product> product)
        {
            var sortedProductsName = product.OrderBy(u => u.Name);
         }
        public void SortedMax3Extention(List<Product> product)
        {
            var sortedProductsMax3 = product.OrderByDescending(u => u.Count).ThenBy(u => u.Name);
            var result = sortedProductsMax3.Take(3);
            /* int i = 0;
             foreach (var u in sortedProductsMax3)
             {
                 if (i == 3) break;
                 Console.WriteLine($"{u.Name} - {u.Count}");
                 i++;
             }
            */

        }
   /*     public void SortedNotBulk (List<Product> product)
        {

            var selectedWareHouse = product.SelectMany(u => u.Languages,
(u, l) => new { User = u, Lang = l })
.Where(u => u.Lang == "английский" && u.User.Age < 28)
.Select(u => u.User);
        }
   
        public void SortedAverageCount(List<Product> product, WareHouse WareHouse1, WareHouse WareHouse2)
        {
            var result = product.WareHouse1.Union(product.WareHouse2);

        }
   */
    }
}
