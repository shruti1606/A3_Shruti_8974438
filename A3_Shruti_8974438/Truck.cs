using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A3_Shruti_8974438
{
    //Creation of a class named Truck that inherits from the Vehicle class.
    public class Truck : Vehicle
    {
        //Additional properties specific to trucks
        public int Capacity { get; set; }
        public string TruckType { get; set; }
        public bool FourWheelDrive { get; set; }

        //Constructor
        public Truck(string model, string manufacturer, int year, decimal rentalPrice, int capacity, string truckType, bool fourWheelDrive)
            : base(model, manufacturer, year, rentalPrice)
        {
            Capacity = capacity;
            TruckType = truckType;
            FourWheelDrive = fourWheelDrive;
        }

        //Overriding the DisplayDetails() method to display the truck's details, including both common vehicle properties and truck-specific properties.
        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Capacity: {Capacity}");
            Console.WriteLine($"Truck Type: {TruckType}");
            Console.WriteLine($"Four Wheel Drive: {FourWheelDrive}");
        }
    }
}