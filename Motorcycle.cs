using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo {
    // Class representing a motorcycle, derived from the Vehicle class
    internal class Motorcycle : Vehicle {
        public string Brand { get; protected set; } // Brand of the motorcycle

        // Constructor to initialize the motorcycle properties
        public Motorcycle(string owner, int speed, string brand) : base(owner, speed, "Motorcycle") {
            Brand = brand;
        }

        // Override of the EnterVehicle method for the motorcycle
        public override string EnterVehicle() {
            return "Entering Motorcycle";
        }

        // Override of the ExitVehicle method for the motorcycle
        public override string ExitVehicle() {
            return "Exiting Motorcycle";
        }

        // Override of the ToString method to provide a string representation of the motorcycle
        public override string ToString() {
            return base.ToString() + $", Brand: {Brand}";
        }
    }
}
