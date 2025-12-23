using System;

public class LeapYear
{
    public static bool Calculate(int year)
    {
        if (year < 1582)
        {
            return false;
        }

        if (year % 400 == 0)
        {
            return true;
        }
        if (year % 100 == 0)
        {
            return false;
        }
        if (year % 4 == 0)
        {
            return true;
        }

        return false;
    }
}
