using System;
public class ComparingStrings
{
    public static void StringComparison()
    {
        Console.WriteLine("ENTER STRING 1");
        string one = Console.ReadLine();

        Console.WriteLine("ENTER STRING 2");
        string two = Console.ReadLine();

        if (one.Length != two.Length)
        {
            Console.WriteLine("Manual Comparison: False");
            Console.WriteLine("Built-in Equals: " + string.Equals(one, two));
            return;
        }

        bool isEqual = true;

        for (int i = 0; i < one.Length; i++)
        {
            if (one[i] != two[i])
            {
                isEqual = false;
                break;
            }
        }

        Console.WriteLine("Manual Comparison: " + isEqual);
        bool result = string.Equals(one, two);
        Console.WriteLine("Built-in Equals: " + result);
    }
}


