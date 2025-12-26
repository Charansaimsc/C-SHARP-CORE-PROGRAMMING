/*Fibonacci Sequence Generator:
Write a program that generates the Fibonacci sequence up to a specified number of terms
entered by the user.
● Organize the code by creating a function that calculates and prints the Fibonacci
sequence.*/

using System;

public class Fibonacci
{
	public static void Class1()
	{
        Console.Write("Enter number of terms : ");
        int terms = int.Parse(Console.ReadLine());

        PrintFibonacci(terms);


    }

    static void PrintFibonacci(int terms)
    {
        int first = 0;
        int second = 1;

        if (terms <= 0)
        {
            Console.WriteLine("Please enter a positive number.");
            return;
        }

        Console.WriteLine("Fibonacci Sequence : ");

        for (int i = 1; i <= terms; i++)
        {
            Console.Write(first + " ");

            int next = first + second;
            first = second;
            second = next;
        }
    }
}
