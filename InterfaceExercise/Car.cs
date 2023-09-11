using System;
namespace InterfaceExercise
{
    public class Car : IVehicle, ICompany
    {
        public int NumberOfWheels { get; set; }
        public string Color { get; set; }
        public string Name { get; set; }
        public int YearFounded { get; set; }

        public string TrunkSize { get; set; }
        public string Logo { get; set; }

        public Car(int wheels, string color, string name, int yearFounded, string trunkSize, string logo)
        {
            NumberOfWheels = wheels;
            Color = color;
            Name = name;
            YearFounded = yearFounded;
            TrunkSize = trunkSize;
            Logo = logo;
        }

        public void Start()
        {
            Console.WriteLine("Car is starting.");
        }

        public void Stop()
        {
            Console.WriteLine("Car is stopping.");
        }
    }
}

