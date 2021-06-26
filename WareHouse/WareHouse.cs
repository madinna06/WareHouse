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
        
        public virtual bool AddProduct(Product product, int count)
        {
            var result = Products.Where(x => x.Name == product.Name).FirstOrDefault();
               
           if (result == null)
            {
                Products.Add(product); 
                return false;
            }
            else
            {
                Products.Where(x => x.Name == product.Name).ToList().ForEach(i => i.Count += count);

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
  

        public Worker ResponsibleWorker(Worker worker)
        {
            //  return Workers.Where(x => x.WorkStation == workStation).FirstOrDefault();

            Worker = worker;
           
                return new Worker();
            





        }

        public bool MoveProduct(int count, Product product, IWareHouse warehouse)
        {
            var resultProduct = Products.Where(x => x.Name == product.Name).FirstOrDefault();

            if (resultProduct == null)
            {
                Console.WriteLine("На складе нет такой товар.");
                return false;
            }
            
            else
            {
                Products.Where(x => x.Name == product.Name).ToList().ForEach(i => i.Count-=count);
                
                warehouse.AddProduct(product, count);
                Console.WriteLine("Товар перемещен на другой склад.");
                return true;
            
            }
                
            
        }

    }
}
