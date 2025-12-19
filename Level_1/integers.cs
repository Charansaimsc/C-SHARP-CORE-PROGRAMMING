using System;

public class integer
{
	public static void integers()
	{
		int[] num = new int[5];
		for (int i = 0; i < 5; i++)
		{
			num[i] = int.Parse(Console.ReadLine());
		}
		for (int i = 0; i < 5; i++)
		{
			if (num[i] < 0)
			{
				Console.WriteLine("negative number");
			}
			else if (num[i] > 0 && num[i] % 2 == 0)
			{
				Console.WriteLine("positive and even number");
			}
			else
			{
				Console.WriteLine("positive and Odd number");
			}
		}
	}
}
