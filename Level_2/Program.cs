using System;
namespace Level_2
{
    public class Program
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            int[] factors = NumberFactors.FindFactors(number);
            for (int i = 0; i < factors.Length; i++)
            {
                Console.WriteLine(factors[i] + "  ");
            }
            Console.WriteLine(" \n"+NumberFactors.Sum(factors));
            Console.WriteLine(NumberFactors.Product(factors));
            Console.WriteLine(NumberFactors.PowerOfFactors(factors));
        }
    }

}