using System;

public class LexicographicalOrder
{
    public static void Compare()
    {
        string s1 = Console.ReadLine();
        string s2 = Console.ReadLine();

        int minLength = s1.Length < s2.Length ? s1.Length : s2.Length;

        for (int i = 0; i < minLength; i++)
        {
            if (s1[i] != s2[i])
            {
                if (s1[i] < s2[i])
                    Console.WriteLine(s1);
                else
                    Console.WriteLine(s2);
                return;
            }
        }

       
        if (s1.Length < s2.Length)
            Console.WriteLine(s1);
        else if (s1.Length > s2.Length)
            Console.WriteLine(s2);
        else
            Console.WriteLine("Both strings are equal");
    }
}
