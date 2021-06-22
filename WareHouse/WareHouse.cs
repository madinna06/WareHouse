using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WareHouse1
{
    public abstract class WareHouse : IWareHouse
    {
        public List<Product> Product { get; set; } = new List<Product>();
        public double Square { get; set; }
        public  Worker ResponsibilityWorker { get; set; }
        public AddressWareHouse Address { get; set; }

        public virtual bool AddProduct(string product, int count)
        {
            if (Product.Any(u => u.Name == product.Name))
            {
                Product.Where(u => u.Name == product.Name).ToList().ForEach(i => i.Count += count);
                return true;
            }
            else
            {
                Product.Add(product);
                Product.Where(u => u.Name == product.Name).ToList().ForEach(i => i.Count += count);
                return false;
            }
        }

        public virtual bool MoveProduct()
        {
            if (Product.Any(u => u.SKU == Sku))

            {
                warehouse.IsAddProduct(product, count);
                Product.Where(u => u.SKU == Sku).ToList().ForEach(i => i.Count -= count);
                Product.RemoveAll(u => u.SKU == Sku);
                return true;
            }
            else { return false; }
        }

        public string SearchBySKU(int Sku)
        {
        if (SKU == Sku)
        {
                return Sku;
        }
        else
        {
                return "Not Found";
        }

    }

        public int TotalCost()
        {
            int sum = 0;

            foreach (var i in Product)
            {
                sum += i.Price * i.Count;
            }
            return sum;
        }

        public string ResponsibilityWorker(string position)
        {
            if(position == "leader")
            {
                return WorkerName;
            }
        }

    }
}
