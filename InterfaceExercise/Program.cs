using System;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car
            {
                NumberOfWheels = 4,
                Color = "Red",
                Model = "Accord",
                Year = 2022,
                CompanyName = "Honda",
                Logo = "H",
                HasTrunk = true,
                NumberOfDoors = 4
            };

            Truck truck = new Truck
            {
                NumberOfWheels = 4,
                Color = "Black",
                Model = "F-150",
                Year = 2023,
                CompanyName = "Ford",
                Logo = "Ford Oval",
                TowingCapacity = 13000,
                HasBed = true
            };

            SUV suv = new SUV
            {
                NumberOfWheels = 4,
                Color = "White",
                Model = "Highlander",
                Year = 2024,
                CompanyName = "Toyota",
                Logo = "Toyota Emblem",
                NumberOfSeats = 7,
                HasThirdRow = true
            };

            car.DisplayDetails();
            truck.DisplayDetails();
            suv.DisplayDetails();
        }
    }
}