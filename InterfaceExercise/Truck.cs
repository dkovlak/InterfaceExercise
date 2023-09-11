using System;
namespace InterfaceExercise
{
    public class Truck : IVehicle, ICompany
    {
        public int NumberOfWheels { get; set; }
        public string Color { get; set; }
        public string Name { get; set; }
        public int YearFounded { get; set; }

        public string BedSize { get; set; }
        public string Logo { get; set; }

        public Truck(int wheels, string color, string name, int yearFounded, string bedSize, string logo)
        {
            NumberOfWheels = wheels;
            Color = color;
            Name = name;
            YearFounded = yearFounded;
            BedSize = bedSize;
            Logo = logo;
        }

        public void Start()
        {
            Console.WriteLine("Truck is starting.");
        }

        public void Stop()
        {
            Console.WriteLine("Truck is stopping.");
        }
    }
}

