using System;

public class QuotientAndRemainder
{
	public int[] Calculation(int number,int divisor)
	{
		int remainder = number % divisor;
		int quotient = number / divisor;
		return new int[] { quotient, remainder };
	}
}
