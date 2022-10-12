// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;

namespace c_sharp2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Check the number if it is even

            //Console.WriteLine("Enter the number");

            //int firstNumber = int.Parse(Console.ReadLine());


            //if (firstNumber % 2 == 0)
            //{
            //    Console.WriteLine($"The {firstNumber} is even");
            //}
            //else
            //{
            //    Console.WriteLine($"The {firstNumber} is NOT even");
            //}

            //string a = Console.ReadLine();
            //switch (a)
            //{
            //    case "Hello!":
            //        Console.WriteLine("You said Hello!");
            //        break;
            //    case "Goodbay!":
            //        Console.WriteLine("You said Goodbay!");
            //        break;
            //    default:
            //        Console.WriteLine("You said something else");
            //        break;
            //}

            //ConsoleKey consoleKey = Console.ReadKey().Key;

            while (true)
            {
                //Console.Clear();
                double firstNumber, secondNumber;
                string action;

                try
                {
                    Console.WriteLine("Enter the first number");
                    firstNumber = double.Parse(Console.ReadLine());

                    Console.WriteLine("Enter the second number");
                    secondNumber = double.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Do not put string! Enter numbers!");
                    Console.ReadLine();
                    continue;
                }

                

                Console.WriteLine("Choose the action: '+', '-', '*', '/'");
                action = Console.ReadLine();

                switch (action)
                {
                    case "+":
                        Console.WriteLine(firstNumber + secondNumber);
                        break;
                    case "-":
                        Console.WriteLine(firstNumber - secondNumber);
                        break;
                    case "*":
                        Console.WriteLine(firstNumber * secondNumber);
                        break;
                    case "/":
                        if (secondNumber == 0)
                        {
                            Console.WriteLine("You cannot divide on zero!");
                        }
                        else
                        {
                            Console.WriteLine(firstNumber / secondNumber);
                        }
                        break;

                    default:
                        Console.WriteLine("Undefined operation!");
                        break;
                }
            }


        }
    }
}

