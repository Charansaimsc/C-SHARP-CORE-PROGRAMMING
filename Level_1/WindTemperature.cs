using System;

public class WindTemperature
{
	public double FindWindChill(double windSpeed,double temperature)
	{
		double windChill = 35.74 + 0.6215 * temperature + (0.4275 * temperature - 35.75) * windSpeed*0.16;
		return windChill;

    }
}
