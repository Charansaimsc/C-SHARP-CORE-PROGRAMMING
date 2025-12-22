using System;

public class NumberAnalysis
{
	public string PosOrNegOrZero(int number)
	{
		if (number < 0)
		{
			return "negative";
		}
		else if (number > 1)
		{
			return "positive";
		}
		else
		{
			return "zero";
		}

	}
}
