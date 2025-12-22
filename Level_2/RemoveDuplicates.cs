using System;

public class RemoveDuplicates
{
	public static void removalOfDuplicates()
	{
		string s = " charan";
		string s1 = "";
		for(int i = 0; i < s.Length; i++)
		{
			if (s1.Contains(s[i]))
			{
				continue;
			}
			else
			{
				s1 = s1 + s[i];
			}
		}
		Console.WriteLine(s1);
	}
}
