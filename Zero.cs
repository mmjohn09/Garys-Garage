using System;

namespace garys_garage
{
    public class Zero : Vehicle, IElectric
    {
        public double BatteryKWh { get; set; }

        // public void ChargeBattery() { ... }
        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Zero goes braaaaaaaappppp!");
        }
        public override void Turn(string direction)
        {
            Console.WriteLine($"The {MainColor} Zero carefully turns {direction}.");
        }
        public override void Stop()
        {
            Console.WriteLine($"The {MainColor} Zero slowly comes to a halt.");
        }

        public void RechargeBattery()
        {
            Console.WriteLine("The Zero is charging.");
        }
    }
}
