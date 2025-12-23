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


            //double km = int.Parse(Console.ReadLine());
            //Console.WriteLine(UnitConverter.KmToMiles(km));
            //double miles = int.Parse(Console.ReadLine());
            //Console.WriteLine(UnitConverter.MilesToKm(miles));
            //double meters = int.Parse(Console.ReadLine());
            //Console.WriteLine(UnitConverter.MetersToFeet(meters));
            //double feet = int.Parse(Console.ReadLine());
            //Console.WriteLine(UnitConverter.FeetToMeters(feet));



            //Console.WriteLine(UnitConverte.ConvertYardsToFeet(5));
            //Console.WriteLine(UnitConverte.ConvertFeetToYards(15));
            //Console.WriteLine(UnitConverte.ConvertMetersToInches(2));
            //Console.WriteLine(UnitConverte.ConvertInchesToMeters(10));
            //Console.WriteLine(UnitConverte.ConvertInchesToCentimeters(10));

            Console.WriteLine(UnitConvert.ConvertFahrenheitToCelsius(98.6));
            Console.WriteLine(UnitConvert.ConvertCelsiusToFahrenheit(37));
            Console.WriteLine(UnitConvert.ConvertPoundsToKilograms(10));
            Console.WriteLine(UnitConvert.ConvertKilogramsToPounds(5));
            Console.WriteLine(UnitConvert.ConvertGallonsToLiters(2));
            Console.WriteLine(UnitConvert.ConvertLitersToGallons(5));


    }
    }

}