using System;

public class Calculator
{
    public void Class1()
    {
        Console.WriteLine("Enter Two numbers : ");
        double first = Convert.ToDouble(Console.ReadLine());
        double second = Convert.ToDouble(Console.ReadLine());
        string op = Console.ReadLine();
        switch (op)
        {
            case "+":
                {
                    Console.WriteLine("The addition is : " + (first + second));
                    break;
                }
            case "-":
                {
                    Console.WriteLine("The Substracton is : " + (first - second));
                    break;
                }
            case "*":
                {
                    Console.WriteLine("The Multiplication is : " + (first * second));
                    break;
                }
            case "/":
                {
                    Console.WriteLine("The Division is : " + (first / second));
                    break;
                }
        }

    }
}