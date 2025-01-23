using System;
namespace ControlFlow{
    

public class Loops
{
   public  static void Loopno(string[] args)
    {
        Console.WriteLine("FizzBuzz from 1 to 100:\n");

        
        for (int i = 1; i <= 100; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                Console.WriteLine("FizzBuzz");
            } 
            else if (i % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if (i % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            {
                Console.WriteLine(i);
            }
        }
    }
}

public class Fibonacci
{
    public static void Sequence(string[] args)
    {
        
        Console.Write("Enter the number of terms (n) for the Fibonacci sequence: ");
        int n = Convert.ToInt32(Console.ReadLine());

        
        if (n <= 0)
        {
            Console.WriteLine("Please enter a positive integer.");
            return;
        }

        Console.WriteLine($"\nFibonacci sequence up to {n} terms:");

        int first = 0, second = 1;
        int count = 1;

        while (count <= n)
        {
            Console.Write(first + " "); 
            int next = first + second;
            first = second;
            second = next;
            count++;
        }
        Console.WriteLine(); 
    }
}
}