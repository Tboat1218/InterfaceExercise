using System;

namespace InterfaceExercise
{
    public class Car : IVehicle
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
            Console.WriteLine($"Car: {Year} {Color} {Model}");
            Console.WriteLine($"Wheels: {NumberOfWheels}");
            Console.WriteLine($"Company: {CompanyName}");
            Console.WriteLine($"Logo: {Logo}");
            Console.WriteLine($"Has Trunk: {HasTrunk}");
            Console.WriteLine($"Number Of Doors: {NumberOfDoors}");
            Console.WriteLine();
        }
    }
}