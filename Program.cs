using System;
using syntax; 
using operations;
using Comparisonoperators;
using ControlFlow;
using Method;
using Methods;
using Methods.FactorialCalculator;
using ObjectOrientedProgramming;
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
/*arithmetic.cs*/ case "simplecalc":
                Console.WriteLine("Running Simple Calculator:");
                Calc.Simplecalc(new string[] { });
                break;

 /*syntaxover */  case "syntax":
                Console.WriteLine("\nRunning Variable Demonstration:");
                Variable.VarRun(new string[] { });
                break;

/*CompOperators*/ case "compare":
                Console.WriteLine("\nRunning a comparison of 2 numbers:");
                Compareoperations.Compare(new string[] { }); // Runs Compare method in the Compareoperations class
                break;
/*LogicalOperators*/ case "checknumberrange":
                Console.WriteLine("\nChecking if inputed number lies within the 10 and 100:");
                NumberRange.Checknumberrange(new string[] { }); 
                break;
 /*LogicalOperators*/ case "checkage":
                Console.WriteLine("\nChecking if inputed number lies within the 10 and 100:");
                Checkage.Checkvotingage(new string[] { }); 
                break;
 /*assignmentOperator*/ case "operations":
                Console.WriteLine("\nassignment operations:");
                 Assignment.Operationassignment(new string[] { }); 
                break;

/*assignmentOperator*/   case "swapp":
                Console.WriteLine("\nassignment operations:");
                 Swapp.Swapnumbers(new string[] { }); 
                break;
/*IfElsestatements*/case "ifstatements":
                Console.WriteLine("\nfind value of the no:");
                Ifstatement.Ifelse(new string[] { }); 
                break;
 /*IfElsestatements*/case "ifstatement":
                Console.WriteLine("\ncheck leap year:");
                Leapyear.Leap(new string[] { }); 
                break;
/*Switchstatements*/ case "switchstatement":
                Console.WriteLine("\nFind Day of the week:");
                Switch.Days(new string[] { }); 
                break;
/*Switchstatements*/case "switchstatements":
                Console.WriteLine("\nFind Month:");
                Switchmonth.Month(new string[] { }); 
                break;
/*Loops*/       case "loops":
                Console.WriteLine("\nDisplay fizzbuzz:");
                Loops.Loopno(new string[] { }); 
                break;
 /*Loops*/      case "fibonacci":
                Console.WriteLine("\nThe fibonacci sequence");
                Fibonacci.Sequence(new string[] { }); 
                break;
/*Methods and functions*/ case "method":
                Console.WriteLine("\nusing main method to call results");
                Add.Sum(new string[] { }); 
                break;
/*Methods and functions*/ case "methodstring":
                Console.WriteLine("\nusing main method to call length of a string");
                Getlength.Mainlength(new string [] { });
                break;
 /*Methodoverloading*/case "methodoverloading":
                Console.WriteLine("\nusing  method overloading");
                Summint.Mainadd(new string [] { });
                break;

/*Methodoverloading*/ case "area":
                Console.WriteLine("\nusing  method overloading to get area of shapes");
                ShapesArea.Mainarea(new string [] { });
                break;

 /*Methodparameters*/ case "string":
                Console.WriteLine("\nstring parameters");
                StringRepeater.Mainstring(new string [] { });
                break;
 /*Methodparameters*/  case "recarea":
                Console.WriteLine("\nRectangle area");
                Recarea.Mainarea(new string [] { });
                break;
/* CallingMethods*/  case "message":
                Console.WriteLine("\nmessage from the method");
                Message.Mainmessage(new string [] { });
                break;
/* CallingMethods*/  case "factor":
                Console.WriteLine("\n Get factorial");
                Factorialcalc.Mainfactor(new string []{});
                break;
/*Classesandobjects*/  case "cars":
                Console.WriteLine("\nlist of car specifics ");
               Cardetails.Maindetails(new string []{});
                break;

/*Classesandobjects*/case "persondetails":
                Console.WriteLine("\nlists persons details");
                Persondetails.Mainpersona(new string []{});
                break;

/*Constructorsanddeconstructors*/  case "bookdetails":
                Console.WriteLine("\nLiblary");
                BookProgram.MainBook(new string []{});
                break;

/*Constructorsanddeconstructors*/ case "constructors":
                Console.WriteLine("\nconstructors and deconstructors");
                ConstructorProgram.Mainconstructor(new string []{});
                break;
/*Properties and fields*/ case "properties":
                Console.WriteLine("\nproperties");
                Grades.Maingrades(new string []{});
                break;
/*Properties and fields*/  case "fields":
                Console.WriteLine("\nfields");
                AreaProgram.Mainarea(new string []{});
                break;
/*encapsulation*/  case "bank":
                Console.WriteLine("\nencapsulation");
                BankProgram.MainBank(new string []{});
                break;

 /*encapsulation*/ case "employee":
                Console.WriteLine("\nencapsulation");
                employeeProgram.Mainemployee(new string []{});
                break;
 /*inheritance*/ case "sounds":
                Console.WriteLine("\ninheritance");
                Animalsound.Mainsound(new string []{});
                break;
/*inheritance*/case "vehicles":
                Console.WriteLine("\ninheritance");
                Vehicledetails.Mainvehicles(new string []{});
                break;
/*Polymorhism*/  case "shapes":
                Console.WriteLine("\nPolymorphism");
                Shapes.Mainshapes(new string []{});
                break;
 /*Abstraction*/ case "appliance":
                Console.WriteLine("\nabstraction");
                Appliances.Mainappliance(new string []{});
                break;
/*Array and Lists*/  case "array":
                Console.WriteLine("\narray of numbers");
                Numbers.Mainnumbers(new string []{});
                break;
/*Array and Lists*/ case "lists":
                Console.WriteLine("\nlist of numbers");
                Listno.MainNo(new string []{});
                break;
/*dictionary*/   case "dictionary":
                Console.WriteLine("\nstudent details");
                DictionaryProgram.Maindictionary(new string []{});
                break;
/*Abstraction*/case "salary":
                Console.WriteLine("\nemployee salary ");
                Employeessalary.Mainsalary (new string []{});
                break;
/*dictionary*/ case "frequency":
                Console.WriteLine("\nnumbers frequency");
                Numbersfrequency.Mainfrequency (new string []{});
                break;
/*itreatingcollection*/case "colors":
                Console.WriteLine("\ncolors");
                Displaycolors.Maincolors (new string []{});
                break;
/*itreatingcollection*/ case "iteratingprices":
                Console.WriteLine("\nProduct prices display");
                ProductPriceDisplay.ShowPrices (new string []{});
                break;



            default:
                Console.WriteLine("Invalid argument. Use 'simplecalc' or 'syntax' or 'compare'");
                Console.WriteLine("Usage: dotnet run <simplecalc | syntax | Comparisonoperators>");
                break;
        }
    }
}