using System;

public class FormatException
{
	public  static void usingTryCatchBlock()
	{
        string input = "charan";
        try
        {
            int num = int.Parse(input);
            Console.WriteLine("You entered: " + num);
        }
        catch (Exception e)
        {
            Console.WriteLine("FormatException caught!");
            Console.WriteLine("Message: " + e.Message);
        }
    }
}
