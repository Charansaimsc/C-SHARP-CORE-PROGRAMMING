using System;

public class ReverseArray
{
    public static void digitsReverse()
    {
        int num = int.Parse(Console.ReadLine());

        int temp = num;
        int count = 0;

     
        while (temp > 0)
        {
            temp /= 10;
            count++;
        }

        int[] digits = new int[count];

        temp = num;
        for (int i = 0; i < count; i++)
        {
            digits[i] = temp % 10;
            temp /= 10;
        }
Console.Write("Reversed Number: ");
        for (int i = 0; i < digits.Length; i++)
        {
            Console.Write(digits[i]);
        }
    }
}
