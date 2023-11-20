using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class SUV : ICompany, IVehicle
    {
        public string Model { get; set; }
        public string Make { get; set; }
        public int NumberOfWheels { get; set; }
        public int NumberOfDoors { get; set; }
        public string PaintColor { get; set; }
        public bool HasBackWindShieldWipers { get; set; }
        public bool HasFourWheelDrive { get; set; }
        public bool CanSeatsFoldIntoFloors {get; set; }
    }
}
