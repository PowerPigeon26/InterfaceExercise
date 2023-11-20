using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class Car : ICompany, IVehicle
    {
        public string Model { get; set; }
        public string Make { get; set; }
        public int NumberOfWheels { get; set; }
        public int NumberOfDoors { get; set; }
        public string PaintColor { get; set; }
        public bool HasBackWindShieldWipers { get; set; }
        public string CoolLevel { get; set; }
        public bool DoesRideLow { get; set; }
    }
}
