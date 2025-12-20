using System;

public class BMIIndex
{
    public static void weightStatus()
    {
        int number = Convert.ToInt32(Console.ReadLine());

        double[] weight = new double[number];
        double[] height = new double[number];
        double[] BMI = new double[number];
        string[] weightStatus = new string[number];

        for (int i = 0; i < number; i++)
        {
            Console.WriteLine("Enter weight (kg):");
            weight[i] = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter height (meters):");
            height[i] = double.Parse(Console.ReadLine());
        }

        for (int i = 0; i < number; i++)
        {
            BMI[i] = weight[i] / (height[i] * height[i]);

            if (BMI[i] < 18.5)
            {
                weightStatus[i] = "Underweight";
            }
            else if (BMI[i] < 25)
            {
                weightStatus[i] = "Normal";
            }
            else if (BMI[i] < 30)
            {
                weightStatus[i] = "Overweight";
            }
            else
            {
                weightStatus[i] = "Obese";
            }
        }

        for (int i = 0; i < number; i++)
        {
            Console.WriteLine(
                "Height: " + height[i] +
                " Weight: " + weight[i] +
                " BMI: " + BMI[i] +
                " Status: " + weightStatus[i]
            );
        }
    }
}
