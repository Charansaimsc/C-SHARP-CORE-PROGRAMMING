/*Extend or Create a NumberChecker utility class and perform the following task. Call
from the main() method the different methods and display results. Make sure all are static
methods
Hint =>
a. Method to find factors of a number and return them as an array. Note there are 2 for
loops one for the count and another for finding the factor and storing in the array
b. Method to find the greatest factor of a Number using the factors array
c. Method to find the sum of the factors using factors array and return the sum
d. Method to find the product of the factors using factors array and return the product
e. Method to find product of cube of the factors using the factors array. Use Math.Pow()
f. Method to Check if a number is a perfect number. Perfect numbers are positive
integers that are equal to the sum of their proper divisors

g. Method to find the number is an abundant number. A number is called an abundant
number if the sum of its proper divisors is greater than the number itself
h. Method to find the number is a deficient number. A number is called a deficient
number if the sum of its proper divisors is less than the number itself
i. Method to Check if a number is a strong number. A number is called a strong number
if the sum of the factorial of its digits is equal to the number itself*/

using System;

public class NumberChecker5
{
    public static int[] Factors(int num)
    {
        int count = 0;

        // count factors
        for (int i = 1; i <= num; i++)
        {
            if (num % i == 0)
                count++;
        }

        int[] factors = new int[count];
        int index = 0;

        // store factors
        for (int i = 1; i <= num; i++)
        {
            if (num % i == 0)
                factors[index++] = i;
        }

        return factors;
    }

    public static int GreatestFacter(int[] factors)
    {
        Array.Sort(factors);
        return factors[factors.Length - 2]; // excluding the number itself
    }

    public static int Product(int[] factors)
    {
        int product = 1;
        for (int i = 0; i < factors.Length; i++)
            product *= factors[i];

        return product;
    }

    public static int ProductOfCubes(int[] factors)
    {
        int productCubes = 1;
        for (int i = 0; i < factors.Length; i++)
            productCubes *= (int)Math.Pow(factors[i], 3);

        return productCubes;
    }

    public static bool IsPerfectNumber(int num)
    {
        int sum = 0;
        for (int i = 1; i <= num / 2; i++)
            if (num % i == 0)
                sum += i;

        return sum == num;
    }

    public static bool AbundentNumber(int num)
    {
        int sum = 0;
        for (int i = 1; i <= num / 2; i++)
            if (num % i == 0)
                sum += i;

        return sum > num;
    }

    public static bool DeficientNumber(int num)
    {
        int sum = 0;
        for (int i = 1; i <= num / 2; i++)
            if (num % i == 0)
                sum += i;

        return sum < num;
    }

    public static bool IsStrongNumber(int num)
    {
        int original = num, sum = 0;

        while (num > 0)
        {
            int digit = num % 10;
            sum += Factorial(digit);
            num /= 10;
        }

        return sum == original;
    }

    public static int Factorial(int n)
    {
        int fact = 1;
        for (int i = 1; i <= n; i++)
            fact *= i;

        return fact;
    }
}
