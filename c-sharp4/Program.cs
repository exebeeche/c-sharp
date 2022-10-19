using System;

namespace c_sharp4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Simple while cicle

            //int counter = 0;
            //int limit = int.Parse(Console.ReadLine());
            //while (counter < limit)
            //{
            //    counter++;
            //    Console.WriteLine(counter);
            //}

            // Odd and even numbers counter, also the sum of all odd and even numbers inside the specified range

            uint oddNumberCounter = 0; // Odd number
            uint evenNumberCounter = 0; // Even number

            int oddNumberSum = 0; // Odd number summ
            int evenNumberSum = 0; // Even number sum

            Console.WriteLine("Enter the beginning of the number range");
            int beginRange = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the end of the number range");
            int endRange = int.Parse(Console.ReadLine());

            while (beginRange <= endRange)
            {
                if (beginRange % 2 == 0)
                {
                    evenNumberCounter++;
                    evenNumberSum += beginRange;
                }
                else
                {
                    oddNumberCounter++;
                    oddNumberSum += beginRange;
                }
                beginRange++;
            }


            Console.WriteLine($"Even numbers: {evenNumberCounter}");
            Console.WriteLine($"Odd numbers: {oddNumberCounter}");
            Console.WriteLine($"Even numbers sum: {evenNumberSum}");
            Console.WriteLine($"Odd numbers sum: {oddNumberSum}");
			Console.WriteLine($"Odd numbers sum: {oddNumberSum} and Even numbers sum: {evenNumberSum}");

        }
    }
}
