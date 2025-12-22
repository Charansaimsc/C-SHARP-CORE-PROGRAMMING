using System;

public class NaturalNumbers
{
	public int Sum(int number)
	{
		int sum = 0;
		for(int i = 1; i < number+1; i++)
		{
			sum += i;
		}
		return sum;
	}
}
