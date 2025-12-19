using System;

public class Multiplication
{
	public static void Table()
	{
		int num = int.Parse(Console.ReadLine());
		int[] arr = new int[10];
		for (int i = 0; i < 10; i++)
		{
			arr[i] = num * (i + 1);
		}
		for (int i = 0; i < 10; i++)
		{
			Console.WriteLine(num +" * "+ (i + 1) + "==" + arr[i]);
		}
	}
}
