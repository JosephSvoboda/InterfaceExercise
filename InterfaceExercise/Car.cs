using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Car : IVehicle, ICompany
    {
        public bool HasTrunk { get; set; }
        public string TrunkSize { get; set; }
        public int NumOfTires { get; set; }
        public int NumOfDoors { get; set; }
        public int NumOfSeats { get; set; }
        public string Name { get; set; }
        public string Logo { get; set; }
    }
}
