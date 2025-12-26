/*GCD and LCM Calculator:
Create a program that calculates the Greatest Common Divisor (GCD) and Least Common
Multiple (LCM) of two numbers using functions.
● Use separate functions for GCD and LCM calculations, showcasing how modular code
works.*/


using System;

public class GcdAndLcm
{
	public static void Class1()
	{
        int a = GetNumber("Enter first number: ");
        int b = GetNumber("Enter second number: ");

        int gcd = FindGCD(a, b);
        int lcm = FindLCM(a, b);

        Console.WriteLine($"GCD of {a} and {b} is: {gcd}");
        Console.WriteLine($"LCM of {a} and {b} is: {lcm}");
    }


    //take integer input
    static int GetNumber(string message)
    {
        Console.Write(message);
        return int.Parse(Console.ReadLine());
    }

    //calculate GCD
    static int FindGCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

    //calculate LCM using GCD
    static int FindLCM(int a, int b)
    {
        return (a * b) / FindGCD(a, b);
    }
}
