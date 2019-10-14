using System;

namespace garys_garage
{
    public class Tesla : Vehicle
    {
        public double BatteryKWh { get; set; }

        // public void ChargeBattery() { ... }
        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Tesla goes Woooosh!");
        }
    }
}