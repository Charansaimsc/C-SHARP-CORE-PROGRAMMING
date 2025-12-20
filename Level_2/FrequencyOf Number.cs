using System;

public class DigitFrequency
{
    public static void FindFrequency()
    {
        Console.WriteLine("Enter a number:");
        long number = int.Parse(Console.ReadLine());
        int temp = number;

        int count = 0;
        while (temp > 0)
        {
            temp /= 10;
            count++;
        }

        
        int[] digits = new int[count];
        temp = number;
        int index = 0;
        while (temp > 0)
        {
            digits[index++] = temp % 10;
            temp /= 10;
        }

      
        int[] frequency = new int[10]; 
        for (int i = 0; i < digits.Length; i++)
        {
            frequency[digits[i]]++;
        }

        
        Console.WriteLine("Digit : Frequency");
        for (int i = 0; i < 10; i++)
        {
            if (frequency[i] > 0)
                Console.WriteLine(i + " : " + frequency[i]);
        }
    }
}
