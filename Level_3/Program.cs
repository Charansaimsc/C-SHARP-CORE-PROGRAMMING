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


            int number = 95560;
            int[] digits = NumberChecker2.FindCountAndStore(number);
            Console.WriteLine(NumberChecker2.SumOfDigits(digits));
            Console.WriteLine(NumberChecker2.SumOfSquares(digits));
            Console.WriteLine(NumberChecker2.HarshadNumber(digits,number) ? "Yes" : " no");
            int[,] freq = NumberChecker2.FindFrequency(digits);

            Console.WriteLine("Digit Frequencies:");
            for (int i = 0; i < 10; i++)
            {
                if (freq[i, 1] > 0)
                    Console.WriteLine(freq[i, 0] + " → " + freq[i, 1]);
            }
        }
    }
}