using System;
namespace ObjectOrientedProgramming
{
    // Abstract base class
    public abstract class Shape
    {
        public abstract double Area(); // Abstract method to calculate area
        public abstract string Name(); // Abstract method to get the shape's name
    }

    public class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        // Override the Area method
        public override double Area()
        {
            return Math.PI * Radius * Radius; // Formula for area of a circle
        }

        // Override the Name method
        public override string Name()
        {
            return "Circle"; // Return the name of the shape
        }
    }

    public class Rectangles : Shape
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public Rectangles(double length, double width)
        {
            Length = length;
            Width = width;
        }

        // Override the Area method
        public override double Area()
        {
            return Length * Width; // Formula for area of a rectangle
        }

        // Override the Name method
        public override string Name()
        {
            return "Rectangle"; // Return the name of the shape
        }
    }

    class Shapes
    {
        static void PrintShapeArea(Shape shape)
        {
            // Prints the name of the shape and its area
            Console.WriteLine($"The area of the {shape.Name()} is: {shape.Area()}");
        }

        public static void Mainshapes(string[] args)
        {
            // Instantiate circle object
            Shape circle = new Circle(5);
            PrintShapeArea(circle); // Prints "The area of the Circle is: 78.53981633974483"

            // Instantiate Rectangle object
            Shape rectangle = new Rectangles(4, 6);
            PrintShapeArea(rectangle); // Prints "The area of the Rectangle is: 24"
        }
    }
}
