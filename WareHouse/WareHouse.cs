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

        public List<Worker> Workers = new List<Worker>();
        public double Square { get; set; }
        
        public virtual bool AddProduct(Product product)
        {
            var result = Products.Where(x => x.Name == product.Name).FirstOrDefault();
               
           if (result == null)
            {
                Products.Add(product); 
                return false;
            }
            else
            {
                int result1 = result.Count + product.Count; 

                return true;
            }
           
        }

        public decimal TotalCost()
        {
            decimal sum = Products.Sum(x => x.Count * x.Price);
            return sum;
        }
        
        public Product SearchBySKU(int Sku)
        {
            if(Products.Any(x => x.SKU == Sku))
            {
                return Products.Where(x => x.SKU == Sku).FirstOrDefault();
            }
            else
            {
                return new Product();
            }

        }
  

        public Worker ResponsibileWorker(string workStation)
        {
            return Workers.Where(x => x.WorkStation == workStation).FirstOrDefault();

        }

        public bool MoveProduct(int count, Product product, IWareHouse warehouse)
        {
            var resultProduct = Products.Where(x => x.Name == product.Name).FirstOrDefault();

            if (resultProduct == null)
            {
                return false;
            }
            
            else
            {
                return true;
            }
        }
    }
}
