using System;

public class NumberChecker
{
	public static int  NumberCheckerDigits(int number)
	{
		int count = 0;
		while (number != 0)
		{
			number = number / 10;
			count++;

		}
		return count;
	}
	public static int[] StoreDigits(int number)
	{
		int size = NumberCheckerDigits(number);
		int[] digits = new int[size];
		for (int i = 0; i < size; i++)
		{
			digits[i] = number % 10;
			number = number / 10;


		}
		return digits;
	}
	public static bool DuckNumber(int[] digits)
	{
		for (int i = 0; i < digits.Length-1; i++)
		{
			if(digits[i] == 0){
			return true;
		}
		}
		return false;
	}
	public static void FindLargestSecondLargest(int[] digits)
	{
		int largest = int.MinValue;

		int secLargest = int.MinValue;
		for (int i = 0; i < digits.Length; i++)
		{
			if (digits[i] > largest)
			{
				secLargest = largest;
				largest = digits[i];
			}
			else if (digits[i] > secLargest && largest != digits[i])
			{
				secLargest = digits[i];
			}
		}
		Console.WriteLine(largest+"                                               "+secLargest);
	}
}
