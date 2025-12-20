using System;

public class FizzBuzz
{
	public static void Solution()
	{
		int number = Convert.ToInt32(Console.ReadLine());
		string[] array = new string[number];
		for (int i = 1; i <= number; i++)
		{
			if(i%3 == 0 && i % 5 == 0)
			{
				array[i-1] = "FizzBuzz";
			}
			else if (i % 3 == 0)
			{
				array[i-1] = "Fizz";
			}
			else if(i % 5 == 0)
			{
				array[i-1] = "Buzz";
			}
			else
			{
				array[i - 1] = i.ToString();
			}
		}
		for (int i = 0; i < array.Length; i++)
		{
			Console.WriteLine(array[i]);
		}
	}
}
