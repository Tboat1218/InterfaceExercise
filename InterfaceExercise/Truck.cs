using System;

namespace InterfaceExercise
{
    public class Truck : IVehicle
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
            Console.WriteLine($"Truck: {Year} {Color} {Model}");
            Console.WriteLine($"Wheels: {NumberOfWheels}");
            Console.WriteLine($"Company: {CompanyName}");
            Console.WriteLine($"Logo: {Logo}");
            Console.WriteLine($"Towing Capacity: {TowingCapacity}");
            Console.WriteLine($"Has Bed: {HasBed}");
            Console.WriteLine();
        }
    }
}