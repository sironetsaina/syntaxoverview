using System;
namespace ObjectOrientedProgramming{

class BankAccount
{
    // Private field for balance
    private double _balance;

    // Constructor to initialize the balance
    public BankAccount(double initialBalance)
    {
        if (initialBalance >= 0)
        {
            _balance = initialBalance;
        }
        else
        {
            Console.WriteLine("Initial balance must be non-negative.");
        }
    }

    // Method to deposit money
    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            _balance += amount;
            Console.WriteLine($"Deposited: {amount}, New Balance: {_balance}");
        }
        else
        {
            Console.WriteLine("Deposit amount must be positive.");
        }
    }

    // Method to withdraw money
    public void Withdraw(double amount)
    {
        if (amount > 0 && amount <= _balance)
        {
            _balance -= amount;
            Console.WriteLine($"Withdrew: {amount}, New Balance: {_balance}");
        }
        else
        {
            Console.WriteLine("Invalid withdrawal amount.");
        }
    }

    // Method to get the current balance 
    public double GetBalance()
    {
        return _balance;
    }
}

class BankProgram
{
    public static void MainBank(string[] args)
    {
        // Create a BankAccount object
        BankAccount account = new BankAccount(1000);

        account.Deposit(500);
        account.Withdraw(200);

        Console.WriteLine($"Current Balance: {account.GetBalance()}");
    }
}



class Employee
{
    private double _salary;

    public Employee(double salary)
    {
        if (salary >= 0)
        {
            _salary = salary;
        }
        else
        {
            Console.WriteLine("Salary must be non-negative.");
        }
    }

    public double CalculateAnnualSalaryAfterTax(double taxRate)
    {
        if (taxRate >= 0 && taxRate <= 1)
        {
            double annualSalary = _salary * 12;
            double taxAmount = annualSalary * taxRate;
            return annualSalary - taxAmount;
        }
        else
        {
            Console.WriteLine("Invalid tax rate. Must be between 0 and 1.");
            return 0;
        }
    }

    public double GetSalary()
    {
        return _salary;
    }
}

class employeeProgram
{
   public static void Mainemployee (string[] args)
    {
        Employee employee = new Employee(5000);

        double annualSalaryAfterTax = employee.CalculateAnnualSalaryAfterTax(0.2); // 20% tax rate
        Console.WriteLine($"Annual Salary After Tax: {annualSalaryAfterTax}");

        Console.WriteLine($"Salary: {employee.GetSalary()}");
    }
}


}
