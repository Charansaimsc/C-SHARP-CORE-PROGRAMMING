using System;

public class VowelsAndConsonants
{
	public static void  CountVowelsAndConsonants()
	{
	int consonantCount = 0;
	int vowelCount = 0;
	string s = "charan";
	for(int i = 0; i < s.Length; i++)
	{
		if (s[i] == 'a' || s[i]=='e'|| s[i]=='i'|| s[i] == 'o'|| s[i] == 'u')
		{
				vowelCount++;
		}
		else
		{
			consonantCount++;
		}
	}
	Console.WriteLine("number of vowels:  " + vowelCount + "\n" + "number of consonants: " + consonantCount);

	}
}
