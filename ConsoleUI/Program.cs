using Business.Concrete;
using DataAccess.Concrete.EntitiyFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class ConsoleUI
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Add(new Car {  Description = "Fiat", DailyPrice = 555, ModelYear = 2005 });
            carManager.Add(new Car {  Description = "Renault", DailyPrice = 11, ModelYear = 2025 });
            carManager.Add(new Car { Description = "a", DailyPrice = 11, ModelYear = 2025 });
            carManager.Add(new Car { Description = "Kia", DailyPrice = -5, ModelYear = 2025 });
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }
        }
    }
}