using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurement
{
    public class Feet
    {
        private int feet;
        private object obj;

        public Feet()
        {
        }

        public Feet(object obj)
        {
            this.obj = obj;
        }
        public Feet(int feet)
        {
            this.feet = feet;
        }

        public int ConvertFeetToInch()
        {
            return this.feet;
        }

        public override bool Equals(object obj)
        {
            if ((obj == null) || Object.ReferenceEquals(this, obj) || this.GetType().Equals(obj.GetType()))
                return true;

            return false;
        }
    }
}
