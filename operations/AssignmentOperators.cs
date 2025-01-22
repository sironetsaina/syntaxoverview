using System;
namespace operations{

    public class Assignment{
public static void Operationassignment(string[]args){
    Console.WriteLine("Enter the first number:");
        int number1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the second number:");
        int number2 = Convert.ToInt32(Console.ReadLine());

        
        Console.WriteLine($"\nInitial values: number1 = {number1}, number2 = {number2}");

        number1 += number2; 
        Console.WriteLine($"Using (+=): number1 = {number1}");

        
        number1 -= number2; 
        Console.WriteLine($"using (-=): number1 = {number1}");

        
        number1 *= number2; 
        Console.WriteLine($"using (*=): number1 = {number1}");


        if (number2 != 0)
        {
            number1 /= number2;
            Console.WriteLine($"using (/=): number1 = {number1}");
        }
        else
        {
            Console.WriteLine("Division by zero is not allowed.");
        }

       
        if (number2 != 0) 
        {
            number1 %= number2; 
            Console.WriteLine($"After modulus of number1 by number2 (%=): number1 = {number1}");
        }
        else
        {
            Console.WriteLine("Modulus by zero is not allowed.");
        }

        
        Console.WriteLine($"\nFinal value of number1: {number1}");
    }
}
public class Swapp{
    public static void Swapnumbers(string[]args){
        Console.WriteLine("Enter the first number:");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the second number:");
        int num2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"\nInitial values: number1 = {num1}, number2 = {num2}");
       num1 += num2;
         num1 *= num2; 
        num2 -= num1;
        Console.WriteLine($"\nAfter swapping: number1 = {num2}, number2 = {num1}");
    }
    }
}
    
