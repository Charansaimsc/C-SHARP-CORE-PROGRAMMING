using System;

public class MostFrequent
{
    public static void CharacterCount()
    {
        string s = "charan";
        char mostFrequent = '\0';
        int maxCount = 0;

        for (int i = 0; i < s.Length; i++)
        {
            int count = 0;
            for (int j = 0; j < s.Length; j++)
            {
                if (s[i] == s[j])
                    count++;
            }

            if (count > maxCount)
            {
                maxCount = count;
                mostFrequent = s[i];
            }
        }

        Console.WriteLine("Most frequent character: " + mostFrequent);
    }
}
