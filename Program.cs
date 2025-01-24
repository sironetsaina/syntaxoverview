using System;
using syntax; 
using operations;
using Comparisonoperators;
using ControlFlow;
using Method;
using Methods;
using Methods.FactorialCalculator;
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
                 case "ifstatements":
                Console.WriteLine("\nfind value of the no:");
                Ifstatement.Ifelse(new string[] { }); 
                break;
                  case "ifstatement":
                Console.WriteLine("\ncheck leap year:");
                Leapyear.Leap(new string[] { }); 
                break;
                 case "switchstatement":
                Console.WriteLine("\nFind Day of the week:");
                Switch.Days(new string[] { }); 
                break;
                 case "switchstatements":
                Console.WriteLine("\nFind Month:");
                Switchmonth.Month(new string[] { }); 
                break;
                 case "loops":
                Console.WriteLine("\nDisplay fizzbuzz:");
                Loops.Loopno(new string[] { }); 
                break;
                case "fibonacci":
                Console.WriteLine("\nThe fibonacci sequence");
                Fibonacci.Sequence(new string[] { }); 
                break;
                case "method":
                Console.WriteLine("\nusing main method to call results");
                Add.Sum(new string[] { }); 
                break;
                case "methodstring":
                Console.WriteLine("\nusing main method to call length of a string");
                Getlength.Mainlength(new string [] { });
                break;
                case "methodoverloading":
                Console.WriteLine("\nusing  method overloading");
                Summint.Mainadd(new string [] { });
                break;

                case "area":
                Console.WriteLine("\nusing  method overloading to get area of shapes");
                ShapesArea.Mainarea(new string [] { });
                break;

                 case "string":
                Console.WriteLine("\nstring parameters");
                StringRepeater.Mainstring(new string [] { });
                break;
                case "recarea":
                Console.WriteLine("\nRectangle area");
                Recarea.Mainarea(new string [] { });
                break;
                case "message":
                Console.WriteLine("\nmessage from the method");
                Message.Mainmessage(new string [] { });
                break;
                case "factor":
                Console.WriteLine("\n Get factorial");
                Factorialcalc.Mainfactor(new string []{});
                break;
            default:
                Console.WriteLine("Invalid argument. Use 'simplecalc' or 'syntax' or 'compare'");
                Console.WriteLine("Usage: dotnet run <simplecalc | syntax | Comparisonoperators>");
                break;
        }
    }


}