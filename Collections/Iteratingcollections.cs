using System;
using System.Collections.Generic;
namespace ObjectOrientedProgramming {
class Displaycolors
{
    public static void Maincolors(string[]args)
    {
        // List of colors
        List<string> colors = new List<string> { "Red", "Blue", "Green", "Yellow", "Purple" };

        // Iterate over the list and print each color
        Console.WriteLine("List of colors:");
        foreach (string color in colors)
        {
            Console.WriteLine(color);
        }
    }}
 class ProductPriceDisplay
    {
        public static void ShowPrices(string[]args)
        {
            // Dictionary of products and prices
            Dictionary<string, double> products = new Dictionary<string, double>
            {
                { "Apple", 1.20 },
                { "Banana", 0.75 },
                { "Milk", 2.50 },
                { "Bread", 1.80 },
                { "Eggs", 3.00 }
            };

            // Iterate over the dictionary and print each product with its price
            Console.WriteLine("Product Prices:");
            foreach (var item in products)
            {
                Console.WriteLine($"{item.Key}: ${item.Value}");
            }
        }}}