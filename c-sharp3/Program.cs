using System;

namespace c_sharp3
{
    class Program
    {
        static void Main(string[] args)
        {

            double firstNumber, secondNumber, thirdNumber;

            Console.WriteLine("Enter the first number");

            firstNumber = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number");

            secondNumber = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the third number");

            thirdNumber = double.Parse(Console.ReadLine());

            double resultSum = (firstNumber + secondNumber + thirdNumber);

            double resultMult = (firstNumber * secondNumber * thirdNumber);

            Console.WriteLine($"The sum is {resultSum}, the multiplicatiin is {resultMult}");

        }
    }
}
