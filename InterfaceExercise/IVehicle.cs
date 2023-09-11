using System;
namespace InterfaceExercise
{
	public interface IVehicle
	{
        int NumberOfWheels { get; set; }
        string Color { get; set; }

        void Start();
        void Stop();
    }
}

