using System;

namespace garys_garage
{
    public class Cessna : Vehicle, IGasoline
    {
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
            Console.WriteLine($"The {MainColor} Cessna lands smoothly on the runway and rolls to a stop.");
        }

        public void RefuelTank()
        {
            Console.WriteLine("The Cessna is refueling.");
        }
    }
}