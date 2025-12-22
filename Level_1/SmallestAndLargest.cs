using System;

public class SmallestAndLargest
{
	public ( int smallest ,int largest ) Calculation(int num1,int num2,int num3)
	{
		int smallest = num1;
		int largest = num1;
		if (num2 < smallest)
		{
			smallest = num2;
		}
		if (num3 < smallest)
		{
			smallest = num3;
		}
		if (num2 > largest)
		{
			largest = num2;
		}
		if (num3 > largest)
		{
			largest = num3;
		}
		return (largest, smallest);
	}
}
