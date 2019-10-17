using System;

namespace garys_garage
{
    public class Ram : Vehicle, IGasoline
    {  // Gas powered truck
        public double FuelCapacity { get; set; }
        // public void RefuelTank() { ... }
        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Ram goes rummmmmbbblleeeee.");
        }

        public void RefuelTank()
        {
            Console.WriteLine("The Ram is fueling up.");
        }

        public override void Stop()
        {
            Console.WriteLine($"The {MainColor} Ram screeches before stopping.");
        }
    }
}