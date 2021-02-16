using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("Car Id : " + car.CarId + " | Color Id : " + car.ColorId + " | Brand Id : " + car.BrandId + " Daily Price : " + car.DailyPrice + " | Description : " + car.Description + " | Model Year : " + car.ModelYear);
            }

            
            Console.ReadKey();
        }
    }
}
