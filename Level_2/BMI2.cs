/* Rewrite the above program using multi-dimensional array to store height, weight, and BMI in
2D array for all the persons
Hint =>
a. Take input for a number of persons
b. Create a multi-dimensional array to store weight, height and BMI. Also create an to store
the weight status of the persons
double[][] personData = new double[number][3];
String[] weightStatus = new String[number];*/
using System;

public class BMIJagged
{
    public static void WeightStatusMultiDim()
    {
        int number = Convert.ToInt32(Console.ReadLine());

        double[][] personData = new double[number][];
        string[] weightStatus = new string[number];

        for (int i = 0; i < number; i++)
        {
            personData[i] = new double[3];

            while (true)
            {
                double w = double.Parse(Console.ReadLine());
                if (w > 0)
                {
                    personData[i][0] = w;
                    break;
                }
            }

            while (true)
            {
                double h = double.Parse(Console.ReadLine());
                if (h > 0)
                {
                    personData[i][1] = h;
                    break;
                }
            }

            personData[i][2] = personData[i][0] /
                              (personData[i][1] * personData[i][1]);

            if (personData[i][2] < 18.5)
                weightStatus[i] = "Underweight";
            else if (personData[i][2] < 25)
                weightStatus[i] = "Normal";
            else if (personData[i][2] < 30)
                weightStatus[i] = "Overweight";
            else
                weightStatus[i] = "Obese";
        }

        for (int i = 0; i < number; i++)
        {
            Console.WriteLine(
                personData[i][1] + " " +
                personData[i][0] + " " +
                personData[i][2] + " " +
                weightStatus[i]
            );
        }
    }
}
