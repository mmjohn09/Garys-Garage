using System;

namespace garys_garage
{
    public class Zero : Vehicle
    {
        public double BatteryKWh { get; set; }

        // public void ChargeBattery() { ... }
        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Zero goes Braaaaaaaappppp!");
        }
        public void Vehicle(string color, string occupancy)
        {
            MainColor = color;
            MaximumOccupancy = occupancy;
        }
    }
}
