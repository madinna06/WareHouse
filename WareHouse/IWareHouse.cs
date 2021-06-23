using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WareHouse1
{
    public interface IWareHouse
    {
         bool AddProduct(Product product, int count);
         bool MoveProduct(int Sku, int count, Product product, IWareHouse warehouse);
         string SearchBySKU(int Sku);
         int TotalCost();
         string ResponsibilityWorker(string name);
    }
}