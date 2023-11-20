using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class Truck : ICompany, IVehicle
    {
        public string Model { get; set; }
        public string Make { get; set; }
        public int NumberOfWheels { get; set; }
        public int NumberOfDoors { get; set; }
        public string PaintColor { get; set; }
        public bool HasBackWindShieldWipers { get; set; }
        public string TruckBedSize { get; set; }
        public bool CanOpenRearWindow { get; set; }
    }
}
