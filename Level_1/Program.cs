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
             
            int studentsCount = Convert.ToInt32(Console.ReadLine());
            HandShakes Hs = new HandShakes();
            Console.WriteLine(Hs.Calculate(studentsCount));
        
       }
    }
}