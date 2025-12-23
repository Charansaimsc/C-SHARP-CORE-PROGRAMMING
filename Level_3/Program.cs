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


            int number = 153;
            Console.WriteLine(NumberChecker.NumberCheckerDigits(number));

             int[] digits = NumberChecker.StoreDigits(number);
            Console.WriteLine(NumberChecker.DuckNumber(digits) ? "Yes" : "No");
            NumberChecker.FindLargestSecondLargest(digits);
        }
    }
}