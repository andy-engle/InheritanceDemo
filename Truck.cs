using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo {
    // Class representing a truck, derived from the Vehicle class
    internal class Truck : Vehicle {
        public int Capacity { get; protected set; } // Capacity of the truck
        public string Cargo { get; protected set; } // Cargo carried by the truck

        // Constructor to initialize the truck properties
        public Truck(string owner, int speed, int capacity, string cargo) : base(owner, speed, "Truck") {
            Capacity = capacity;
            Cargo = cargo;
        }

        // Override of the EnterVehicle method for the truck
        public override string EnterVehicle() {
            return "Entering Truck";
        }

        // Override of the ExitVehicle method for the truck
        public override string ExitVehicle() {
            return "Exiting Truck";
        }

        // Override of the ToString method to provide a string representation of the truck
        public override string ToString() {
            return base.ToString() + $", Capacity: {Capacity}, Cargo: {Cargo}";
        }
    }
}
