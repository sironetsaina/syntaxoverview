using System;
namespace ObjectOrientedProgramming{
class Student
{
        private int _grade;

        // Public property for Name
        public string? Name { get; set; }

        // Public property for Grade
        public int Grade
    {
        get { return _grade; }
        set
        {
            // Validate that the grade is between 0 and 100
            if (value >= 0 && value <= 100)
            {
                _grade = value;
            }
            else
            {
                Console.WriteLine("Grade must be between 0 and 100.");
            }
        }
    }
}

class Grades
{
    public static void Maingrades(string[] args)
    {
        // Create a Student object
        Student student = new Student();

        // Assign values using properties
        student.Name = "Alice";
        student.Grade = 95; // Valid grade

        // Display student details
        Console.WriteLine($"Student Name: {student.Name}");
        Console.WriteLine($"Student Grade: {student.Grade}");

        // Try to assign an invalid grade
        student.Grade = 150; // Invalid grade
    }
}

class Rectangle
{
    // Private fields
    private double _length;
    private double _width;

    // Public property for Length
    public double Length
    {
        get { return _length; }
        set
        {
            if (value > 0)
            {
                _length = value;
            }
            else
            {
                Console.WriteLine("Length must be positive.");
            }
        }
    }

    // Public property for Width
    public double Width
    {
        get { return _width; }
        set
        {
            if (value > 0)
            {
                _width = value;
            }
            else
            {
                Console.WriteLine("Width must be positive.");
            }
        }
    }

    // Method to calculate the area
    public double CalculateArea()
    {
        return Length * Width;
    }
}

class AreaProgram
{
    public static void Mainarea(string[] args)
    {
        // Create a Rectangle object
        Rectangle rectangle = new Rectangle();

        // Set values for Length and Width
        rectangle.Length = 10;
        rectangle.Width = 5;

        // Display the rectangle details and area
        Console.WriteLine($"Length: {rectangle.Length}");
        Console.WriteLine($"Width: {rectangle.Width}");
        Console.WriteLine($"Area: {rectangle.CalculateArea()}");

        // Try setting invalid values
        rectangle.Length = -2; // Invalid length
        rectangle.Width = -4; // Invalid width
    }
}


}