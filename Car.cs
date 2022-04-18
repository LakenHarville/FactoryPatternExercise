using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise
{
    class Car : IVehicle
    {
        public int Wheels { get; set; }
        public string Color { get; set; }
        public string Make { get; set; }
        public bool IsDriveable { get; set; }

        public void Drive()
        {
            Console.WriteLine($"Not now, I'm driving a {Color} Pontiac.");
        }
    }
}
