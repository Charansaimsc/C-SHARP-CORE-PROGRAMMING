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


            //int[] age = new int[10];
            //for (int i = 0; i < 10; i++)
            //{
            //    age[i] = int.Parse(Console.ReadLine());

            //}
            //StudentVoteChecker obj = new StudentVoteChecker();

            //for (int i = 0; i < 10; i++)
            //{
            //    if (obj.CanStudentVote(age[i]))
            //    {
            //        Console.WriteLine("can vote");
            //    }
            //    else
            //    {
            //        Console.WriteLine("can't vote");
            //    }
            //}






            //int[] numbers = new int[5];


            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    numbers[i] = int.Parse(Console.ReadLine());
            //}

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (NumberCheck.IsPositive(numbers[i]))
            //    {
            //        if (NumberCheck.IsEven(numbers[i]))
            //        {
            //            Console.WriteLine(numbers[i] + " is Positive and Even");
            //        }
            //        else
            //        {
            //            Console.WriteLine(numbers[i] + " is Positive and Odd");
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine(numbers[i] + " is Negative");
            //    }
            //}


            //int result = NumberCheck.Compare(numbers[0], numbers[numbers.Length - 1]);

            //if (result == 1)
            //{
            //    Console.WriteLine("First element is greater than last element");
            //}
            //else if (result == 0)
            //{
            //    Console.WriteLine("First element is equal to last element");
            //}
            //else
            //{
            //    Console.WriteLine("First element is less than last element");
            //}



            //double[,] arr = new double[10, 3];

            //for (int i = 0; i < 10; i++)
            //{
            //    arr[i, 0] = Convert.ToDouble(Console.ReadLine()); // weight
            //    arr[i, 1] = Convert.ToDouble(Console.ReadLine()); // height

            //    arr[i, 2] = BMIStatus.BMICalculation(arr[i, 0], arr[i, 1]);
            //}

            //for (int i = 0; i < 10; i++)
            //{
            //    if (arr[i, 2] < 18.5)
            //    {
            //        Console.WriteLine("Underweight");
            //    }
            //    else if (arr[i, 2] >= 18.5 && arr[i, 2] <= 24.9)
            //    {
            //        Console.WriteLine("Normal");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Obese");
            //    }
            //}



            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());

            double[] roots = Quadratic.FindRoots(a, b, c);

            if (roots.Length == 2)
            {
                Console.WriteLine("Root 1: " + roots[0]);
                Console.WriteLine("Root 2: " + roots[1]);
            }
            else if (roots.Length == 1)
            {
                Console.WriteLine("Root: " + roots[0]);
            }
            else
            {
                Console.WriteLine("No real roots");
            }






        }
}

}