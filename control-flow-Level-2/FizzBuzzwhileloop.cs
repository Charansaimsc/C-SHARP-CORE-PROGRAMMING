using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace control_flow_Level_2
{
    public class FizzBuzzWhile
    {
        public static void FizzBuzz()
        {
            int number = int.Parse(Console.ReadLine());
            if (number > 0)
            {
                int i = 1;
                while (i <= number)
                {
                    if (i % 3 == 0 && i % 5 == 0)
                    {
                        Console.WriteLine("FizzBuzz");
                    }
                    else if (i % 3 == 0)
                    {
                        Console.WriteLine("Fizz");
                    }
                    else if (i % 5 == 0)
                    {
                        Console.WriteLine("Buzz");
                    }
                    else
                    {
                        Console.WriteLine(i);
                    }
                    i++;
                }
            }
        }
    }
}
