class TextProcessor
{
    public static void DisplayWordLengths()
    {
        string text = Console.ReadLine();

        // Count words first
        int wordCount = CountWords(text);

        string[,] result = new string[wordCount, 2];

        int wordIndex = 0;
        string currentWord = "";

        for (int i = 0; i < ManualLength(text); i++)
        {
            if (text[i] == ' ')
            {
                if (currentWord != "")
                {
                    result[wordIndex, 0] = currentWord;
                    result[wordIndex, 1] = ManualLength(currentWord).ToString();
                    wordIndex++;
                    currentWord = "";
                }
            }
            else
            {
                currentWord += text[i];
            }
        }

        if (currentWord != "")
        {
            result[wordIndex, 0] = currentWord;
            result[wordIndex, 1] = ManualLength(currentWord).ToString();
        }

        // Print the result
        for (int i = 0; i < wordCount; i++)
        {
            Console.WriteLine(result[i, 0] + " : " + result[i, 1]);
        }
    }

    public static int ManualLength(string str)
    {
        int count = 0;
        foreach (char c in str)
            count++;
        return count;
    }

    public static int CountWords(string str)
    {
        int count = 0;
        bool inWord = false;

        for (int i = 0; i < ManualLength(str); i++)
        {
            if (str[i] != ' ')
            {
                if (!inWord)
                {
                    count++;
                    inWord = true;
                }
            }
            else
            {
                inWord = false;
            }
        }

        return count;
    }
}
