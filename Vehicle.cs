using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo {
    // Abstract base class representing a generic vehicle
    internal abstract class Vehicle {
        private static int currentId = 0; // Static field to generate unique IDs for each vehicle
        public int Id { get; protected set; } // Unique ID for the vehicle
        public string Owner { get; protected set; } // Owner of the vehicle
        public int Speed { get; protected set; } // Speed of the vehicle
        public string Category { get; protected set; } // Category of the vehicle

        // Constructor to initialize the vehicle properties
        protected Vehicle(string owner, int speed, string category) {
            Id = ++currentId;
            Owner = owner;
            Speed = speed;
            Category = category;
        }

        // Abstract method to be implemented by derived classes for entering the vehicle
        public abstract string EnterVehicle();

        // Abstract method to be implemented by derived classes for exiting the vehicle
        public abstract string ExitVehicle();

        // Override of the ToString method to provide a string representation of the vehicle
        public override string ToString() {
            return $"Id: {Id}, Owner: {Owner}, Speed: {Speed}, Category: {Category}";
        }
    }
}
