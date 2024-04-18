using Core.Entity.Concretes;
using System;

namespace Core.Utilities.Calculators
{
    public class PriceCalculator
    {
        private readonly ShippingPrice _shippingPrice;
        public PriceCalculator(ShippingPrice shippingPrice)
        {
            _shippingPrice = shippingPrice;
        }
        

        public double CalculatePrice(double weight, double volume, double distance, bool isUrgent)
        {
            double price = _shippingPrice.BasePrice;
            price += weight * _shippingPrice.WeightFactor;
            price += volume * _shippingPrice.VolumeFactor;
            price += distance * _shippingPrice.DistanceFactor;

            if (isUrgent)
            {
                price *= _shippingPrice.UrgencyFactor;
            }

            return price;
        }
    }
}
