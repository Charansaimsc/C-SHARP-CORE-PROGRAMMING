using System;
namespace level_3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Armstrong arm = new Armstrong();
            arm.Class1();

            DigitCounter dc = new DigitCounter();
            dc.Class1();

            HarshadNumber hn = new HarshadNumber();
            hn.Class1();

            AbundantNumber an = new AbundantNumber();
            an.Class1();

            DayOfWeek1 dw = new DayOfWeek1();
            dw.Class1();

            Calculator cal = new Calculator();
            cal.Class1();
        }
    }
}