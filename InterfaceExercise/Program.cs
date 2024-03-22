using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car()
            {
                Model = "Chrysler",
                Make = "Concorde",
                NumberOfDoors = 4,
                NumberOfWheels = 4,
                PaintColor = "White",
                HasBackWindShieldWipers = true,
                CoolLevel = "Incredible",
                DoesRideLow = false
            };
            Truck truck1 = new Truck()
            {
                Model = "F-150",
                Make = "Ford",
                NumberOfDoors = 2,
                NumberOfWheels = 4,
                PaintColor = "Yellow",
                HasBackWindShieldWipers = false,
                TruckBedSize = "Mediocre",
                CanOpenRearWindow = true
            };
            SUV sUV1 = new SUV()
            {
                Model = "Malady",
                Make = "Suburu",
                NumberOfDoors = 6,
                NumberOfWheels = 6,
                PaintColor = "Blue",
                HasBackWindShieldWipers = true,
                HasFourWheelDrive = true,
                CanSeatsFoldIntoFloors = true
            };

            List<ICompany> vehicles = new List<ICompany>() { car1, truck1, sUV1 };
            Console.WriteLine("-----Vehicle Information-----");
            foreach (var vehicle in vehicles)
            {
                Console.WriteLine($"Model: {vehicle.Model}");
                Console.WriteLine($"Model: {vehicle.Make}");

                if (vehicle is IVehicle thisVehicle)
                {
                    Console.WriteLine($"Number of doors: {thisVehicle.NumberOfDoors}");
                    Console.WriteLine($"Number of wheels: {thisVehicle.NumberOfWheels}");
                    Console.WriteLine($"Paint color: {thisVehicle.PaintColor}");
                    Console.WriteLine($"Has back windshield wipers: {thisVehicle.HasBackWindShieldWipers}");
                }
                if (vehicle is Car car)
                {
                    Console.WriteLine($"Cool level: {car.CoolLevel}");
                    Console.WriteLine($"Rides low: {car.DoesRideLow}");
                }
                else if (vehicle is Truck truck)
                {
                    Console.WriteLine($"Truck bed size: {truck.TruckBedSize}");
                    Console.WriteLine($"The back window can open: {truck.CanOpenRearWindow}");
                }
                else if (vehicle is SUV sUV)
                {
                    Console.WriteLine($"Has four wheel drive: {sUV.HasFourWheelDrive}");
                    Console.WriteLine($"Seats fold into floor: {sUV.CanSeatsFoldIntoFloors}");
                }
                Console.WriteLine("-------------------------");
            }

            
        }
    }
}
