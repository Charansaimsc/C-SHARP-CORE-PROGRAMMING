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
