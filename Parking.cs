using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Of_December
{
    public enum VehicleType
    {
        Car,
        Motorcycle,
        Truck,
        
    }

    
    public class Vehicle1
    {
        public string LicensePlate { get; }
        public VehicleType Type { get; }

        public Vehicle1(string licensePlate, VehicleType type)
        {
            LicensePlate = licensePlate;
            Type = type;
        }
    }

    
    public class ParkingSpot
    {
        public int SpotNumber { get; }
        public bool IsOccupied { get; set; }
        public Vehicle1 ParkedVehicle { get; set; }

        public ParkingSpot(int spotNumber)
        {
            SpotNumber = spotNumber;
            IsOccupied = false;
            ParkedVehicle = null;
        }

        public void ParkVehicle(Vehicle1 vehicle)
        {
            ParkedVehicle = vehicle;
            IsOccupied = true;
            Console.WriteLine($"Vehicle {vehicle.LicensePlate} parked at spot {SpotNumber}");
        }

        public void RemoveVehicle()
        {
            Console.WriteLine($"Vehicle {ParkedVehicle.LicensePlate} removed from spot {SpotNumber}");
            ParkedVehicle = null;
            IsOccupied = false;
        }
    }

    // Parking
    public class ParkingLot
    {
        private List<ParkingSpot> spots;

        public ParkingLot(int capacity)
        {
            spots = new List<ParkingSpot>();
            for (int i = 1; i <= capacity; i++)
            {
                spots.Add(new ParkingSpot(i));
            }
        }

        public bool ParkVehicle(Vehicle1 vehicle)
        {
            foreach (var spot in spots)
            {
                if (!spot.IsOccupied)
                {
                    spot.ParkVehicle(vehicle);
                    return true;
                }
            }
            Console.WriteLine("Parking lot full. No available spots.");
            return false;
        }

        public void RemoveVehicle(string licensePlate)
        {
            foreach (var spot in spots)
            {
                if (spot.IsOccupied && spot.ParkedVehicle.LicensePlate == licensePlate)
                {
                    spot.RemoveVehicle();
                    return;
                }
            }
            Console.WriteLine($"Vehicle with license plate {licensePlate} not found in the parking lot.");
        }

        public void DisplayParkingStatus()
        {
            Console.WriteLine("Parking Lot Status:");
            foreach (var spot in spots)
            {
                if (spot.IsOccupied)
                {
                    Console.WriteLine($"Spot {spot.SpotNumber}: Occupied by {spot.ParkedVehicle.Type} - {spot.ParkedVehicle.LicensePlate}");
                }
                else
                {
                    Console.WriteLine($"Spot {spot.SpotNumber}: Available");
                }
            }
        
}   }   }
