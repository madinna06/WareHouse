using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WareHouse1
{
    static class Extention
    {
         public static void SKUExtention(this List<Product> products, string name)
         {
             int sku = products.Where(x => x.Name == name).FirstOrDefault().SKU;

                Console.WriteLine($"{name}, {sku}");         
         }
        public static void ProductInTwoWarehousesExtention(this WareHouse WareHouse1,  WareHouse WareHouse2)
         {

            var names = WareHouse1.Products.Intersect(WareHouse2.Products);
        }
            
             public static void ProductHalfProductExtention(this WareHouse WareHouse1, WareHouse WareHouse2)
             {
                  var result = WareHouse1.Products.Except(WareHouse2.Products);

             foreach (var u in result)
             { 
                    if (u.Count > 1)
                    {
                        WareHouse2.AddProduct(u, u.Count / 2);
                        WareHouse1.Products.Where(x => x.Name == u.Name).FirstOrDefault().Count -= u.Count / 2;
                    }
             }                 

             }

                         
                       
                   
      
    }
}
