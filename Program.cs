using System;
using syntax; 
using operations;
using Comparisonoperators;

class Program
{
    static void Main(string[] args)
    {
        
        if (args.Length == 0)
        {
            Console.WriteLine("Please provide an argument to run the program.");
            Console.WriteLine("Usage: dotnet run <simplecalc | syntax | Compare >");
            return;
        }

        
        switch (args[0].ToLower())
        {
            case "simplecalc":
                Console.WriteLine("Running Simple Calculator:");
                Calc.Simplecalc(new string[] { });
                break;

            case "syntax":
                Console.WriteLine("\nRunning Variable Demonstration:");
                Variable.VarRun(new string[] { });
                break;

            case "compare":
                Console.WriteLine("\nRunning a comparison of 2 numbers:");
                Compareoperations.Compare(new string[] { }); // Runs Compare method in the Compareoperations class
                break;
                 case "checknumberrange":
                Console.WriteLine("\nChecking if inputed number lies within the 10 and 100:");
                NumberRange.Checknumberrange(new string[] { }); 
                break;
                  case "checkage":
                Console.WriteLine("\nChecking if inputed number lies within the 10 and 100:");
                Checkage.Checkvotingage(new string[] { }); 
                break;
                case "operations":
                Console.WriteLine("\nassignment operations:");
                 Assignment.Operationassignment(new string[] { }); 
                break;

                case "swapp":
                Console.WriteLine("\nassignment operations:");
                 Swapp.Swapnumbers(new string[] { }); 
                break;
            default:
                Console.WriteLine("Invalid argument. Use 'simplecalc' or 'syntax' or 'compare'");
                Console.WriteLine("Usage: dotnet run <simplecalc | syntax | Comparisonoperators>");
                break;
        }
    }
}
