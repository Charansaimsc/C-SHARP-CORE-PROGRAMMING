using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace control_flow_Level_2
{
    public class BMIIndexx
    {
        public static void  BMIIndex()
        {
            double weight = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double bmi = weight / (height * height);
            if (bmi <= 18.4)
            {
                Console.WriteLine("UnderWeight");

            }
            else if (18.5 <= bmi && bmi <= 24.9)
            {
                Console.WriteLine("Normal");
            }
            else if (25.0 <= bmi && bmi <= 39.9)
            {
                Console.WriteLine("OverWeight");
            }
            else
            {
                Console.WriteLine("Obese");
            }
        }
    }
}
