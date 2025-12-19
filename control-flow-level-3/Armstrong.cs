using System;

namespace control_flow_Level_2
{
    public class ArmstrongNumber
    {
        public static void CheckArmstrong()
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            int originalNumber = number;

            while (originalNumber != 0)
            {
                int remainder = originalNumber % 10;
                sum += remainder * remainder * remainder;
                originalNumber /= 10;
            }

            if (sum == number)
            {
                Console.WriteLine($"{number} is an Armstrong number.");
            }
            else
            {
                Console.WriteLine($"{number} is not an Armstrong number.");
            }
        }
    }
}
