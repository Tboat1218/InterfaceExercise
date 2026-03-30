using System;

namespace InterfaceExercise
{
    public class SUV : IVehicle
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
            Console.WriteLine($"SUV: {Year} {Color} {Model}");
            Console.WriteLine($"Wheels: {NumberOfWheels}");
            Console.WriteLine($"Company: {CompanyName}");
            Console.WriteLine($"Logo: {Logo}");
            Console.WriteLine($"Number Of Seats: {NumberOfSeats}");
            Console.WriteLine($"Has Third Row: {HasThirdRow}");
            Console.WriteLine();
        }
    }
}