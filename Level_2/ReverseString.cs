using System;

public class StringReverse
{
	public static void  WithoutInBuit()
	{
		string s = "charan";
		//string s1 = s.Substring(0,s.Length / 2);
		//string s2 = s.Substring((s.length / 2) + 1, s.length);
		string s1 = "";
		for(int i =s.Length-1; i >=0; i--)
		{
			s1+= s[i];
		}
		Console.WriteLine(s1);
	}
}
