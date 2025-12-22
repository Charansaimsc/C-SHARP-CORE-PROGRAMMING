class LongestWordFinder
{
    public static void Find()
    {
        string sentence = Console.ReadLine();

        string currentWord = "";
        string longestWord = "";

        for (int i = 0; i < sentence.Length; i++)
        {
            if (sentence[i] != ' ')
            {
                currentWord += sentence[i];
            }
            else
            {
                if (currentWord.Length > longestWord.Length)
                {
                    longestWord = currentWord;
                }
                currentWord = "";
            }
        }
        if (currentWord.Length > longestWord.Length)
        {
            longestWord = currentWord;
        }

        Console.WriteLine(longestWord);
    }
}
