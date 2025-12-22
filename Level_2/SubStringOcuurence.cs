using System;

public class SubStringOcuurrence
{
    public static void Counter()
    {
        string s = "charancharan";
        string repeated = "charan";
        int count = 0;

        for (int i = 0; i <= s.Length - repeated.Length; i++)
        {
            int j;
            for (j = 0; j < repeated.Length; j++)
            {
                if (s[i + j] != repeated[j])
                    break;
            }

            if (j == repeated.Length)
                count++;
        }

        Console.WriteLine(count);
    }
}
