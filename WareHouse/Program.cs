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

            int actions = 1;
            while (actions != 0)
            {              
                    Console.Write(
                    "\n1 - Добавить товар. " +
                    "\n2 - Переместить товар на другой склад. " +
                    "\n3 - Поиск товара. " +
                    "\n4 - Итоговая цена. " +
                    "\n5 - Назначить ответственого сотрудника. " +
                    "\n0 - Stop the process\n ");
                     
                Console.WriteLine("Выберите склад:\n");
                string WareHouseType = Console.ReadLine();

                actions = Convert.ToInt32(Console.ReadLine());

                    if (actions == 1)
                    {
                       if (WareHouseType == "Открытый")
                    {
                       Console.WriteLine(OpenWareHouse1.AddProduct(Product1));
                    }
                       else
                    {
                        Console.WriteLine(CloseWareHouse1.AddProduct(Product1));
                    }
                    
                      
                    }
                    if (actions == 2)
                    {
                        if (WareHouseType == "Открытый")
                    {
                        Console.WriteLine(OpenWareHouse1.MoveProduct(15, Product1, new CloseWareHouse()));
                    }
                        else
                    {
                        Console.WriteLine(CloseWareHouse1.MoveProduct(15, Product1, new OpenWareHouse()));
                    }


                }
                    if (actions == 3)
                    {
                    if (WareHouseType == "Открытый")
                    {
                        Console.WriteLine(OpenWareHouse1.SearchBySKU(1));
                    }
                    else
                    {
                        Console.WriteLine(CloseWareHouse1.SearchBySKU(1));
                    }
                        
                    }
                    if (actions == 4)
                    {
                    if (WareHouseType == "Открытый")
                    {
                        Console.WriteLine(OpenWareHouse1.TotalCost());
                    }
                    else
                    {
                        Console.WriteLine(CloseWareHouse1.TotalCost());
                    }
                        
                    }
                    if (actions == 5)
                    {
                    if (WareHouseType == "Открытый")
                    {
                        Console.WriteLine(OpenWareHouse1.ResponsibileWorker("OpenWareHouse"));
                    }
                    else
                    {
                        Console.WriteLine(CloseWareHouse1.ResponsibileWorker("OpenWareHouse"));
                    }
                   
                    }
                



}
            Console.ReadKey();
        }
    }
}
