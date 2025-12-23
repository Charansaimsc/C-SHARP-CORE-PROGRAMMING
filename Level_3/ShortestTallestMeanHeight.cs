using System;

public class ShortestTallestMean
{
	public static int Sum(int[] arr)
	{
		int sum = 0;
		for (int i = 0; i < 11; i++) 
		{
			sum += arr[i];
		}
		return sum;
	}
	public static double Mean(int[] arr)
	{
		double sum = Sum(arr);
		double mean = sum / arr.Length;
		return mean;
	}
	public static int Shortest(int[] arr)
	{
		int shorter = arr[0];
		for(int i = 0; i < 11; i++)
		{
			 shorter =Math.Min(shorter, arr[i]);
		}
		return shorter;
	}
	public static int Tallest(int[] arr)
	{
		int taller = 0 ;
		for(int i = 0; i < 11; i++)
		{
			taller = Math.Max(taller, arr[i]);
		}
		return taller;
	}

}
