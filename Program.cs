// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;
using System.Globalization;

namespace c_sharp
{

    class Program {

        static void Main(string[] args) 
        {

            /*  

                byte number = 10;
                string word = "Variable: ";
                char symbol = '.';
                //bool isHappy = false;
                Console.WriteLine(word + number + symbol);
                //getting data
                Console.ReadKey(); 

                int num_1 = 0, num_2 = 0;

                num_1 = Convert.ToInt32(Console.ReadLine());
                num_2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("First: " + num_1 + " Second: " + num_2);

                //float user_input;
                //user_input = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter the float: ");
                float user_input = float.Parse(Console.ReadLine());

                float result;

                //result = user_input + 10f;
                result = user_input - 10f;
                result *= 5f;
                result++;

                Console.WriteLine("Variable float: " + result);


    // Some math methods

                System.Console.WriteLine(Math.Abs(-34));
                System.Console.WriteLine(Math.Ceiling(4.22f));
                System.Console.WriteLine(Math.Floor(4.99f));
                System.Console.WriteLine(Math.Round(4.49f));
                System.Console.WriteLine(Math.Max(3, 5, 10));


    // Area calculation using radius
                System.Console.WriteLine("Enter the radius: ");
                double radius = Convert.ToDouble(Console.ReadLine());
                double area = Math.PI * Math.Pow(radius, 2);
                System.Console.WriteLine("Area is {0} with radius {1}", area, radius);
                //

    // Playing with if else
                int a = 6;
                bool isHasCar = false;

                if(a > 7) {
                    System.Console.WriteLine("Number is > 7");
                } else if((a == 5 || !isHasCar) && a > 2) {
                    System.Console.WriteLine("Number is 5");
                    //if(isHasCar)
                    System.Console.WriteLine("User has a car.");
                }
                else
                {
                    System.Console.WriteLine("Number is unclear.");
                }
                //


                System.Console.Write("Enter a role: ");
                string role = Console.ReadLine();

                if(role == "Admin") {
                    System.Console.Write("Enter a name: ");
                    string user_name = Console.ReadLine();
                    System.Console.WriteLine("Enter {0} age: ", user_name);
                    short age = Convert.ToInt16(Console.ReadLine());

                    if(age <= 0 || age > 99)  {
                        System.Console.WriteLine("Enter {0} age: ", user_name);
                        age = Convert.ToInt16(Console.ReadLine());

                    }

                    if(age <= 0 || age > 99) {
                        System.Console.WriteLine("Error");
                        age = 0;
                        }
                        else
                            System.Console.WriteLine("User's age is " + age);

                } else
                    System.Console.WriteLine("You are not an admin!");

    */
            //string a = Console.ReadLine();
            //Console.WriteLine($"Hello {a}");

            //string str = "5";

            //int a = Convert.ToInt32(str);
            //Console.WriteLine(a);

            //string str;

            //int a, b;

            //Console.WriteLine("Enter a number 1");

            //str = Console.ReadLine();

            //a = Convert.ToInt32(str);

            //Console.WriteLine("Enter a number 2");

            //str = Console.ReadLine();

            //b = Convert.ToInt32(str);

            //int result = a + b;

            //Console.WriteLine($"Result is {result}");

            //string str = "1,9";

            //double a = Convert.ToDouble(str);

            //Console.WriteLine(a);

            //string str = "5";

            //int a;

            //bool result = int.TryParse(str, out a);

            //if (result)
            //{
            //    Console.WriteLine($"Success {a}");
            //}
            //else
            //{
            //    Console.WriteLine("Fail");
            //}
            //double a = double.Parse(str);

            //try
            //{
            //    double a = Convert.ToDouble(str);
            //    Console.WriteLine("Success");
            //}
            //catch(Exception)
            //{
            //    Console.WriteLine("Fail");
            //}


            int result = (2 + 2) * 2;

            Console.WriteLine(result);

        }

    }

}
