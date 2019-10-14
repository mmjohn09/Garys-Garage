using System;

namespace garys_garage
{
    public class Cessna : Vehicle
    {
        public double BatteryKWh { get; set; }

        // public void RefuelTank() { ... }
        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Cessna goes zoooooooooommmmmm!");
        }
        public override void Turn(string direction)
        {
            Console.WriteLine($"The {MainColor} Cessna quickly turns {direction}.");
        }
        public override void Stop()
        {
            Console.WriteLine($"The {MainColor} Cessna gently lands on the runway and rolls to a stop.");
        }
    }
}