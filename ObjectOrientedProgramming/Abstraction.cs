using System;
using System.Runtime;
namespace ObjectOrientedProgramming{
public abstract class Appliance
{
    public abstract void TurnOn(); // Abstract method with no implementation
}

public class WashingMachine : Appliance
{
    public override void TurnOn()
    {
        Console.WriteLine("Washing Machine is now ON. Ready to wash clothes.");
    }
}
public class AirConditioner : Appliance
{
    public override void TurnOn()
    {
        Console.WriteLine("Air Conditioner is now ON. Cooling the room.");
    }
}

class Appliances
{
  public   static void Mainappliance(string[] args)
    {
        // Appliance is the variable type and WashingMachine isthe object type 
        Appliance washingMachine = new WashingMachine();
        Appliance airConditioner = new AirConditioner();

        washingMachine.TurnOn();// euntime polymorphism this is because c# looks at the object type at runtime setermining which object type to decide which TurnOn method to call
        airConditioner.TurnOn();
    }
}
public abstract class Employees
{
    public string Name { get; set; }
    public int Id { get; set; }

    // Constructor to initialize Name and Id
    public Employees(string name, int id)
    {
        Name = name;
        Id = id;
    }

    // Abstract method to calculate salary
    public abstract double CalculateSalary();
}

// Derived class FullTimeEmployee
public class FullTimeEmployee : Employees
{
    public double MonthlySalary { get; set; }

    // Constructor to initialize FullTimeEmployee
    public FullTimeEmployee(string name, int id, double monthlySalary)
        : base(name, id) 
    {
        MonthlySalary = monthlySalary;
    }
    public override double CalculateSalary()
    {
        return MonthlySalary;
    }
}
public class PartTimeEmployee : Employees
{
    public double HourlyRate { get; set; }
    public int HoursWorked { get; set; }

    public PartTimeEmployee(string name, int id, double hourlyRate, int hoursWorked)
        : base(name, id) // Call the base class constructor
    {
        HourlyRate = hourlyRate;
        HoursWorked = hoursWorked;
    }

    public override double CalculateSalary()
    {
        return HourlyRate * HoursWorked;
    }
}

// Example usage
class Employeessalary
{
   public static void Mainsalary(string[] args)
    {
        // Create a FullTimeEmployee object
        FullTimeEmployee fullTimeEmployee = new FullTimeEmployee("Ruth Saina", 1, 5000);

        // Create a PartTimeEmployee object
        PartTimeEmployee partTimeEmployee = new PartTimeEmployee("will Smith", 2, 20, 80);

        // Calculate and display salaries
        Console.WriteLine($"{fullTimeEmployee.Name}'s salary: ${fullTimeEmployee.CalculateSalary()}");
        Console.WriteLine($"{partTimeEmployee.Name}'s salary: ${partTimeEmployee.CalculateSalary()}");
    }
}}