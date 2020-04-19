using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class QuantityRepository : IRepository
    {
        public decimal FeetToInch(QuantityModel value)
        {
            return value.Feet * 12;
        }

        public decimal InchToFeet(QuantityModel value)
        {
            return value.Inch / 12;
        }

        public decimal GramToKilogram(QuantityModel value)
        {
            return value.Gram / 1000;
        }

        public decimal MeterToCentimeter(QuantityModel value)
        {
            return value.Meter * 100;
        }

        public decimal CentimeterToMeter(QuantityModel value)
        {
            return value.Centimeter / 100;
        }

        public decimal KilogramToGram(QuantityModel value)
        {
            return value.Kilogram * 1000;
        }

    }
}
