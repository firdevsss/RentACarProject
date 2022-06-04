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

            static void CarDetailsTest()
            {
                CarManager carManager = new CarManager(new EfCarDal());

                var result = carManager.GetCarDetailsDto();

                if (result.Success == true)
                {
                    foreach (var car in carManager.GetCarDetailsDto().Data)
                    {
                        Console.WriteLine(car.CarName + " " + car.BrandName + " " + car.CarName);
                    }
                }

                else
                {
                    Console.WriteLine(result.Message);
                }


            }
        }
    }
}
