using System;

public class IndexOutOfRange
{
	public static void UsingTryCtach()
	{
		string s = "charan";
		char[] arr = s.ToCharArray();
		try
		{
			char c = s[s.Length];
			Console.WriteLine(c);
		}catch(Exception e)
		{
			Console.WriteLine("caught");
			Console.WriteLine(e.Message);
		}
	}
}
