using System;
namespace ObjectOrientedProgramming{
// Base class
class Animal
{
    public virtual void Speak()
    {
        Console.WriteLine("The animal makes a sound.");
    }
}

// Derived class
class Dog : Animal // Dog inherits from Animal
{
    public override void Speak()
    {
        Console.WriteLine("The dog barks.");
    }
}

class Animalsound
{
    public static void Mainsound(string[] args)
    {
        // Base class object
        Animal animal = new Animal();
        animal.Speak(); // Calls the base class method

        // Derived class object using base class reference (polymorphism)
        Animal dogAsAnimal = new Dog();
        dogAsAnimal.Speak(); // Calls the overridden method in Dog

        // Derived class object directly
        Dog dog = new Dog();
        dog.Speak(); // Calls the overridden method in Dog
    }
}
public class Vehicle
{
    public string Model { get; set; } 
        public string Make { get; set; }  
    public int Year { get; set; }

    public Vehicle(string model, string make, int year)
    {
        Model = model ?? throw new ArgumentNullException(nameof(model));
        Make = make ?? throw new ArgumentNullException(nameof(make));
        Year = year;
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Model: {Model}, Make: {Make}, Year: {Year}");
    }
}

public class Cars : Vehicle
{
    public string FuelType { get; set; } // Constructor initializes the base class and new property
    public Cars(string model, string make, int year, string fuelType)
        : base(model, make, year)
    {
        FuelType = fuelType ?? throw new ArgumentNullException(nameof(fuelType));
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Fuel Type: {FuelType}");
    }
}
class Vehicledetails
{
    public static void Mainvehicles(string[] args)
    {
        Vehicle vehicle = new Vehicle("GenericModel", "GenericMake", 2000);
        vehicle.DisplayInfo();

        Cars car = new Cars("Corolla", "Toyota", 2021, "Petrol");
        car.DisplayInfo();
    }
}
}