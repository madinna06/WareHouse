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
            
            Console.Write("Выберите склад" +
                "\nОткрытый - 1 или Закрытый - 2: ");
            int WareHouseType = Convert.ToInt32(Console.ReadLine());

            int actions = 1;
            while (actions != 0)
            {              
                    Console.Write(
                    "\n1 - Добавить товар. " +
                    "\n2 - Переместить товар на другой склад. " +
                    "\n3 - Поиск товара. " +
                    "\n4 - Итоговая цена. " +
                    "\n5 - Назначить ответственого сотрудника. " +
                    "\n0 - Stop the process. " +
                    "\nВыберите действие: ");
              
                actions = Convert.ToInt32(Console.ReadLine());    
                

               

                    if (actions == 1)
                    {
                       if (WareHouseType == 1)
                    {
                        OpenWareHouse1.AddProduct(Product1, Product1.Count);
                       
                    }
                       else
                    {
                        CloseWareHouse1.AddProduct(Product1, Product1.Count);
                    }
                    Console.WriteLine("Товар добавлен. ");
                      
                    }
                    if (actions == 2)
                    {
                        if (WareHouseType == 1)
                    {
                        OpenWareHouse1.MoveProduct(15, Product1, CloseWareHouse1);
                    }
                        else
                    {
                        CloseWareHouse1.MoveProduct(15, Product1, OpenWareHouse1);
                    }


                }
                    if (actions == 3)
                    {
                    if (WareHouseType == 1)
                    {
                        Product products = OpenWareHouse1.SearchBySKU(1);

                    }
                    else
                    {
                        Product products = CloseWareHouse1.SearchBySKU(1); 
                        
                    }
                        
                    }
                    if (actions == 4)
                    {
                    if (WareHouseType == 1)
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
                    if (WareHouseType == 1)
                    {
                        Worker worker2 = OpenWareHouse1.ResponsibleWorker(Worker1);
                        
                    }
                    else
                    {
                        Worker worker2 = CloseWareHouse1.ResponsibleWorker(Worker1);
                    }
                   
                    }
                



}
            Console.ReadKey();
        }
    }
}
