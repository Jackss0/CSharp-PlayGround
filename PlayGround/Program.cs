using System;
using System.Collections.Generic;
using System.Linq;

namespace PlayGround
{
    class Program
    {
        static void Main(string[] args)
        {
            var cars = new List<Car>
            {
                new Car{Name = "Toyota Grand one", Stock = 4},
                new Car{Name = "Ferrari F1", Stock = 2},
                new Car{Name = "Bugatti Chiron", Stock = 1}
            };

            var carHandler = new CarHandler();
            CarHandler.CarPurchased += CarHandler.OnCarPurchased;

            var availableCars = cars.Select(car => string.Concat(car.Name, $"({car.Stock})"));

            Console.WriteLine("Available cars:");
            foreach (var car in availableCars)
            {
                Console.WriteLine(car);
            }

            //Console.WriteLine($"Cars available: {cars.Select(car => string.Concat(car.Name, $"({car.Stock})"))}");
            Console.WriteLine("Please choose the car do you want to buy");
            var input = Console.ReadLine();

            if(!string.IsNullOrWhiteSpace(input))
                carHandler.BuyCar(input);

            var anotherCarHandler = new AnotherCarHandler();
            anotherCarHandler.BuyCar(input);
        }
    }
}
