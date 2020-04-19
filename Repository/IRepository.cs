using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public interface IRepository
    {
        decimal FeetToInch(QuantityModel value);

        decimal InchToFeet(QuantityModel value);

        decimal MeterToCentimeter(QuantityModel value);

        decimal CentimeterToMeter(QuantityModel value);

        decimal KilogramToGram(QuantityModel value);

        decimal GramToKilogram(QuantityModel value);

    }
}
