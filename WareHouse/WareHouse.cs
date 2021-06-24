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
        public AddressWareHouse Address { get; set; }
        public Worker Worker { get; set; }
        public double Square { get; set; }
        
        public virtual bool AddProduct(Product product)
        {
            var result = Products.Where(x => x.Name == product.Name).FirstOrDefault();
                return true;
           if (result == null)
            {
                Products.Add(product);
            }
            else
            {
            //    Products.Where(x => x.Name == product.Name).ToList().x.Count + product.Count;
            }
           
        }

        public decimal TotalCost()
        {
            decimal sum = Products.Sum(x => x.Count * x.Price);
            return sum;
        }
        
        public Product SearchBySKU(int Sku)
        {
            foreach (var p in Products)
            {
                    if (p.SKU == Sku)
        {
                return Product;
        }
        else
        {
                return "Not Found";
        }
            }
        

    }
  

        public Worker ResponsibilityWorker()
        {
            throw new NotImplementedException();

        }

        public bool MoveProduct(int count, Product product, IWareHouse warehouse)
        {
            throw new NotImplementedException();
        }
    }
}
