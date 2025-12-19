using System;

namespace control_flow_Level_2
{
    public class PowerCalculator
    {
        public static void CalculatePower()
        {
          
            Console.WriteLine("Enter the base number:");
            int baseNum = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the exponent:");
            int exponent = int.Parse(Console.ReadLine());

            int result = 1;
            int i = 1;

           
            while (i <= exponent)
            {
                result *= baseNum;
                i++;
            }

            Console.WriteLine($"{baseNum} raised to the power {exponent} is: {result}");
        }
    }
}
