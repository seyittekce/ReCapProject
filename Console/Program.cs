using System;
using Business.Concerte;
using DataAccess.Abstract;
using DataAccess.Concerte.InMemory;
using Entities.Concerte;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description + " " + car.ModelYear + " yılına ait günlük fiyatı " + car.DailyPrice + " TL");
            }

        }
    }
}
