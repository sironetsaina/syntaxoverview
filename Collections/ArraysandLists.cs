using System;
using System.Collections.Generic;
using System.Linq;
namespace ObjectOrientedProgramming{
class Numbers
{
    public static void Mainnumbers(string[]args)
    {
        //[] initializes an array
        int[] numbers = { 5, 10, 15, 20, 25 };
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        double average = (double)sum / numbers.Length;
        Console.WriteLine($"Sum: {sum}");
        Console.WriteLine($"Average: {average:F2}");
    }
}

class Listno
{
    public static void MainNo(string[]args )
    {
        // Create a List<int> to store numbers
        List<int> numbers = new List<int> { 5, 12, 8, 20, 25, 7 };

        // Calculate the sum of numbers greater than 10
        int sum = numbers.Where(number => number > 10).Sum();

        // Print the result
        Console.WriteLine($"Sum of numbers greater than 10: {sum}");
    }
}


}