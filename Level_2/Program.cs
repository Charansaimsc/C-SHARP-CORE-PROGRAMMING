using System;
namespace Level_2
{
    public class Program
    {
        static void Main(string[] args)
        {
            //int number = Convert.ToInt32(Console.ReadLine());
            //int[] factors = NumberFactors.FindFactors(number);
            //for (int i = 0; i < factors.Length; i++)
            //{
            //    Console.WriteLine(factors[i] + "  ");
            //}
            //Console.WriteLine(" \n"+NumberFactors.Sum(factors));
            //Console.WriteLine(NumberFactors.Product(factors));
            //Console.WriteLine(NumberFactors.PowerOfFactors(factors));


            // int number = int.Parse(Console.ReadLine());
            //Console.WriteLine( NaturalNumbersSum.UsingRecurrsion(number));

            // Console.WriteLine(NaturalNumbersSum.WithoutUsingRecurrsion(number));


            //int year = int.Parse(Console.ReadLine());
            //if (LeapYear.Calculate(year))
            //{
            //    Console.WriteLine("Leap Year");
            //}
            //else
            //{

            //    Console.WriteLine(" not Leap Year");
            //}


            double km = int.Parse(Console.ReadLine());
            Console.WriteLine(UnitConverter.KmToMiles(km));
            double miles = int.Parse(Console.ReadLine());
            Console.WriteLine(UnitConverter.MilesToKm(miles));
            double meters = int.Parse(Console.ReadLine());
            Console.WriteLine(UnitConverter.MetersToFeet(meters));
            double feet = int.Parse(Console.ReadLine());
            Console.WriteLine(UnitConverter.FeetToMeters(feet));






        }
    }

}