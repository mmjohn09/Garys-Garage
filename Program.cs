﻿using System;
using System.Collections.Generic;

namespace garys_garage
{
    class Program
    {
        static void Main(string[] args)
        {
            Zero fxs = new Zero();
            Tesla modelS = new Tesla();
            Cessna mx410 = new Cessna();
            Ram proMaster = new Ram();

            fxs.MainColor = "red";
            fxs.MaximumOccupancy = "1";
            fxs.Drive();
            fxs.Turn("left");
            fxs.Stop();

            modelS.MainColor = "yellow";
            modelS.MaximumOccupancy = "5";
            modelS.Drive();
            modelS.Turn("right");
            modelS.Stop();

            mx410.MainColor = "white";
            mx410.MaximumOccupancy = "8";
            mx410.Drive();
            mx410.Turn("left");
            mx410.Stop();

            proMaster.MainColor = "black";
            proMaster.MaximumOccupancy = "12";
            proMaster.Drive();
            proMaster.Turn("right");
            proMaster.Stop();

            List<IElectric> electricVehicles = new List<IElectric>()
            { modelS, fxs };

            List<IGasoline> gasVehicles = new List<IGasoline>()
            { proMaster, mx410 };

            GasStation speedway = new GasStation(16);
            ElectricStation supercharge = new ElectricStation(1);

            speedway.Refuel(gasVehicles);
            supercharge.Refuel(electricVehicles);
            Console.WriteLine();
        }
    }
}
