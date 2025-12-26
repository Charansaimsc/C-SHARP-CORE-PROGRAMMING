/*Prime Number Checker:
Create a program that checks whether a given number is a prime number.
● The program should use a separate function to perform the prime check and return
the result.*/


using System;

public class PrimeChecker
{
	public static void Class1()
	{
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());

        bool prime = CheckPrime(num);

        if (prime)
            Console.WriteLine($"{num} is a Prime Number.");
        else
            Console.WriteLine($"{num} is not a Prime Number.");
    }

    //check if number is prime
    static bool CheckPrime(int num)
    {
        if (num <= 1)
            return false;

        for (int i = 2; i <= Math.Sqrt(num); i++)
        {
            if (num % i == 0)
                return false;
        }

        return true;
    }
}
