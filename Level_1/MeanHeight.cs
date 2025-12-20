using System;

public class MeanHeight
{
	public static void Players()
	{
		double[] height = new double[11];
		double sum = 0.0;
		for (int i = 0; i < 11; i++)
		{
			height[i] = double.Parse(Console.ReadLine());
			sum+= height[i];
		}
		Console.WriteLine("Mean Height of 11 players :" + (sum / 11.00));
	}
}
