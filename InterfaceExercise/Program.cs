using System;

namespace InterfaceExercise
{
    interface ICompany
    {
        public string CompanyName { get; set; }
        public string Logo { get; set; }
    }

    interface IVehicle : ICompany
    {
        public int NumberOfWheels { get; set; }
        public string Color { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        void DisplayDetails();
    }

    class Car : IVehicle
    {
        public int NumberOfWheels { get; set; }
        public string Color { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string CompanyName { get; set; }
        public string Logo { get; set; }

        public bool HasTrunk { get; set; }
        public int NumberOfDoors { get; set; }

        public void DisplayDetails()
        {
            Console.WriteLine(
                $"Car: {Year} {Color} {Model}, Wheels: {NumberOfWheels}, Company: {CompanyName}, Logo: {Logo}, Has Trunk: {HasTrunk}, Doors: {NumberOfDoors}");
        }
    }

    class Truck : IVehicle
    {
        public int NumberOfWheels { get; set; }
        public string Color { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string CompanyName { get; set; }
        public string Logo { get; set; }

        public int TowingCapacity { get; set; }
        public bool HasBed { get; set; }

        public void DisplayDetails()
        {
            Console.WriteLine(
                $"Truck: {Year} {Color} {Model}, Wheels: {NumberOfWheels}, Company: {CompanyName}, Logo: {Logo}, Towing Capacity: {TowingCapacity}, Has Bed: {HasBed}");
        }
    }

    class SUV : IVehicle
    {
        public int NumberOfWheels { get; set; }
        public string Color { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string CompanyName { get; set; }
        public string Logo { get; set; }

        public int NumberOfSeats { get; set; }
        public bool HasThirdRow { get; set; }

        public void DisplayDetails()
        {
            Console.WriteLine(
                $"SUV: {Year} {Color} {Model}, Wheels: {NumberOfWheels}, Company: {CompanyName}, Logo: {Logo}, Seats: {NumberOfSeats}, Has Third Row: {HasThirdRow}");
        }
    }

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