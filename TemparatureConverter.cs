/*Temperature Converter:
Write a program that converts temperatures between Fahrenheit and Celsius.
● The program should have separate functions for converting from Fahrenheit to
Celsius and from Celsius to Fahrenheit.*/


using System;

public class TemparatureConverter
{
	public static void Class1()
	{
        Console.Write("Enter temperature in Celsius: ");
        double celsius = double.Parse(Console.ReadLine());

        double fahrenheit = CelsiusToFahrenheit(celsius);
        Console.WriteLine($"Celsius to Fahrenheit: {fahrenheit}");

        Console.WriteLine("Enter temperature in Fahrenheit: ");
        double fahrenheitInput = double.Parse(Console.ReadLine());

        double celsiusResult = FahrenheitToCelsius(fahrenheitInput);
        Console.WriteLine($"Fahrenheit to Celsius: {celsiusResult}");
    }
    //Celsius to fahrenheit
    static double CelsiusToFahrenheit(double c)
    {
        return (c * 9 / 5) + 32;
    }
    //Fahrenheit to Celsius
    static double FahrenheitToCelsius(double f)
    {
        return (f - 32) * 5 / 9;
    }
}
