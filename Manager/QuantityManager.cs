using Model;
using Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Manager
{
    public class QuantityManager : IManager
    {
        private IRepository repo;

        public QuantityManager(IRepository repo)
        {
            this.repo = repo;
        }

        public decimal CentimeterToMeter(QuantityModel value)
        {
            return this.repo.CentimeterToMeter(value);
        }

        public decimal FeetToInch(QuantityModel value)
        {
            return this.repo.FeetToInch(value);
        }

        public decimal GmtoKg(QuantityModel value)
        {
            return this.repo.FeetToInch(value);
        }

        public decimal InchToFeet(QuantityModel value)
        {
            return this.repo.InchToFeet(value);
        }

        public decimal KilogramToGram(QuantityModel value)
        {
            return this.repo.KilogramToGram(value);
        }

        public decimal MetertoCentimeter(QuantityModel value)
        {
            return this.repo.MeterToCentimeter(value);
        }
    }
}
