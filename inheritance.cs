using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Of_December
{

    class Vehicle
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public void Start()
        {
            Console.WriteLine("The vehicle has started.");
        }

        public void Stop()
        {
            Console.WriteLine("The vehicle has stopped.");
        }

    }
    class car : Vehicle
    {

        public int NumberOfDoors { get; set; }

        public void Accelerate()
        {
            Console.WriteLine("The car is accelerating.");
        }
    
    }




}