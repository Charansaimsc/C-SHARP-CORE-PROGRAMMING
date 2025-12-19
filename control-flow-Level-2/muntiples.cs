using System;

namespace control_flow_Level_2
{
    public class Multiples
    {
        public static void Multiple()
        {
            int number = int.Parse(Console.ReadLine());
            for (int i = number; i < 100; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}