using System;

public class MarksOfStudent2
{
    public static void PercentageAndGradeMarksJagged()
    {
        int number = Convert.ToInt32(Console.ReadLine());

        int[][] marks = new int[number][];
        double[] percentage = new double[number];
        char[] grade = new char[number];

        for (int i = 0; i < number; i++)
        {
            marks[i] = new int[3];
            for (int j = 0; j < 3; j++)
            {
                while (true)
                {
                    int m = Convert.ToInt32(Console.ReadLine());
                    if (m >= 0)
                    {
                        marks[i][j] = m;
                        break;
                    }
                    Console.WriteLine("Invalid! Enter again");
                }
            }
        }

        for (int i = 0; i < number; i++)
        {
            int sum = 0;
            for (int j = 0; j < 3; j++)
            {
                sum += marks[i][j];
            }
            percentage[i] = (sum / 300.0) * 100;

            if (percentage[i] >= 80)
                grade[i] = 'A';
            else if (percentage[i] >= 70)
                grade[i] = 'B';
            else if (percentage[i] >= 40)
                grade[i] = 'C';
            else
                grade[i] = 'R';
        }

        for (int i = 0; i < number; i++)
        {
            Console.WriteLine("Student " + (i + 1));
            Console.WriteLine("Marks: " + string.Join(", ", marks[i]));
            Console.WriteLine("Percentage: " + percentage[i] + "%");
            Console.WriteLine("Grade: " + grade[i]);
            Console.WriteLine();
        }
    }
}
