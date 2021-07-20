using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WareHouse1
{
    public interface IWareHouse
    {
         void AddProduct(Product product, int count);
         bool MoveProduct(int count, Product product, IWareHouse warehouse);
         Product SearchBySKU(int Sku);
         decimal TotalCost();
         Worker ResponsibleWorker(Worker worker);
         void Extention(string name);
         void ProductInTwoWarehouses();
        
    }
}