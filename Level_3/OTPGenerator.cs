using System;

public class OTPGenerator
{
	public static int[] RandomOTPs(int size)
	{
		int[] otps = new int[size];
		for (int i = 0; i < size; i++)
		{
			otps[i] = Random.Shared.Next(100000, 1000000);
		}
		return otps;
	}
	public static bool UniqueOrNot(int[] otps) 
	{
		HashSet<int> set = new HashSet<int>();
		for(int i = 0; i < otps.Length; i++)
		{
			set.Add(otps[i]);
		}
		if(set.Count != otps.Length) 
		{ 
			return false;
		}
		return true;
	}
}
