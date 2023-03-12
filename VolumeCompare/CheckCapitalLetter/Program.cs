using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckCapitalLetter {
    internal class Program {
        static void Main(string[] args) {

            // Input a symbol

            Console.WriteLine("Enter a letter:");
            char checkedLetter = Console.ReadKey().KeyChar;

            // Check the letter

            if(char.IsUpper(checkedLetter)) {
                Console.WriteLine("The input symbol is an uppercase letter.");
            }
            else {
                Console.WriteLine("The input symbol is a capital letter.");
            }
            Console.ReadLine();
        }
    }
}
