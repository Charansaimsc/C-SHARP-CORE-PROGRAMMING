/*Factorial Using Recursion:
Write a program that calculates the factorial of a number using a recursive function.
● Include modular code to separate input, calculation, and output processes.*/


using System;

public class Factorial
{
	public static void Class1()
	{
        int num = GetInput();

        long result = FactorialCalculate(num);

        ShowResult(num, result);
    }
    //take input
    static int GetInput()
    {
        Console.Write("Enter a number: ");
        return int.Parse(Console.ReadLine());
    }

    // Recursive function to calculate factorial
    static long FactorialCalculate(int num)
    {
        if (num == 0 || num == 1)
            return 1;

        return num * FactorialCalculate(num - 1);
    }

    //display result
    static void ShowResult(int num, long result)
    {
        Console.WriteLine($"Factorial of {num} is: {result}");
    }
}
