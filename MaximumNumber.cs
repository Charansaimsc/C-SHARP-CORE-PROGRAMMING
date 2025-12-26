/*Maximum of Three Numbers:
Write a program that takes three integer inputs from the user and finds the maximum of the
three numbers.
● Ensure your program follows best practices for organizing code into modular
functions, such as separate functions for taking input and calculating the maximum
value.*/


using System;

public class MaximumNumber
{
	public static void Class1()
	{
        int a = GetNumber("Enter first number: ");
        int b = GetNumber("Enter second number: ");
        int c = GetNumber("Enter third number: ");

        int max = FindMax(a, b, c);

        Console.WriteLine($"Maximum number is: {max}");
    }


    //take integer input
    static int GetNumber(string message)
    {
        Console.Write(message);
        return int.Parse(Console.ReadLine());
    }

    // find maximum of three numbers
    static int FindMax(int x, int y, int z)
    {
        int max = x;

        if (y > max)
            max = y;

        if (z > max)
            max = z;

        return max;
    }
}
