using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_Rental_Management_System
{
    public class RentalAgency
    {
        // Properties
        private Vehicle[] Fleet { get; set; }
        public double TotalRevenue { get; private set; }

        // Constructor
        public RentalAgency(int fleetSize)
        {
            Fleet = new Vehicle[fleetSize];
            TotalRevenue = 0;
        }

        // Method to add vehicles to the fleet
        public void AddVehicle(Vehicle vehicle, int index)
        {
            Fleet[index] = vehicle;
        }

        // Method to remove vehicles from the fleet
        public void RemoveVehicle(int index)
        {
            Fleet[index] = null;
        }

        // Method to rent a vehicle
        public void RentVehicle(int index)
        {
            TotalRevenue += Fleet[index].RentalPrice;
            RemoveVehicle(index);
        }
    }
}
