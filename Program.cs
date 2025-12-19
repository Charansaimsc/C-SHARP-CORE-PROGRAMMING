using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Core_Programing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Simple console application for printing text and user input..
            Console.WriteLine("Hello, World!");
            Console.ReadLine();

            // Data Types
            int number = 10;
            Console.WriteLine(number);
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(int.MinValue);

            long longNumber = 10L;
            Console.WriteLine(longNumber);
            Console.WriteLine(long.MaxValue);
            Console.WriteLine(long.MinValue);


            double doubleNumber = 15.00D;
            Console.WriteLine(doubleNumber);
            Console.WriteLine(double.MaxValue);
            Console.WriteLine(double.MinValue);

            decimal decimalNumber = 19999.99M;
            Console.WriteLine(decimalNumber);
            Console.WriteLine(decimal.MaxValue);
            Console.WriteLine(decimal.MinValue);

            byte b = 255;
            short s = -32000;
            Console.WriteLine(s);
            Console.WriteLine(b);
        }
    }
}