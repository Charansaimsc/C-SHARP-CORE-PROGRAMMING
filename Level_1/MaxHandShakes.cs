using System;

public class HandShakes
{
	public int  Calculate(int studentsCount)	{
		int total = (studentsCount * (studentsCount - 1) / 2);
		return total;
	}
}
