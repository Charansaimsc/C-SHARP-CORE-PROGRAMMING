using System;

public class SubString
{
    public static void GenerationSubString()
    {
        string s1 = Console.ReadLine();
        int startIndex = Convert.ToInt32(Console.ReadLine());
        int lastIndex = Convert.ToInt32(Console.ReadLine());

        if (startIndex < 0 || lastIndex > s1.Length || startIndex >= lastIndex)
        {
            Console.WriteLine("Invalid indexes");
            return;
        }

        string manualSub = "";

        for (int i = startIndex; i < lastIndex; i++)
        {
            manualSub += s1[i];
        }

        Console.WriteLine(manualSub);

        string s2 = s1.Substring(startIndex, lastIndex - startIndex);
        Console.WriteLine(s2);
    }
}
