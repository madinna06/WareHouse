using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WareHouse1
{
    public class OpenWareHouse : WareHouse
    {
   
            public override bool AddProduct(Product product)
            {
                if(product is BulkProduct)
                {
                    return false;
                }
                else
                {
                    base.AddProduct(product);
                    return true;
                }

        
            }

    }
}
