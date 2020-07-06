using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public class Car : Vehicle
    { /* 
        * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
        * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
        * Provide the implementations for the abstract methods
        * Only in the Motorcycle class will you override the virtual drive method
      */
        public Car() 
        {
        }
        public bool HasTrunk { get; set; } = true;
        public override void DriveAbstract()
        {
            Console.WriteLine("This car is in park!");
        }
    }
}
