using System;
namespace InterfaceExercise
{
    public class SUV : IVehicle, ICompany
    {
        public int NumberOfWheels { get; set; }
        public string Color { get; set; }
        public string Name { get; set; }
        public int YearFounded { get; set; }

        public string CargoHoldSize { get; set; }
        public string Logo { get; set; }

        public SUV(int wheels, string color, string name, int yearFounded, string cargoHoldSize, string logo)
        {
            NumberOfWheels = wheels;
            Color = color;
            Name = name;
            YearFounded = yearFounded;
            CargoHoldSize = cargoHoldSize;
            Logo = logo;
        }

        public void Start()
        {
            Console.WriteLine("SUV is starting.");
        }

        public void Stop()
        {
            Console.WriteLine("SUV is stopping.");
        }
    }
}

