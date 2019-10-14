using System;

namespace garys_garage
{
    public class Tesla : Vehicle
    {
        public double BatteryKWh { get; set; }

        // public void ChargeBattery() { ... }
        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Tesla goes whoooosh!");
        }
        public override void Turn(string direction)
        {
            Console.WriteLine($"The {MainColor} Tesla takes a sharp {direction}.");
        }
        public override void Stop()
        {
            Console.WriteLine($"The {MainColor} Tesla hits the brakes to make a quick stop.");
        }
    }
}