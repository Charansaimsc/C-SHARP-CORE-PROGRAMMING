using System;

public class MultiDimensionalArray
{
	public static void TwoDTo1D()
	{
		int rows = Convert.ToInt32(Console.ReadLine());
		int  columns = Convert.ToInt32(Console.ReadLine());
		int[,] arr = new int[rows,columns];
		int[] newArray1D = new int[rows*columns];
		for(int i = 0; i < rows; i++)
		{
			for(int j = 0; j < columns; j++)
			{
				arr[i, j] = Convert.ToInt32(Console.ReadLine());
			}
		}
		int index = 0;
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
				newArray1D[index++] = arr[i, j];
            }
        }
		for (int i = 0; i < newArray1D.Length; i++)
			Console.WriteLine(newArray1D[i]);

    }
}
