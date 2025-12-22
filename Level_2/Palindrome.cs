using System;

public class Palindrome
{
	public static void check()
	{
		string s = "mdam";
		int a = 0;
		int b = s.Length - 1;
		while (a<b)
		{
			
				if (s[a] != s[s.Length - 1])
				{
					Console.WriteLine("not a Palindrome");
					return;

				}
				a++;
				b--;
		}
		Console.WriteLine("Palindrome");
	}
}
