using System;
namespace Methods {
    public class Summint{
    public static int Add(int a, int b)
    {
        return a + b;
    }
    public static int Add(int a, int b, int c)
    {
        return a + b + c;
    }

    public static void Mainadd(string[] args)
    {
        int result1 = Add(5, 10);
        Console.WriteLine($"The sum of 5 and 10 is: {result1}");

        int result2 = Add(5, 10, 15);
        Console.WriteLine($"The sum of 5, 10, and 15 is: {result2}");
    }
}
 
public class ShapesArea
{
    public static double CalculateArea(double radius)
    {
        return Math.PI * radius * radius; // Area of circle: π * r²
    }

    public static double CalculateArea(double length, double height = 0, double width = 0)
    {
        if (height != 0)
        {
            return 0.5 * length * height;
        }
        else if (width != 0)
        {
            return length * width;
        }
        else
        {
            return Math.PI * length * length; 
        }
    }

    public static void Mainarea(string[] args)
    {
        bool continueRunning = true;

        while (continueRunning)
        {
            
            Console.WriteLine("Enter the shape (circle, rectangle, triangle):");
            string? shape = Console.ReadLine()?.ToLower(); 

            if (string.IsNullOrEmpty(shape))
            {
                Console.WriteLine("Shape input cannot be empty or null.");
                return;
            }

            if (shape == "circle")
            {
                Console.Write("Enter the radius of the circle: ");
                string? radiusInput = Console.ReadLine();
                if (string.IsNullOrEmpty(radiusInput) || !double.TryParse(radiusInput, out double radius))
                {
                    Console.WriteLine("Invalid input for radius.");
                    continue;
                }
                double circleArea = CalculateArea(radius);
                Console.WriteLine($"The area of the circle with radius {radius} is: {circleArea}");
            }
            else if (shape == "rectangle")
            {
                // Get length and width for the rectangle
                Console.Write("Enter the length of the rectangle: ");
                string? lengthInput = Console.ReadLine();
                if (string.IsNullOrEmpty(lengthInput) || !double.TryParse(lengthInput, out double length))
                {
                    Console.WriteLine("Invalid input for length.");
                    continue;
                }

                Console.Write("Enter the width of the rectangle: ");
                string? widthInput = Console.ReadLine();
                if (string.IsNullOrEmpty(widthInput) || !double.TryParse(widthInput, out double width))
                {
                    Console.WriteLine("Invalid input for width.");
                    continue;
                }

                double rectangleArea = CalculateArea(length, width: width);
                Console.WriteLine($"The area of the rectangle with length {length} and width {width} is: {rectangleArea}");
            }
            else if (shape == "triangle")
            {
                Console.Write("Enter the base of the triangle: ");
                string? baseInput = Console.ReadLine();
                if (string.IsNullOrEmpty(baseInput) || !double.TryParse(baseInput, out double baseLength))
                {
                    Console.WriteLine("Invalid input for base.");
                    continue;
                }

                Console.Write("Enter the height of the triangle: ");
                string? heightInput = Console.ReadLine();
                if (string.IsNullOrEmpty(heightInput) || !double.TryParse(heightInput, out double height))
                {
                    Console.WriteLine("Invalid input for height.");
                    continue;
                }

                double triangleArea = CalculateArea(baseLength, height: height);
                Console.WriteLine($"The area of the triangle with base {baseLength} and height {height} is: {triangleArea}");
            }
            else
            {
                Console.WriteLine("Invalid shape entered.");
            }

            Console.WriteLine("Would you like to calculate the area of another shape? (yes/no): ");
            string? userChoice = Console.ReadLine()?.ToLower();
            if (userChoice != "yes")
            {
                continueRunning = false; 
            }
        }

        Console.WriteLine("Thank you for using the area calculator!");
    }
}
}