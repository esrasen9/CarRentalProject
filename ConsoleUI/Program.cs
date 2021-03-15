using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarTest();
        }

        public static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var cars = carManager.GetCarsByBrandId(1);
            foreach (var car in cars.Data)
            {
                Console.WriteLine(car.BrandId);
            }
        }
    }
}
