using System;

namespace control_flow_Level_2
{
    public class Friends
    {
        public static void FindYoungestAndTallest()
        {
            Console.WriteLine("Enter age of Amar:");
            int amarAge = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter age of Akbar:");
            int akbarAge = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter age of Anthony:");
            int anthonyAge = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter height of Amar (in cm):");
            int amarHeight = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter height of Akbar (in cm):");
            int akbarHeight = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter height of Anthony (in cm):");
            int anthonyHeight = int.Parse(Console.ReadLine());

            int minAge = amarAge;
            string youngest = "Amar";

            if (akbarAge < minAge)
            {
                minAge = akbarAge;
                youngest = "Akbar";
            }
            if (anthonyAge < minAge)
            {
                minAge = anthonyAge;
                youngest = "Anthony";
            }

            int maxHeight = amarHeight;
            string tallest = "Amar";

            if (akbarHeight > maxHeight)
            {
                maxHeight = akbarHeight;
                tallest = "Akbar";
            }
            if (anthonyHeight > maxHeight)
            {
                maxHeight = anthonyHeight;
                tallest = "Anthony";
            }

          
            Console.WriteLine($"The youngest friend is: {youngest} ({minAge} years old)");
            Console.WriteLine($"The tallest friend is: {tallest} ({maxHeight} cm tall)");
        }
    }
}
