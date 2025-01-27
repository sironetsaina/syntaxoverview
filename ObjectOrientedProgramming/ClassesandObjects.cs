using System;
using System.Collections.Generic;  //  use List<T>

namespace ObjectOrientedProgramming
{
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public Car(string make, string model, int year)
        {
            Make = make;
            Model = model;
            Year = year;
        }

        public void PrintDetails()
        {
            Console.WriteLine($"Make: {Make}, Model: {Model}, Year: {Year}");
        }
    }

    public class Cardetails
    {
        public static void Maindetails(string[] args)
        {
            List<Car> cars = new List<Car>
            {
                new Car("Toyota", "Corolla", 2020),
                new Car("Honda", "Civic", 2018),
                new Car("Ford", "Mustang", 2021),
                new Car("Chevrolet", "Camaro", 2019),
                new Car("Tesla", "Model 3", 2022)
            };

            Console.WriteLine("List of Cars:");
            foreach (var car in cars)
            {
                car.PrintDetails(); 
            }
        }
    }
   public class Person
    {
        // Properties for Name and Age
        public string Name { get; set; }
        public int Age { get; set; }

        // Constructor to initialize Name and Age
        public Person(string name, int age)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Name cannot be null or empty.", nameof(name));

            Name = name;
            Age = age;
        }

        // Method to display the person's details
        public void PrintDetails()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }

    public class Persondetails
    {
        public static void Mainpersona(string[] args)
        {
            Console.Write("Enter the person's name: ");
            string? inputName = Console.ReadLine();
            string name = inputName ?? "Unknown"; // "Unknown" if null

            Console.Write("Enter the person's age: ");
            int age;
            while (!int.TryParse(Console.ReadLine(), out age) || age < 0)
            {
                Console.WriteLine("Invalid age. Please enter a valid positive integer.");
            }

            //  Person object
            try
            {
                Person person = new Person(name, age);

                // Print the person's details
                Console.WriteLine("\nPerson Details:");
                person.PrintDetails();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}


