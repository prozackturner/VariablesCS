using System;

namespace VariablesCS
{
    class Program
    {
        static void Main(string[] args)
        {
            var NumberOfCupsOfCoffee = 2;
            var fullName = "Zachary Turner";
            var todaysDate = "8/11/2020";

            Console.WriteLine(fullName + " " + NumberOfCupsOfCoffee + " " + todaysDate);

            Console.WriteLine("What is your name?");
            var userName = Console.ReadLine();

            Console.WriteLine("nice to meet you " + userName);

            Console.WriteLine("Give me an even number");
            var firstNumberString = Console.ReadLine();

            Console.WriteLine("Give me an odd number");
            var secondNumberString = Console.ReadLine();

            var firstOperand = double.Parse(firstNumberString);
            var secondOperand = double.Parse(secondNumberString);

            var sum = (firstOperand + secondOperand);
            var difference = (firstOperand - secondOperand);
            var product = (firstOperand * secondOperand);
            var quotient = (firstOperand / secondOperand);
            var remainder = (firstOperand % secondOperand);

            Console.WriteLine("sum is " + sum);
            Console.WriteLine("difference is " + difference);
            Console.WriteLine("product is " + product);
            Console.WriteLine("quotient is " + quotient);
            Console.WriteLine("remainder is " + remainder);
        }
    }
}
