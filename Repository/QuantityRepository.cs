using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class QuantityRepository : IRepository
    {
        RedisData redisData = new RedisData();
            
        public decimal FeetToInch(QuantityModel value)
        {
            decimal result = value.Feet * 12;
            redisData.RedisConnectionMultiplexer($"Meter", result.ToString());
            return result;
        }

        public decimal InchToFeet(QuantityModel value)
        {
            decimal result = value.Inch / 12;
            redisData.RedisConnectionMultiplexer($"Meter", result.ToString());
            return result;
        }
        public decimal GramToKilogram(QuantityModel value)
        {
            decimal result = value.Gram / 1000;
            redisData.RedisConnectionMultiplexer($"Meter", result.ToString());
            return result;
        }

        public decimal MeterToCentimeter(QuantityModel value)
        {
            decimal result = value.Meter * 100;
            redisData.RedisConnectionMultiplexer($"Meter", result.ToString());
            return result;
        }

        public decimal CentimeterToMeter(QuantityModel value)
        {
            decimal result = value.Centimeter / 100;
            redisData.RedisConnectionMultiplexer($"Centimeter", result.ToString());
            return result;
        }

        public decimal KilogramToGram(QuantityModel value)
        {
            decimal result = value.Kilogram * 1000;
            redisData.RedisConnectionMultiplexer($"Meter", result.ToString());
            return result;
        }
    }
}
