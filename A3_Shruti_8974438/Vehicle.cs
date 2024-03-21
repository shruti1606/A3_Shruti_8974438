using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A3_Shruti_8974438
{
    //Creation of a class named Vehicle to represent a generic vehicle available for rental
    public abstract class Vehicle
    {
        //Including properties such as Model, Manufacturer, Year and RentalPrice.
        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public int Year { get; set; }
        public decimal RentalPrice { get; set; }

        //Implementing methods to get and set the vehicle's properties
        public Vehicle(string model, string manufacturer, int year, decimal rentalPrice)
        {
            Model = model;
            Manufacturer = manufacturer;
            Year = year;
            RentalPrice = rentalPrice;
        }

        //Implementing a method named DisplayDetails() to display the vehicle's details.
        public virtual void DisplayDetails()
        {
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Manufacturer: {Manufacturer}");
            Console.WriteLine($"Year: {Year}");
            Console.WriteLine($"Rental Price: {RentalPrice}");
        }
    }
}