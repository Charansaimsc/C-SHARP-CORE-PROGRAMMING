using System;

public class MarksOfStudents
{
	public static void percentageAndGradeMarks()
	{
		int number = Convert.ToInt32(Console.ReadLine());
		int[,] marks = new int[number,3];
		int[] percentage = new int[3];
		char[] grade = new char[3];
		for (int i = 0; i < number; i++)
		{
			for (int j = 0; j < number; j++)
			{
				marks[i, j] = Convert.ToInt32(Console.ReadLine());
				if (marks[i, j] < 0)
				{
					Console.WriteLine("Invalid....! Enter again");
					j--;
					if (j == 0)
					{
						i--;
					}
				}
			}
		}
				int sum = 0;
				int percentages = 0;
				for(int i = 0; i < 3; i++)
				{
					for (int j = 0; j < 3; j++)
					{
						sum += marks[i,j];
						percentage[i] = sum / 100;
					}
                    if (percentage[i] > 80)
					{
						grade[i]= 'A';
					}else if(percentage[i] >70 && percentage[i] < 79)
					{
						grade[i]= 'B';
					}else if (percentage[i] < 39)
					{
						grade[i]= 'R';
					}
					else
					{
						grade[i]= 'c';
					}

                }

		for (int i = 0; i < number; i++)
		{
			for (int j = 0; j < number; j++)
			{
				Console.WriteLine("Marks : " + marks[i, j] + " percentage");
			}
			Console.WriteLine("Percentage : " + percentage[i] + "GrADES  :  " + grade[i]);

		}		
	}
}
