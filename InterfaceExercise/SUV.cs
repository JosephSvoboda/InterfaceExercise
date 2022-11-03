using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class SUV : IVehicle, ICompany
    {
        public bool HasCargoHold { get; set; }
        public bool HasSunRoof { get; set; }
        public int NumOfTires { get; set; }
        public int NumOfDoors { get; set; }
        public int NumOfSeats { get; set; }
        public string Name { get; set; }
        public string Logo { get; set; }
    }
}
