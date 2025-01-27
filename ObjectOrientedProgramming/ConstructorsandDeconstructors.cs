using System;
using System.Collections.Generic;
namespace ObjectOrientedProgramming{
class Book
{
    // Properties
    public string Title { get; set; }
    public string Author { get; set; }

    // Constructor to initialize properties
    public Book(string title, string author)
    {
        Title = title;
        Author = author;
    }

    // Method to display book details
    public void DisplayDetails()
    {
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine();
    }
}

class BookProgram
{
   public  static void MainBook(string[] args)
    {
        // Create a list of books
        List<Book> books = new List<Book>
        {
            new Book("To Kill a Mockingbird", "Harper Lee"),
            new Book("1984", "George Orwell"),
            new Book("The Great Gatsby", "F. Scott Fitzgerald"),
            new Book("Pride and Prejudice", "Jane Austen"),
            new Book("Harry Potter ", "J.K.Rowling")
        };

        // Display details of all books
        Console.WriteLine("List of Books:\n");
        foreach (Book book in books)
        {
            book.DisplayDetails();
        }
    }
}

class MyClass
{
    // Constructor
    public MyClass()
    {
        Console.WriteLine("Constructor called!");
    }

    // Destructor (Finalizer)
    ~MyClass()
    {
        Console.WriteLine("Destructor called!");
    }

    // A simple method
    public void SayHello()
    {
        Console.WriteLine("Hello from MyClass!");
    }
}

class ConstructorProgram
{
   public static void Mainconstructor(string[] args)
    {
        // Instantiate an object of MyClass
        MyClass? obj = new MyClass();

        // Call a method
        obj.SayHello();

        // Explicitly set the object to null and force garbage collection
        obj = null;
        GC.Collect(); // Force garbage collection to demonstrate the destructor
        GC.WaitForPendingFinalizers(); // Wait for finalizers to complete

        Console.WriteLine("End of Main method.");
    }
}
}