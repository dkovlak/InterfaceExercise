using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */


            //In ICompany

            /*Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //In each of your car, truck, and suv classes

            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values

            List<IVehicle> vehicles = new List<IVehicle>
        {
            new Car(4, "Red", "Car Company", 2000, "Large", "CarLogo"),
            new Truck(6, "Blue", "Truck Company", 1995, "XL", "TruckLogo"),
            new SUV(4, "Black", "SUV Company", 2010, "Spacious", "SUVLogo")
        };

            Console.WriteLine("~~~~~~ Vehicle Information ~~~~~~");
            foreach (var vehicle in vehicles)
            {
                Console.WriteLine($"Type: {vehicle.GetType().Name}");
                Console.WriteLine($"Color: {vehicle.Color}");
                Console.WriteLine($"Number of Wheels: {vehicle.NumberOfWheels}");

                if (vehicle is ICompany companyInfo)
                {
                    Console.WriteLine($"Company Name: {companyInfo.Name}");
                    Console.WriteLine($"Year Founded: {companyInfo.YearFounded}");
                }

                if (vehicle is Car car)
                {
                    Console.WriteLine($"Trunk Size: {car.TrunkSize}");
                }
                else if (vehicle is Truck truck)
                {
                    Console.WriteLine($"Bed Size: {truck.BedSize}");
                }
                else if (vehicle is SUV suv)
                {
                    Console.WriteLine($"Cargo Hold Size: {suv.CargoHoldSize}");
                }

                Console.WriteLine("-----------------------------");
            }
        }
    }
}
