using System;

public class Chocolates
{
    public int[] Distribution(int number, int persons)
    {
        int remainder = number % persons;
        int quotient = number /persons;
        return new int[] { quotient, remainder };
    }
}
