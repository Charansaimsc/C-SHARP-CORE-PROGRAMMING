/*Palindrome Checker:
Write a program that checks if a given string is a palindrome (a word, phrase, or sequence
that reads the same backward as forward).
● Break the program into functions for input, checking the palindrome condition, and
displaying the result.*/



using System;

public class Palindrome
{
	public static void Class1()
	{
        string text = GetInput();

        bool result = PalindromeCheck(text);

        ShowResult(text, result);
    }

    //take input
    static string GetInput()
    {
        Console.Write("Enter a word: ");
        return Console.ReadLine();
    }


    //check palindrome
    static bool PalindromeCheck(string text)
    {
        string newText = text.Replace(" ", "").ToLower();
        int left = 0;
        int right = newText.Length - 1;

        while (left < right)
        {
            if (newText[left] != newText[right])
                return false;

            left++;
            right--;
        }

        return true;
    }

    //display result
    static void ShowResult(string text, bool result)
    {
        if (result)
            Console.WriteLine($"\"{text}\" is a Palindrome.");
        else
            Console.WriteLine($"\"{text}\" is not a Palindrome.");
    }


}
