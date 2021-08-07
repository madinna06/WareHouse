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
        }


        public void SortedNotBulk (List<Product> product)
        {
           var result = product.All(u => !(u.Products is BulkProduct));
        }
   
        public void SortedAverageCount(List<Product> product)
        {
            var result = ;
            foreach (var u in result)
            {
                var averageCount = ;
                Console.WriteLine($"{u.Name}, {averageCount}");
            }

        }
   
    }
}
