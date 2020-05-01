using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurement
{
    public class Celcius
    {
        public int celcius;

        public Celcius()
        {
        }

        public Celcius(int celcius)
        {
            this.celcius = celcius;
        }

        public int EqualsValue()
        {
            return this.celcius;
        }

        public override bool Equals(object obj)
        {
            if ((obj == null) || Object.ReferenceEquals(this, obj) || this.GetType().Equals(obj.GetType()))
                return true;

            return false;
        }
    }
}
