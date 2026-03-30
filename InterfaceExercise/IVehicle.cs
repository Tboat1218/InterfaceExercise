namespace InterfaceExercise
{
    public interface IVehicle : ICompany
    {
        int NumberOfWheels { get; set; }
        string Color { get; set; }
        string Model { get; set; }
        int Year { get; set; }

        void DisplayDetails();
    }
}