using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurement
{
    public class Farenheit
    {
        public double farenheit;

        public Farenheit()
        {
        }

        public Farenheit(double farenheit)
        {
            this.farenheit = farenheit;
        }

        public double EqualsValue()
        {
            return this.farenheit;
        }

        public override bool Equals(object obj)
        {
            if ((obj == null) || Object.ReferenceEquals(this, obj) || this.GetType().Equals(obj.GetType()))
                return true;

            return false;
        }
    }
}
