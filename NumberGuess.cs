/*Number Guessing Game:
Write a program where the user thinks of a number between 1 and 100, and the computer
tries to guess the number by generating random guesses.
● The user provides feedback by indicating whether the guess is high, low, or correct.
● The program should be modular, with different functions for generating guesses,
receiving user feedback, and determining the next guess.*/





using System;

public class NumberGuess
{
	public static void Class1()
	{
        int min = 1;
        int max = 100;
        bool found = false;

        Console.WriteLine("Think of a number between 1 and 100.");
        Console.WriteLine("Reply with: high, low, or correct.");
        Console.ReadKey();

        while (!found)
        {
            int guess = GenerateGuess(min, max);

            Console.WriteLine($"Computer guess: {guess}");
            string answer = GetUserFeedback();

            if (answer == "correct")
            {
                Console.WriteLine("Computer guessed your number!!!!");
                found = true;
            }
            else if (answer == "high")
            {
                max = guess - 1;
            }
            else if (answer == "low")
            {
                min = guess + 1;
            }
        }
        

    }

    // generate nnumber
    static int GenerateGuess(int min, int max)
    {
        Random rand = new Random();
        return rand.Next(min, max + 1);
    }

    // get the user's feedback
    static string GetUserFeedback()
    {
        Console.Write("Is it high, low, or correct  ");
        return Console.ReadLine().ToLower();
    }


}
