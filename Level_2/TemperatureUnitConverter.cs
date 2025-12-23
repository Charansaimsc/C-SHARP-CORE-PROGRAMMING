using System;

public class UnitConvert
{
    
    public static double ConvertFahrenheitToCelsius(double fahrenheit)
    {
        double farhenheit2celsius = (fahrenheit - 32) * 5 / 9;
        return farhenheit2celsius;
    }

    
    public static double ConvertCelsiusToFahrenheit(double celsius)
    {
        double celsius2farhenheit = (celsius * 9 / 5) + 32;
        return celsius2farhenheit;
    }

    
    public static double ConvertPoundsToKilograms(double pounds)
    {
        double pounds2kilograms = 0.453592;
        return pounds * pounds2kilograms;
    }

    
    public static double ConvertKilogramsToPounds(double kilograms)
    {
        double kilograms2pounds = 2.20462;
        return kilograms * kilograms2pounds;
    }

    public static double ConvertGallonsToLiters(double gallons)
    {
        double gallons2liters = 3.78541;
        return gallons * gallons2liters;
    }

    public static double ConvertLitersToGallons(double liters)
    {
        double liters2gallons = 0.264172;
        return liters * liters2gallons;
    }
}
