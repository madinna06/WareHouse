using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WareHouse1
{
    public abstract class WareHouse : IWareHouse
    {
        public List <Product> Products = new List <Product>();

        public List<Worker> workers = new List<Worker>();
        public double Square { get; set; }
        public string Address { get; set; }

        public virtual bool AddProduct(Product product, int count)
        {
            foreach (var a in Products)
            {
               if (a.Name == product.Name)
            {
                Product.Where(u => u.Name == product.Name).ToList().ForEach(i => i.Count += count);
                return true;
            }
            else
            {
                Products.Add(product);
                Product.Where(u => u.Name == product.Name).ToList().ForEach(i => i.Count += count);
                return false;
            }  
            }
           
        }

        public virtual bool MoveProduct()
        {
            if ()

            {
              
                return true;
            }
            else { return false; }
        }

        public string SearchBySKU(int Sku)
        {
            foreach (var p in Products)
            {
                    if (p.SKU == Sku)
        {
                return p.Name;
        }
        else
        {
                return "Not Found";
        }
            }
        

    }

        public int TotalCost()
        {
            int sum = 0;

            foreach (var i in Products)
            {
                sum += i.Price * i.Count;
            }
            return sum;
        }

        public string ResponsibilityWorker()
        {
            foreach (var n in workers)
            {
                 if (n.Position == "leader")
            {
                return n.WorkerName;
            }
            }
           
        }

    }
}
