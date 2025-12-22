using System;

public class RemoveSpecificChar
{
	public static void charRemoval()
	{
		string s = "charan";
		char remove = 'c';
		string result = s.Replace(remove.ToString(), " ");
		Console.WriteLine(result);
	}
}
