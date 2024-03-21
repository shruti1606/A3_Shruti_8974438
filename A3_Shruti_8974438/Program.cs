using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A3_Shruti_8974438
{
    using A3_Shruti_8974438;

    public class Program
    {
        public static void Main(string[] args)
        {
            //To create instances of vehicles
            Vehicle car = new Car("Civic", "Honda", 2020, 50, 5, "Gasoline", "Automatic", false);
            Vehicle truck = new Truck("Silverado", "Chevrolet", 2019, 120, 4, "Pickup", true);
            Vehicle motorcycle = new Motorcycle("Ducati Panigale", "Ducati", 2020, 100, 1100, "Gasoline", true);

            //To Display details of vehicles
            Console.WriteLine("Car Details:");
            car.DisplayDetails();

            Console.WriteLine("\nTruck Details:");
            truck.DisplayDetails();

            Console.WriteLine("\nMotorcycle Details:");
            motorcycle.DisplayDetails();

            //To create an instance of RentalAgency
            RentalAgency agency = new RentalAgency(3);

            //For Adding vehicles to the fleet
            agency.AddVehicle(car, 0);
            agency.AddVehicle(truck, 1);
            agency.AddVehicle(motorcycle, 2);

            //To rent a vehicle
            agency.RentVehicle(car);

            //To display total revenue
            Console.WriteLine($"\nTotal Revenue: {agency.TotalRevenue:C}");
        }
    }
}
