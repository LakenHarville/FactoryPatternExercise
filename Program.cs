using System;

namespace FactoryPatternExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What vehicle do you want? You can have either a car or motorcycle.");
            string userInput = Console.ReadLine();

            VehicleFactory factory = new VehicleFactory();
            IVehicle myVehicle = factory.CreateVehicle(userInput);

            myVehicle.Drive();

            Console.WriteLine("Making another vehicle!");
            userInput = Console.ReadLine();

            Console.WriteLine("Tell me, would you rather have 2 wheels or 4?");
            var wheels = Console.ReadLine();
            var vehicle = VehicleFactory.Build(Convert.ToInt32(wheels));
            Console.WriteLine($"I see you chose a {vehicle.GetType().Name}!");
            Console.Read();

        }
    }
}
