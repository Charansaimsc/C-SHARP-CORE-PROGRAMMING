using System;

public class NumberFactors
{
	public static int[] FindFactors(int number)
	{
		int count = 0;
		for(int i = 1; i <= number ; i++)
		{
			if (number % i == 0)
			{
				count++;
			}

		}
		int[] factors = new int[count];
        int index = 0;
        for (int i = 1; i <= number; i++)
		{
		

            if (number % i == 0)
			{
				factors[index] = i;
				index++;
			}
        }
				
         return factors;
	}
		public static  int Sum(int[] factors) 
		{
		int sum = 0;
		for(int i = 0; i < factors.Length; i++)
		{
			sum += factors[i];
		}
		return sum;

	    }
        public static  int Product(int[] factors)
	    {
		int product = 1;
        for (int i = 0; i < factors.Length; i++)
        {
            product *= factors[i];
        }
        return product;

        }
	public static double PowerOfFactors(int[] factors)
	{
		double sum = 0;
        for (int i = 0; i < factors.Length; i++)
		{
			sum += Math.Pow(factors[i],2);
		}
		return sum;
    }

	
}
