/*Write a program that generates five 4 digit random values and then finds their
average value, and their minimum and maximum value. Use Math.Random(), Math.Min(),
and Math.Max().
Hint =>
a. Write a method that generates array of 4 digit random numbers given the size
as a parameter as shown in the method signature
public int[] Generate4DigitRandomArray(int size)
b. Write a method to find average, min and max value of an array
public double[] FindAverageMinMax(int[] numbers)*/


using System;

public class OperationsOnRandomNumbers
{
	public static int[] GenerateRandomNumbers(int size)
	{
		int[] numbers = new int[5];
		Random rnd = new Random();
		for(int i = 0; i < 5; i++)
		{
			numbers[i] =rnd.Next(1000,10000);
		}
		return numbers;
	}
	public static double[] MinMaxAvg(int[] numbers)
	{
		int minimum = numbers[0];
		int maximum = numbers[0];
		int sum = 0;
		for(int i = 0; i < numbers.Length; i++)
		{
			sum += numbers[i];
			minimum = Math.Min(minimum, numbers[i]);
			maximum=Math.Max(maximum, numbers[i]);
		}
		double avg = (double)sum / numbers.Length;
		return new double[] { avg, minimum, maximum };
	}
}
