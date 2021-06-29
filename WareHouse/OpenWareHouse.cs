using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WareHouse1
{
    public class OpenWareHouse : WareHouse
    {
   
            public override void AddProduct(Product product, int count)
            {
                if(product is BulkProduct)
                {
                Console.WriteLine("Сыпущие продукты добавляйте в другой склад");
                }
                else
                {
                    base.AddProduct(product, product.Count);
                }

        
            }

    }
}
