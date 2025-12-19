using System;
using System.Net;

namespace control_flow_Level_2
{
    public class Factors
    {
        public static void FactorsOfNumber()
        {
            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i < number / 2; i++)
            {
                if (i % number == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}