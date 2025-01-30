using System;
using System.Collections.Generic;
namespace ObjectOrientedProgramming{
class DictionaryProgram
{
    public static void Maindictionary(string[]args)
    {
        Dictionary<string, int> studentGrades = new Dictionary<string, int>
        {
            { "Alice", 85 },
            { "Bob", 90 },
            { "Charlie", 78 },
            { "Diana", 92 }
        };

        Console.Write("Enter the student name to retrieve their grade: ");
        string? studentName = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(studentName))
        {
            Console.WriteLine("Student name cannot be null or empty.");
            return;
        }

        if (studentGrades.TryGetValue(studentName, out int grade))
        {
            Console.WriteLine($"{studentName}'s grade is: {grade}");
        }
        else
        {
            Console.WriteLine($"Student '{studentName}' not found.");
        }
    }
}
class Numbersfrequency
{
    public static void Mainfrequency(string[]args)
    {
        // Sample list of integers
        List<int> numbers = new List<int> { 1, 2, 2, 3, 3, 3, 4, 4, 4, 4 };

        // Dictionary to store frequency of each number
        Dictionary<int, int> frequencyDict = new Dictionary<int, int>();

        // Loop through each number in the list
        foreach (int number in numbers)
        {
            if (frequencyDict.ContainsKey(number))
            {
                // If the number is already in the dictionary, increment its count
                frequencyDict[number]++;
            }
            else
            {
                // If the number is not in the dictionary, add it with a count of 1
                frequencyDict.Add(number, 1);
            }
        }

        // Output the frequency of each number
        Console.WriteLine("Frequency of each number:");
        foreach (var pair in frequencyDict)
        {
            Console.WriteLine($"{pair.Key}: {pair.Value}");
        }
    }



}}