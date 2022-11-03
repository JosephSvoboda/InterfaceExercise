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

            var car1 = new Car() { HasTrunk = true, Logo = "Toyota logo", Name = "Toyota", NumOfDoors = 4, NumOfSeats = 6, NumOfTires = 4, TrunkSize = "f cubic feet" };
            var truck1 = new Truck() { NumOfTires = 4, NumOfSeats = 4, NumOfDoors = 4, Name = "Dodge", Logo = "Dodge logo", BedSize = "8 foot", HasBed = true };
            var suv1 = new SUV() { Logo = "Jeep logo", Name = "Jeep", NumOfDoors = 2, NumOfSeats = 2, NumOfTires = 4, HasCargoHold = true, HasSunRoof = true };

            var vehicles = new List<IVehicle>();

            vehicles.Add(car1);
            vehicles.Add(truck1);
            vehicles.Add(suv1);

            foreach (var i in vehicles)
            {
                Console.WriteLine($"Tires: {i.NumOfTires}, Seats: {i.NumOfSeats}, Doors: {i.NumOfDoors}");
            }

        }
    }
}
