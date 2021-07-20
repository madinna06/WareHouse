using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WareHouse1
{
    public class OpenWareHouse : WareHouse
    {
        public override event EventHandler<ProductEventArgs> Notify = delegate { };
        public override void AddProduct(Product product, int count)
        {

            try
            {
                if (!(product is BulkProduct))
                {

                    base.AddProduct(product, product.Count);

                    Notify?.Invoke(this, new ProductEventArgs { NameofProduct = product.Name });
                }
                throw new Exception("Сыпущие продукты не добавляйте в открытый склад");       
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Возникло исключение ArgumentOutOfRangeException");
            }
            catch (Exception ex) 
            {
                Console.WriteLine($"Исключение: {ex.Message}");
            }          
        }
        }

    }

