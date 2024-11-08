using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Calculator_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double answer;
            Console.WriteLine("Console Calculater in C#");
            Console.WriteLine("------------------------------");

            Console.WriteLine("Type a number and then press enter:");
            double no1 = Convert.ToDouble(Console.ReadLine()); //How to get users input

            Console.WriteLine("Type another number and then press enter:");
            double no2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Choose and option from the following list:");
            Console.WriteLine("\t a ADD");
            Console.WriteLine("\t s SUB");
            Console.WriteLine("\t m MUL");
            Console.WriteLine("\t d DIV");
            Console.WriteLine("What is your option?");
            string op = Console.ReadLine();

            switch(Console.ReadLine())
            {
                case "a":
                    answer = no1 + no2;
                    Console.WriteLine("Addition is" + answer);
                    break;
                case "b":
                    answer = no1 - no2;
                    Console.WriteLine("Subtraction is" + answer);
                    break;
                case "m":
                    answer = no1 * no2;
                    Console.WriteLine("Multiply is" + answer);
                    break;
                case "d":
                    answer = no1 / no2;
                    Console.WriteLine("Divition is" + answer);
                    break;
            }

            Console.ReadKey();
        }
    }
}
