using System;

public class ToggleCase
{
	public static void  Change()

	{
		string s = "ChaRan";
		string result = "";
		for (int i = 0; i < s.Length; i++)
		{
			char c = s[i];
			if (c >= 'a' && c <= 'z')
			{
				result = result + (char)(c - 32);
			}else if (c >= 'A' && c <= 'Z')
			{
				result = result + (char)(c + 32);
			}
			else
			{
				result += c;
			}
		}
		Console.WriteLine(result);

	}
}
