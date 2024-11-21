using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo {
    // Class representing a car, derived from the Vehicle class
    internal class Car : Vehicle {
        public string Color { get; protected set; } // Color of the car
        public int Seats { get; protected set; } // Number of seats in the car

        // Constructor to initialize the car properties
        public Car(string owner, int speed, string color, int seats) : base(owner, speed, "Car") {
            Color = color;
            Seats = seats;
        }

        // Override of the EnterVehicle method for the car
        public override string EnterVehicle() {
            return "Entering Car";
        }

        // Override of the ExitVehicle method for the car
        public override string ExitVehicle() {
            return "Exiting Car";
        }

        // Override of the ToString method to provide a string representation of the car
        public override string ToString() {
            return base.ToString() + $", Color: {Color}, Seats: {Seats}";
        }
    }
}   
