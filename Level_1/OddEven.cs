using System;

public class OddEven
{
	public static void Seperation()
	{
		int number = Convert.ToInt32(Console.ReadLine());
		int[] even = new int[number + 1];
		int[] original = new int[number + 1];
		int[] odd = new int[number + 1];
		for (int i = 0; i < number; i++)
		{
			original[i] = Convert.ToInt32(Console.ReadLine());
		}
		int j = 0;
		int k = 0;
		for (int i = 1; i < number; i++)
		{

			if (original[i] % 2 == 0)
			{
				even[j++] = original[i];
			}
			else
			{
				odd[k++] = original[i];
			}
		}

		Console.WriteLine("Even numbers:");
		for (int i = 0; i < j; i++)
		{
			Console.WriteLine(even[i]);
		}

		Console.WriteLine("Odd numbers:");
		for (int i = 0; i < k; i++)
		{
			Console.WriteLine(odd[i]);
		}
	}
}
