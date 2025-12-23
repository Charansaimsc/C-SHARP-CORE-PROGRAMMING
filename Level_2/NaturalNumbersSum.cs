using System;

public class NaturalNumbersSum
{
	public  static int  WithoutUsingRecurrsion(int number )
	{
		int result = (number*number +number )/2;
		return result;
	}
	public static  int UsingRecurrsion(int number)
	{
		int sum = 0;
		if (number == 0)
		{
			return 0;
		}
		return number + UsingRecurrsion(number-1);

	}

}
