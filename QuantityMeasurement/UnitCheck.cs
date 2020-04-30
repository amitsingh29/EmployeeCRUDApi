using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurement
{
    public class UnitCheck
    {
        private int length;
        private string unit_type;

        public UnitCheck()
        {
        }

        public UnitCheck(int length)
        {
            this.length = length;
        }

        public UnitCheck(string unit_type, int length)
        {
            this.unit_type = unit_type;
            this.length = length;
        }

        public int EqualsValue()
        {
            return this.length;
        }

        public UnitCheck(string type)
        {
            this.unit_type = type;
        }

        public int ConvertFeetToInch()
        {
            return this.length * 12;
        }

        public double ConvertInchToFeet()
        {
            return this.length / 12;
        }

        public double CelciustoFarenheit()
        {
            return this.length * 33.8;
        }

        public int KgtoGram()
        {
            return this.length * 1000;
        }

        public override bool Equals(object obj)
        {
            if ((obj == null) || Object.ReferenceEquals(this, obj) || this.GetType().Equals(obj.GetType()))
                return true;

            return false;
        }

    }
}
