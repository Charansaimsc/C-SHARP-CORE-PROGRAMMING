using System;

public class YoungestOfAll
{
	public static void FindYoungestAndTallest()
	{
		string[] names = { "amar", "akabar", "anthony" };
		int[] age = new int[3];
		double[] height = new double[3];
		for(int i = 0; i < 3; i++)
		{
			Console.WriteLine("enter age");
			age[i]=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter height");
            height[i] =Convert.ToDouble(Console.ReadLine());

		}
		int indexTall = 0;
		int indexYoung = 0;
		for (int i = 0;i < 3; i++)
		{
			if (age[i] < age[indexYoung])
			{
				indexYoung = i;

			}
			if (height[i] > height[indexTall])
			{
				indexTall = i;
			}
		}
		Console.WriteLine("youngest : "+names[indexYoung]+" and  Tallest : " + names[indexTall]);
	}
}
