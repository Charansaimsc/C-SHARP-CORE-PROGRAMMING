using System;

public class NullReferenceException
{
	public static void TryCatchExpetion()
	{
		string s1 = null;
		try
		{
			int length = s1.Length;
			Console.WriteLine(length);
		}
		catch (Exception e)
		{
			Console.WriteLine("caught");
			Console.WriteLine(e.Message);
		}

	}
}
