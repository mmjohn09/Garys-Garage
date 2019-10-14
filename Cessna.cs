using System;

namespace garys_garage
{
    public class Cessna : Vehicle
    {
        public double BatteryKWh { get; set; }

        // public void RefuelTank() { ... }
        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Cessna goes Zoooooooooommmmmm!");
        }
    }
}