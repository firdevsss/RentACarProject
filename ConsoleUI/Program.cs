using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Id + " / " + car.CarName);
            }
            Car car8 = new Car() { Id = 8, BrandId = 2, ColorId = 3, CarName = "car8", Description = "Family car", ModelYear = 2020, DailyPrice = 1500 };
            Car car9 = new Car() { Id = 9, BrandId = 2, ColorId = 3, CarName = "car9", Description = "Race Car", ModelYear = 2020, DailyPrice = 2500 };
            Console.WriteLine("After Adding");
        }
    }
}
