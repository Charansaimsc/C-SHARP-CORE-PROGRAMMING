using System;

public class TrigonometricCalculator
{
    public double[] calculateTrigonometricFunctions(double angle)
    {
        double radians = angle * Math.PI / 180;

        double sine = Math.Sin(radians);
        double cosine = Math.Cos(radians);
        double tangent = Math.Tan(radians);

        return new double[] { sine, cosine, tangent };
    }
}

