using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WareHouse1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Product Product1 = new Product
            {
                Name = "aa",
                SKU = 1,
                Description = "sweet",
                Price = 250,
                Count = 20
            };
            Product Product2 = new Product
            {
                Name = "bb",
                SKU = 2,
                Description = "sweet",
                Price = 250,
                Count = 15
            };
            Worker Worker1 = new Worker
            {
                FirstName = "Mad",
                MiddleName = "Mad",
                LastName = "Mad",
                WorkStation = "OpenWareHouse",
                WorkPosition = "admin"
    };
            AddressWareHouse address = new AddressWareHouse
            {
                Country = "Kazakhstan",
                City = "Almaty",
                Street = "Al-Farabi",
                Number = 71, 
                ZIP = 12000
            };

            OpenWareHouse OpenWareHouse1 = new OpenWareHouse();
            CloseWareHouse CloseWareHouse1 = new CloseWareHouse(); 

            Console.WriteLine("1.Добавить товар. ");
            Console.WriteLine("2.Переместить товар на другой склад. ");
            Console.WriteLine("3.Поиск товара. ");
            Console.WriteLine("4. Итоговая цен");
            Console.WriteLine("5.Назначить ответственого сотрудника.\n");
            string actions = Console.ReadLine();

            

            if (actions == "1")
            {
                Console.WriteLine(OpenWareHouse1.AddProduct(Product1));
            }
            if (actions == "2")
            {
                Console.WriteLine(OpenWareHouse1.MoveProduct (15, Product1, new CloseWareHouse()));

            }
            if (actions == "3")
            {
                Console.WriteLine(OpenWareHouse1.SearchBySKU(1));
            }
            if (actions == "4")
            {
                Console.WriteLine(OpenWareHouse1.TotalCost()); 
            }
            if (actions == "5")
            {
                Console.WriteLine(OpenWareHouse1.ResponsibileWorker("OpenWareHouse"));
            }

           


            Console.ReadKey();
        }
    }
}
