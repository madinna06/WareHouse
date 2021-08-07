using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WareHouse1
{
    public abstract class WareHouse : IWareHouse
    {



        public List<Product> Products = new List<Product>();
        public AddressWareHouse Address { get; set; }

        public Worker Worker { get; set; }
        public double Square { get; set; }

        public virtual event EventHandler<ProductEventArgs> Notify = delegate { };

        public virtual void AddProduct(Product product, int count)
        {
            var result = Products.Where(x => x.Name == product.Name).FirstOrDefault();

            if (result == null)
            {
                Products.Add(product);
                Products.Where(x => x.Name == product.Name).FirstOrDefault().Count += count;

            }
            else
            {
                Products.Where(x => x.Name == product.Name).FirstOrDefault().Count += count;

            }

            Notify.Invoke(this, new ProductEventArgs { NameofProduct = product.Name });

        }

        public decimal TotalCost()
        {
            decimal sum = Products.Sum(x => x.Count * x.Price);
            return sum;
        }

        public Product SearchBySKU(int Sku)
        {
            if (Products.Any(x => x.SKU == Sku))
            {
                return Products.Where(x => x.SKU == Sku).FirstOrDefault();
            }
            else
            {
                Console.WriteLine("Продукт не найден. ");
                return new Product();
            }

        }


        public Worker ResponsibleWorker(Worker worker)
        {
            Worker = worker;
            return Worker;
        }


        public Product MoveProduct(int count, Product product, IWareHouse warehouse)
        {
            var resultProduct = Products.Where(x => x.Name == product.Name).FirstOrDefault();

            if (resultProduct.Count >= count)
            {
               resultProduct.Count -= count;
                warehouse.AddProduct(product, count);
                Console.WriteLine("Товар перемещен на другой склад.");
                return new Product();
            }
            else
            {
                 Console.WriteLine("На складе нет данный товар заданном количестве. ");
                 return new Product();
            }
        }
}
}
