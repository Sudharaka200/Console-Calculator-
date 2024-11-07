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
            Console.WriteLine("Console Calculater in C#");
            Console.WriteLine("------------------------------");

            Console.WriteLine("Type a number and then press enter:");
            double no1 = Convert.ToDouble(Console.ReadLine()); //How to get users input

            Console.WriteLine("Type another number and then press enter:");
            double no2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Choose and option from the following list:");
            Console.WriteLine("\t + ADD");
            Console.WriteLine("\t - SUB");
            Console.WriteLine("\t * MUL");
            Console.WriteLine("\t / DIV");

            Console.ReadKey();
        }
    }
}
