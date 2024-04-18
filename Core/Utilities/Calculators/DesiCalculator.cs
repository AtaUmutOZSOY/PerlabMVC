using System;

namespace Core.Utilities.Calculators
{
    public static class DesiCalculator
    {
        private const double DesiConstant = 3000; 

        public static double CalculateDesi(double height, double width, double length)
        {
            return (height * width * length) / DesiConstant;
        }

        public static double CalculateShippingWeight(double height, double width, double length, double actualWeight)
        {
            double desiWeight = CalculateDesi(height, width, length);
            return Math.Max(desiWeight, actualWeight);
        }
    }
}
