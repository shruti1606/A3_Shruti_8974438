using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A3_Shruti_8974438
{
    // creation of a Car class that inherits from the Vehicle class.
    public class Car : Vehicle
    {
       //Additional properties specific to cars
        public int Seats { get; set; }
        public string EngineType { get; set; }
        public string Transmission { get; set; }
        public bool Convertible { get; set; }

        //Overriding the DisplayDetails() method to display the car's details, including both common vehicle properties and car-specific properties.
        public Car(string model, string manufacturer, int year, decimal rentalPrice, int seats, string engineType, string transmission, bool convertible)
            : base(model, manufacturer, year, rentalPrice)
        {
            Seats = seats;
            EngineType = engineType;
            Transmission = transmission;
            Convertible = convertible;
        }
        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Seats: {Seats}");
            Console.WriteLine($"Engine Type: {EngineType}");
            Console.WriteLine($"Transmission: {Transmission}");
            Console.WriteLine($"Convertible: {Convertible}");
        }
    }
}