using System;

public class AbundantNumber
{
    public void Class1()
    {
        Console.WriteLine(" Enter a Number for Abundant Number : ");
        int number = Convert.ToInt32(Console.ReadLine());
        int sum = 0;

        for (int i = 1; i < number; i++)
        {
            if (number % i == 0)
            {
                sum += i;
            }
        }

        if (sum > number)
        {
            Console.WriteLine(" Number is a Abundant Number");
        }
        else
        {
            Console.WriteLine(" Number is not a Abundant Number");

        }
    }
}