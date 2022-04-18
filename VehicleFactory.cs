using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise
{
    class VehicleFactory
    {
        public IVehicle CreateVehicle(string userInput)
        {
            switch (userInput.ToLower())
            {
                case "car":
                    return new Car() { Color = "Green", IsDriveable = true };
                case "motorcycle":
                    return new Motorcycle() { Color = "red", HasHandBrake = true };
                default:
                    return new Car();
            }
            
        }

        public static IVehicle Build(int numberOfWheels)
        {
            switch (numberOfWheels)
            {
                case 2: return new Motorcycle();

                case 4: return new Car();

                default:
                    return new Car(); 
            }

        }
    }
}
