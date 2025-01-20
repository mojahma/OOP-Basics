// Create a Car class with properties like Make, Model, and Year.
// Add methods to display car details.
using System;
namespace OOPBasics;

class OOP
{
    public class Car
    {
        // Properties
        public string make { get; set; }
        public string name { get; set; }
        public int year { get; set; }
        
        // Constructor
        public Car(string make, string name, int year)
        {
            this.make = make;
            this.name = name;
            this.year = year;
        }
        
        // Method to display car details
        public void DisplayDetails()
        {
            Console.WriteLine("Car Details");
            Console.WriteLine($"Make: {make}");
            Console.WriteLine($"Model: {name}");
            Console.WriteLine($"Year: {year}");
        }
    }
    static void Main(string[] args)
    {
        // Create an instance of the Car class
        Car myCar = new Car("Toyota", "Camry", 2022);
        myCar.DisplayDetails();
    }
}