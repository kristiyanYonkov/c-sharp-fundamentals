using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloGitHub
{
    internal class Vehicle
    {
        public string model;
        public string engine;
        public string transmission;
        public int year;

        public Vehicle(string vehicleModel, string vehicleEngine, string vehicleTransmission, int vehicleYear)
        {
            model = vehicleModel; 
            engine = vehicleEngine; 
            transmission = vehicleTransmission;
            year = vehicleYear;
        }

        public void DisplayVehicleInfo()
        {
            Console.Write($"{model}\n{engine}\n{transmission}\n{year}");
        }
    }
}
