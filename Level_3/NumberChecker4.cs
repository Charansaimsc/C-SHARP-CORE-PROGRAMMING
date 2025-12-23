
/*Extend or Create a NumberChecker utility class and perform the following task. Call
from the main() method the different methods and display results. Make sure all are static
methods
Hint =>
a. Method to Check if a number is a prime number. A prime number is a number greater
than 1 that has no positive divisors other than 1 and itself.
b. Method to Check if a number is a neon number. A neon number is a number where
the sum of digits of the square of the number is equal to the number itself
c. Method to Check if a number is a spy number. A number is called a spy number if the
sum of its digits is equal to the product of its digits
d. Method to Check if a number is an automorphic number. An automorphic number is a
number whose square ends with the number itself. E.g. 5 is an automorphic number
e. Method to Check if a number is a buzz number. A buzz number is a number that is
either divisible by 7 or ends with 7*/




using System;

public class NumberChecker4
{
    // Prime Number checks return True if promenumber
    public static bool IsPrime(int num)
    {
        if (num <= 1)
            return false;

        for (int i = 2; i <= num / 2; i++)
        {
            if (num % i == 0)
                return false;
        }
        return true;
    }

    // returns true if Neon Number
    public static bool IsNeon(int num)
    {
        int square = num * num;
        int sum = 0;

        while (square > 0)
        {
            sum += square % 10;
            square /= 10;
        }

        return sum == num;
    }

    //  returns true if spy number Spy Number
    public static bool IsSpy(int num)
    {
        int sum = 0, product = 1;
        int temp = num;

        while (temp > 0)
        {
            int digit = temp % 10;
            sum += digit;
            product *= digit;
            temp /= 10;
        }

        return sum == product;
    }

    // returns true if  Automorphic Number
    public static bool IsAutomorphic(int num)
    {
        int square = num * num;
        int temp = num;

        while (temp > 0)
        {
            if (temp % 10 != square % 10)
                return false;

            temp /= 10;
            square /= 10;
        }
        return true;
    }

    // returns  true if Buzz Number
    public static bool IsBuzz(int num)
    {
        return (num % 7 == 0 || num % 10 == 7);
    }
}


