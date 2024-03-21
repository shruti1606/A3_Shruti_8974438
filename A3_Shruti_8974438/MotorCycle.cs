using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A3_Shruti_8974438
{
    //Creation of a class named Motorcycle that inherits from the Vehicle class.
    public class Motorcycle : Vehicle
    {
        //Additional properties specific to motorcycle
        public int EngineCapacity { get; set; }
        public string FuelType { get; set; }
        public bool HasFairing { get; set; }

        //Overriding the DisplayDetails() method to display the Motorcyle's details, including both common vehicle properties and motorcycle-specific properties.
        public Motorcycle(string model, string manufacturer, int year, decimal rentalPrice, int engineCapacity, string fuelType, bool hasFairing)
            : base(model, manufacturer, year, rentalPrice)
        {
            EngineCapacity = engineCapacity;
            FuelType = fuelType;
            HasFairing = hasFairing;
        }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Engine Capacity: {EngineCapacity}");
            Console.WriteLine($"Fuel Type: {FuelType}");
            Console.WriteLine($"Has Fairing: {HasFairing}");
        }
    }
}