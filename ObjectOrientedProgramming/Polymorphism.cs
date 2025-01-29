using System;
namespace ObjectOrientedProgramming{
// Abstract base class
public abstract class Shape
{
    public abstract double Area(); // Abstract method to calculate area
}

// Derived class for Circle
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
}

// Derived class for Rectangle
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
}

class Shapes
{
    // Method that accepts any object of type Shape and prints its area
    static void PrintShapeArea(Shape shape)
    {
        // Calls the overridden Area() method based on the object's actual type
        Console.WriteLine($"The area of the shape is: {shape.Area()}");
    }

    public static void Mainshapes(string[] args)
    {
        // Instantiate a Circle object
        Shape circle = new Circle(5); // Radius = 5
        PrintShapeArea(circle); // Demonstrates polymorphism

        // Instantiate a Rectangle object
        Shape rectangle = new Rectangles(4, 6); // Length = 4, Width = 6
        PrintShapeArea(rectangle); // Demonstrates polymorphism
    }
}
}