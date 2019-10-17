using System;
using System.Collections.Generic;

namespace garys_garage
{
    public class GasStation : IStation<IGasoline>
    {
        public int Capacity { get; set; }
        public GasStation(int capacity)
        {
            Capacity = capacity;
        }

        public void Refuel(List<IGasoline> vehicles)
        {
            if (vehicles.Count <= Capacity)
            {
                foreach (IGasoline vehicle in vehicles)
                {
                    vehicle.RefuelTank();
                }
            }
            else
            {
                Console.WriteLine("Gas station doesn't have enough capacity for you to fill up right now.");
            }
        }
    }
}