/*a. Method To convert kilometers to miles and return the value. Use the following
code double km2miles = 0.621371;
b. Method to convert miles to kilometers and return the value. Use the following
code double miles2km = 1.60934;

c. Method to convert meters to feet and return the value. Use the following code
to convert double meters2feet = 3.28084;
d. Method to convert feet to meters and return the value. Use the following code
to convert double feet2meters = 0.3048;*/


using System;

public class UnitConverter
{
	public static double KmToMiles(double km)
	{
		double miles = km * 0.621;
		return miles;
	}

    public static double MilesToKm(double miles)
    {
        double km = miles * 1.609;
        return km;
    }

    public static double MetersToFeet(double meters)
    {
        return meters * 3.28084;
    }
    public static double FeetToMeters(double feet)
    {
        return feet * 0.3048;
    }
}
