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
                if (Products.Where(x => x.Name == product.Name).FirstOrDefault().Count >= count)
                {
                    Products.Where(x => x.Name == product.Name).FirstOrDefault().Count -= count;
                    warehouse.AddProduct(product, count);

                    Console.WriteLine("Товар перемещен на другой склад.");
                }
                else
                {
                    Console.WriteLine("На складе нет данный товар заданном количестве. ");
                }
                return true;
            }
        }

        public void Extention(string name)
        {
            int sku = Products.Where(x => x.Name == name).FirstOrDefault().SKU;
            Console.WriteLine($"{name}, {sku}");

        }
        /*
                public void ProductInTwoWarehouses()
                {
                    foreach (int i in Products)
                    {
                       int s = 0;

                       if (sku >= 2) i.SKU==

                    }

                }
        */ 
        public void ProductInTwoWarehouses()
        {
            throw new NotImplementedException();
        }


        public void Sort() {
            /*           var sortedProducts = from u in Products
                                            orderby u.Count ascending
                                            select u;

                       foreach (Product u in sortedProducts)
                           Console.WriteLine(u.Count);
            */
            var sortedProductsCount=Products.Where(x => x.Count >= 3).OrderBy(x => x.Count);
            var sortedProductsName = Products.OrderBy(u => u.Name);
            var sortedProductsMax3 = Products.OrderByDescending(u => u.Count).ThenBy(u => u.Name);
            int i = 0;
            foreach (var u in sortedProductsMax3)
            {
                if(i == 3) break;
                Console.WriteLine($"{u.Name} - {u.Count}");
                i++;
            }

        }

     
    }
}
