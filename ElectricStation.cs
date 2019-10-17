using System;
using System.Collections.Generic;

namespace garys_garage
{
    public class ElectricStation : IStation<IElectric>
    {
        public int Capacity { get; set; }
        public ElectricStation(int capacity)
        {
            Capacity = capacity;
        }

        public void Refuel(List<IElectric> vehicles)
        {
            if (vehicles.Count <= Capacity)
            {
                foreach (IElectric vehicle in vehicles)
                {
                    vehicle.RechargeBattery();
                }
            }
            else
            {
                Console.WriteLine("Station doesn't have enough capacity for you to charge up right now.");
            }
        }
    }
}