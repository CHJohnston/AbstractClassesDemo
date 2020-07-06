using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{ /* 
    * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
    * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
    * Provide the implementations for the abstract methods
    * Only in the Motorcycle class will you override the virtual drive method
  */
    public class Motorcycle :Vehicle   
    {
        public Motorcycle()
        { 
        }
        public bool HasSideCart { get; set; } = false;
        public override void DriveAbstract()
        {
            Console.WriteLine($"This motorcycle is in drive!");
        }
        public override void DriveVirtual()
        {
            Console.WriteLine($"This {GetType().Name} is a {GetType().BaseType.Name} that is virtually in drive");
        }
    }
}
