using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurement
{
    public class Gram
    {
        public int gram;

        public Gram()
        {
        }

        public Gram(int gram)
        {
            this.gram = gram;
        }

        public int EqualsValue()
        {
            return this.gram;
        }

        public override bool Equals(object obj)
        {
            if ((obj == null) || Object.ReferenceEquals(this, obj) || this.GetType().Equals(obj.GetType()))
                return true;

            return false;
        }

    }
}
