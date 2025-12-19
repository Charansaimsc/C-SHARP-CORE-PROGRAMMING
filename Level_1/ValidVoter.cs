using System;

public class ValidVoter
{
	public static void StudentVotes()
	{
		Console.WriteLine("Enter no of students:  ");
		int n = int.Parse(Console.ReadLine());
		int[] age = new int[n];
		for (int i = 0; i < n; i++)
		{
			age[i] = int.Parse(Console.ReadLine());
		}
		for (int i = 0; i < n; i++)
		{
			if (age[i] < 0)
			{
				Console.Error.WriteLine("invalid age");
				Environment.Exit(0);

			}
			else if (age[i] > 18)
			{
				Console.WriteLine("eligible");
			}
			else
			{
				Console.WriteLine("not eligible");
			}

		}
	}
}
