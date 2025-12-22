using System;

public class ReplaceWord
{
	public static void  Sentence()
	{
		string s = " hai hello hai how r u";
		string replacingString = "hai";
		string newString = "hello";
		if (s.Contains(replacingString))
		{
			s = s.Replace(replacingString, newString);
		}
		Console.WriteLine(s);
	}
}
