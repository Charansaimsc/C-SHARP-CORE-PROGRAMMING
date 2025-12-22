using System;

public class Anagaram
{
	public static void Check()
	{
		string s1 = "listen";
		string s2 = "silent";
		char[] arr1 = s1.ToCharArray();
		char[] arr2 = s2.ToCharArray();
		Array.Sort(arr1);
		Array.Sort(arr2);

        string sorted1 = new string(arr1);
        string sorted2 = new string(arr2);

        if (sorted1 == sorted2)
            Console.WriteLine("Anagram");
        else
            Console.WriteLine("Not an Anagram");
    }
}
