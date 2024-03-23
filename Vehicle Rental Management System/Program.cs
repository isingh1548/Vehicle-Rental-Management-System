using System;
using Vehicle_Rental_Management_System;

class Program
{
    static void Main(string[] args)
    {
        // Creating instances of different vehicles
        Car car1 = new Car("Civic", "Honda", 2022, 50.0, 5, "V6", "Automatic", false);
        Truck truck1 = new Truck("F150", "Ford", 2020, 80.0, 4, "Pickup", true);
        Motorcycle motorcycle1 = new Motorcycle("Ninja", "Kawasaki", 2021, 40.0, 1000, "Gasoline", true);

        // Displaying vehicle details
        car1.DisplayDetails();
        truck1.DisplayDetails();
        motorcycle1.DisplayDetails();

        // Creating a rental agency
        RentalAgency agency = new RentalAgency(3);

        // Adding vehicles to the agency's fleet
        agency.AddVehicle(car1, 0);
        agency.AddVehicle(truck1, 1);
        agency.AddVehicle(motorcycle1, 2);

        // Renting a vehicle
        agency.RentVehicle(0);

        // Displaying total revenue
        Console.WriteLine($"Total Revenue: ${agency.TotalRevenue}");
    }
}
