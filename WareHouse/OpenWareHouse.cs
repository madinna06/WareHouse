using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WareHouse1
{
    class OpenWareHouse : WareHouse, IWareHouse
    {
   
            public override bool AddProduct(Product product, int count)
            {
                if(product is BulkProduct)
                {
                    return false;
                }
                else
                {
                    base.AddProduct(product, count);
                    return true;
                }

        
            }

    }
}
