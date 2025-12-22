using System;

public class SimpleInterest
{
	public  int CalculateSI(int principal,int rate,int time)
	{
		int simpleInterst = (principal*rate*time)/ 100;
		return simpleInterst;
	}
}
