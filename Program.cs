namespace InheritanceDemo
{
    internal class Program {
        static void Main(string[] args) {
            // Create a Car object and test its methods
            Car car = new Car("Alice", 120, "Red", 4);
            Console.WriteLine(car.ToString());
            Console.WriteLine(car.EnterVehicle());
            Console.WriteLine(car.ExitVehicle());

            // Create a Truck object and test its methods
            Truck truck = new Truck("Bob", 80, 10000, "Furniture");
            Console.WriteLine(truck.ToString());
            Console.WriteLine(truck.EnterVehicle());
            Console.WriteLine(truck.ExitVehicle());

            // Create a Motorcycle object and test its methods
            Motorcycle motorcycle = new Motorcycle("Charlie", 150, "Yamaha");
            Console.WriteLine(motorcycle.ToString());
            Console.WriteLine(motorcycle.EnterVehicle());
            Console.WriteLine(motorcycle.ExitVehicle());
        }
    }
}
