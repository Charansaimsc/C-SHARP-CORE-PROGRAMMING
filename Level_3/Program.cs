using System;
namespace Level_3
{
    public class Program 
    {
        static void Main(string[] args)
        {
            //int[] arr = new int[11];
            //Random rnd = new Random();
            //for(int i = 0; i < 11; i++)
            //{
            //    arr[i] = rnd.Next(150,251);
            //    Console.WriteLine(arr[i]);
            //}

            //Console.WriteLine(ShortestTallestMean.Sum(arr));
            //Console.WriteLine(ShortestTallestMean.Mean(arr));

            //Console.WriteLine(ShortestTallestMean.Tallest(arr));
            //Console.WriteLine(ShortestTallestMean.Shortest(arr));


            //int number = 153;
            //Console.WriteLine(NumberChecker.NumberCheckerDigits(number));

            // int[] digits = NumberChecker.StoreDigits(number);
            //Console.WriteLine(NumberChecker.DuckNumber(digits) ? "Yes" : "No");
            //NumberChecker.FindLargestSecondLargest(digits);


            //int number = 95560;
            //int[] digits = NumberChecker2.FindCountAndStore(number);
            //Console.WriteLine(NumberChecker2.SumOfDigits(digits));
            //Console.WriteLine(NumberChecker2.SumOfSquares(digits));
            //Console.WriteLine(NumberChecker2.HarshadNumber(digits,number) ? "Yes" : " no");
            //int[,] freq = NumberChecker2.FindFrequency(digits);

            //Console.WriteLine("Digit Frequencies:");
            //for (int i = 0; i < 10; i++)
            //{
            //    if (freq[i, 1] > 0)
            //        Console.WriteLine(freq[i, 0] + " → " + freq[i, 1]);
            //}



            //Console.WriteLine("Enter a number:");
            //int number = int.Parse(Console.ReadLine());

            //int[] digits = NumberChecker3.StoreDigits(number);

            //Console.WriteLine("Digits:");
            //foreach (int d in digits)
            //    Console.Write(d + " ");

            //Console.WriteLine("\nCount of digits: " + NumberChecker3.CountDigits(number));

            //int[] reversed = NumberChecker3.ReverseArray(digits);
            //Console.WriteLine("Reversed digits:");
            //foreach (int r in reversed)
            //    Console.Write(r + " ");

            //Console.WriteLine(
            //    NumberChecker3.IsPalindrome(number)
            //    ? "\nPalindrome Number"
            //    : "\nNot a Palindrome Number"
            //);

            //Console.WriteLine(
            //    NumberChecker3.IsDuckNumber(digits)
            //    ? "Duck Number"
            //    : "Not a Duck Number"
            //);





            //Console.WriteLine("Enter a number:");
            //int number = int.Parse(Console.ReadLine());

            //Console.WriteLine("\nResults:");

            //Console.WriteLine("Prime Number     : " + NumberChecker4.IsPrime(number));
            //Console.WriteLine("Neon Number      : " + NumberChecker4.IsNeon(number));
            //Console.WriteLine("Spy Number       : " + NumberChecker4.IsSpy(number));
            //Console.WriteLine("Automorphic No.  : " + NumberChecker4.IsAutomorphic(number));
            //Console.WriteLine("Buzz Number      : " + NumberChecker4.IsBuzz(number));

            //Console.ReadLine();


                Console.WriteLine("Enter a number:");
                int num = int.Parse(Console.ReadLine());

                int[] factors = NumberChecker5.Factors(num);

                Console.WriteLine("\nFactors:");
                foreach (int f in factors)
                    Console.Write(f + " ");

                Console.WriteLine("\n\nGreatest Factor: " +
                    NumberChecker5.GreatestFacter(factors));

                Console.WriteLine("Product of Factors: " +
                    NumberChecker5.Product(factors));

                Console.WriteLine("Product of Cubes of Factors: " +
                    NumberChecker5.ProductOfCubes(factors));

                Console.WriteLine("\nPerfect Number: " +
                    NumberChecker5.IsPerfectNumber(num));

                Console.WriteLine("Abundant Number: " +
                    NumberChecker5.AbundentNumber(num));

                Console.WriteLine("Deficient Number: " +
                    NumberChecker5.DeficientNumber(num));

                Console.WriteLine("Strong Number: " +
                    NumberChecker5.IsStrongNumber(num));

                Console.ReadLine();
           


































































    }
}
}