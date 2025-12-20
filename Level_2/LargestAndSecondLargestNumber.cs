using System;

public class LargestAndSecondLargest
{
	public static void Function()
	{
		int number = int.Parse(Console.ReadLine());
		int maxDigits = 10;
		int[] digits = new int[maxDigits];
		int index = 0;
		while (number > 0)
		{
			if (index == maxDigits)
			{
				break;
			}
			digits[index] = number%10;
			number = number/10;
			index++;
		}
		Array.Sort(digits);
		Console.WriteLine("Largest : " + digits[digits.Length - 1]+"second largest: " + digits[digits.Length-2]);

	}
}
