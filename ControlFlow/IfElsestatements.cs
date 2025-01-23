using System;
namespace ControlFlow{
    public class Ifstatement{
        public static void Ifelse(string[]args){
            Console.WriteLine("Enter a number:");
        double number1 = Convert.ToDouble(Console.ReadLine());
        if (number1 > 0)
            {
                Console.WriteLine($"{number1} is positive");
            }
            else if (number1<0)
            {
                Console.WriteLine($"{number1} is negative");
            }
        else {
            Console.WriteLine($"{number1} is 0 ");
        }

        }
    }
    public class Leapyear{
        public static void Leap(string[]args){
              Console.WriteLine("Enter a Year");
            int Year = Convert.ToInt32(Console.ReadLine());
            if((Year % 4 == 0 && Year % 100 != 0) || (Year % 400 == 0)){
Console.WriteLine($"{Year} is a leap year");
            }
else{
    Console.WriteLine($"{Year} is not a leap year");
}
        }
    }
}