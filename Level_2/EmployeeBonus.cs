using System;

public class EmployeeBonus
{
	public static void Calculation()
	{
		int totalemployees = 10;
		double[] oldsalary = new double[totalemployees];

        double[] newsalary = new double[totalemployees];
        double[] experience = new double[totalemployees];
        double[] bonus = new double[totalemployees];
        for (int i = 0; i < totalemployees; i++)
        {
            Console.WriteLine("enter salary");
            oldsalary[i] = double.Parse(Console.ReadLine());
            Console.WriteLine("enter expereience");
            experience[i] = double.Parse(Console.ReadLine());
            if (oldsalary[i] < 0 || experience[i] < 0)
            {
                Console.WriteLine("re-enter details");
                i--;
            }
        }
        for (int i = 0; i < totalemployees; i++)
        {
            if (experience[i] < 5)
            {
                bonus[i] = 0.02 * oldsalary[i];
            }
            else
            {
                bonus[i] = 0.05 * oldsalary[i];
            }
        }
        for (int i = 0; i < totalemployees; i++)
        {
            newsalary[i] = bonus[i] + oldsalary[i];
        }
        for (int i = 0; i < totalemployees; i++)
        {


            Console.WriteLine("oldsalary" + oldsalary[i]+"  and bonus :" + bonus[i]+" combined total : " + newsalary[i]);
            }
        }
    }
