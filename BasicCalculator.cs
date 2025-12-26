/*9. Basic Calculator:
Write a program that performs basic mathematical operations (addition, subtraction,
multiplication, division) based on user input.
● Each operation should be performed in its own function, and the program should
prompt the user to choose which operation to perform.*/


using System;

public class BasicCalculator
{
	public static void Class1()
	{
        Console.Write("Enter first number: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        double b = double.Parse(Console.ReadLine());

        Console.WriteLine("Choose operation:");
        Console.WriteLine("1. Addition");
        Console.WriteLine("2. Subtraction");
        Console.WriteLine("3. Multiplication");
        Console.WriteLine("4. Division");

        Console.Write("Enter choice: ");
        int choice = int.Parse(Console.ReadLine());

        double result = 0;

        if (choice == 1)
            result = Add(a, b);
        else if (choice == 2)
            result = Subtract(a, b);
        else if (choice == 3)
            result = Multiply(a, b);
        else if (choice == 4)
            result = Divide(a, b);
        else
        {
            Console.WriteLine("Invalid choice");
            return;
        }

        Console.WriteLine("Result: " + result);
    }


    static double Add(double a, double b)
    {
        return a + b;
    }

    static double Subtract(double a, double b)
    {
        return a - b;
    }

    static double Multiply(double a, double b)
    {
        return a * b;
    }

    static double Divide(double a, double b)
    {
        return a / b;
    }
}
