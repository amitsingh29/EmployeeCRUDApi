using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurement
{
    public class Kilogram
    {
        public int kg;

        public Kilogram()
        {
        }

        public Kilogram(int kg)
        {
            this.kg = kg;
        }

        public int EqualsValue()
        {
            return this.kg;
        }

        public override bool Equals(object obj)
        {
            if ((obj == null) || Object.ReferenceEquals(this, obj) || this.GetType().Equals(obj.GetType()))
                return true;

            return false;
        }

    }
}
