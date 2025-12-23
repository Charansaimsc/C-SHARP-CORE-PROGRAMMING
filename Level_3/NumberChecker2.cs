using System;

public class NumberChecker2
{
    public static int[] FindCountAndStore(int number)
    {
        int temp = number;
        int count = 0;

        while (temp != 0)
        {
            temp /= 10;
            count++;
        }

        int[] digits = new int[count];
        temp = number;

        for (int i = 0; i < count; i++)
        {
            digits[i] = temp % 10;
            temp /= 10;
        }
        return digits;
    }

    public static int SumOfDigits(int[] digits)
    {
        int sum = 0;
        for (int i = 0; i < digits.Length; i++)
        {
            sum += digits[i];
        }
        return sum;
    }

    public static int SumOfSquares(int[] digits)
    {
        int sumSquares = 0;
        for (int i = 0; i < digits.Length; i++)
        {
            sumSquares += digits[i] * digits[i];
        }
        return sumSquares;
    }

    public static bool HarshadNumber(int[] digits, int number)
    {
        int total = SumOfDigits(digits);
        return number % total == 0;
    }

    // Correct frequency logic
    public static int[,] FindFrequency(int[] digits)
    {
        int[,] freq = new int[10, 2];

        for (int i = 0; i < 10; i++)
        {
            freq[i, 0] = i;
            freq[i, 1] = 0;
        }

        for (int i = 0; i < digits.Length; i++)
        {
            freq[digits[i], 1]++;
        }

        return freq;
    }
}
