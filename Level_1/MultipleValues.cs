using System;

public class MultipleValues
{
	public static void NoZeroAndNegative()
	{
		double sum = 0.0;
		double[] array = new double[10];
		int index = 0;
		while (true)
		{
			double value = double.Parse(Console.ReadLine());
			if (value <= 0 || index == 10)
			{
				break;
			}
			array[index] = value;
			index++;
		}
			for (int i = 0; i < 10; i++) {
				sum += array[i];
			}
			
		
        Console.WriteLine(sum);
    }
}
