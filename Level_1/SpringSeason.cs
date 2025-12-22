using System;

public class SpringSeason
{
	public bool SpringCheck(int day,int month)
	{
		if(month==3 && day >= 20 || month == 4 || month ==5 || month ==6 &&day<=20)
		{
			return true;
		}
		return false;
	}
}
