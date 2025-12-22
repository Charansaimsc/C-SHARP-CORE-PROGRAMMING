using System;

public class ReturnCharacters
{
	  public static void  withoutTocharArray()
	{
		string s1 = Console.ReadLine();
		char[] arr = new char[s1.Length];
		char[] arr2 = new char[s1.Length];
        for (int i = 0; i < s1.Length; i++)
		{
			arr[i] = s1[i];
		}
		Console.WriteLine(arr);
		Console.Write(s1.ToCharArray());
	}
}
