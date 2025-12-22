using System;
namespace Level_1
{
    public class Program
    {
        static void Main(string[] args)
        {
            //
            //    int principal = Convert.ToInt32(Console.ReadLine());
            //    int rate = Convert.ToInt32(Console.ReadLine());
            //    int time = Convert.ToInt32(Console.ReadLine());
            //    SimpleInterest S = new SimpleInterest();
            //    Console.WriteLine("the simple interest is : " + S.CalculateSI(principal,rate,time));

            //int studentsCount = Convert.ToInt32(Console.ReadLine());
            //HandShakes Hs = new HandShakes();
            //Console.WriteLine(Hs.Calculate(studentsCount));

            //int side1 = int.Parse(Console.ReadLine());
            //int side2 = int.Parse(Console.ReadLine());
            //int side3 = int.Parse(Console.ReadLine());
            //TriangularPark obj = new TriangularPark();
            //Console.WriteLine(obj.CompleteRounds(side1, side2, side3));


            //int number = int.Parse(Console.ReadLine());
            //NumberAnalysis obj = new NumberAnalysis();
            //Console.WriteLine(obj.PosOrNegOrZero(number));

            //int day =int.Parse(Console.ReadLine());
            //int month = int.Parse(Console.ReadLine());
            //SpringSeason obj = new SpringSeason();
            //bool result = obj.SpringCheck(day, month);
            //if (result)
            //{
            //    Console.WriteLine("its a sptikng");
            //}
            //else {
            //    Console.WriteLine(" not a  sptikng");
            //}



            //int number = Convert.ToInt32(Console.ReadLine());
            //NaturalNumbers obj = new NaturalNumbers();
            //Console.WriteLine(obj.Sum(number));


            //int num1 = Convert.ToInt32(Console.ReadLine());
            //int num2 = Convert.ToInt32(Console.ReadLine());
            //int num3 = Convert.ToInt32(Console.ReadLine());
            //SmallestAndLargest obj = new SmallestAndLargest();
            //var result = obj.Calculation(num1, num2, num3);
            //Console.WriteLine(result.smallest);
            //Console.WriteLine(result.largest);


            //int number =Convert.ToInt32(Console.ReadLine());
            //int divisor = Convert.ToInt32(Console.ReadLine());
            //QuotientAndRemainder obj = new QuotientAndRemainder();
            //int[] result = obj.Calculation(number, divisor);
            //Console.WriteLine(result[0] + "           " + result[1]);




            int number =Convert.ToInt32(Console.ReadLine());
            int persons = Convert.ToInt32(Console.ReadLine());
            Chocolates obj = new Chocolates();
            int[] result = obj.Distribution(number, persons);
            Console.WriteLine(result[0] + "           " + result[1]);



















        }
    }
}