using System;

public class ArgumentOutOfException
{
	public static void  TryCatchBlock()
	{
		string s = "charan";
		try
		{
			string s1 = s.Substring(1, 5);
			Console.WriteLine("Exception");
		}
		catch (Exception e)
		{
			Console.WriteLine("caught");
			Console.WriteLine(e.Message);
		}
	}
}
