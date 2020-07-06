using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo follow all comments!! 
             */

            #region Vehicles

            /*
             * DONE - Create an abstract class called Vehicle
             * DONE - The vehicle class shall have three string properties Year, Make, and Model
             * DONE - Set the defaults to something generic in the Vehicle class
             * DONE - Vehicle shall have an abstract method called DriveAbstract with no implementation
             * DONE - Vehicle shall have a virtual method called DriveVirtual with a base implementation.
             */

            /* 
             * DONE - Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * DONE - Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * DONE - Provide the implementations for the abstract methods
             * DONE - Only in the Motorcycle class will you override the virtual drive method
            */

            // DONE - Create a list of Vehicle called vehicles

            var vehicles = new List<Vehicle>();

            /*
             * DONE- Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * - new it up as one of each derived class
             * DONE - Set the properties with object initializer syntax
             */
            Car car1 = new Car() { HasTrunk = true, Make = "Ford", Model = "Escape", Year = 2015 };
            Motorcycle motorcycle1 = new Motorcycle() { HasSideCart = true, Make = "Honda", Model = "Goldwing", Year=2000};
            //Since Vechicle is an ABSTRACT Class you can use the constructor for Car or Motorcycle            
            Vehicle sedan = new Car() { HasTrunk = true, Make = "Honda", Model = "Civic", Year = 2000 };
            Vehicle sportbike = new Motorcycle() { HasSideCart = false, Make = "Suzuki", Model = "GSX-R", Year = 2018 };

            /*
             * DONE - Add the 4 vehicles to the list
             * DONE - Using a foreach loop iterate over each of the properties
             */
            vehicles.Add(car1);
            vehicles.Add(motorcycle1);
            vehicles.Add(sedan);
            vehicles.Add(sportbike);

            //DONE -  Call each of the drive methods for one car and one motorcycle NOTE This was done for all 
            foreach (var vech in vehicles) 
            {
                Console.WriteLine($"Make {vech.Make} -- Model {vech.Model} -- Year {vech.Year}");
                vech.DriveAbstract();
                vech.DriveVirtual();
                Console.WriteLine();
            }

            #endregion            
            Console.ReadLine();
        }
    }
}
