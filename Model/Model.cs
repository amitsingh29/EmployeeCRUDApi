using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Model
    {
        private decimal feet;

        private decimal inch;

        private decimal meter;

        private decimal centimeter;

        private decimal gram;

        private decimal kilogram;


        public decimal Feet
        {
            get
            {
                return this.feet;
            }
            set
            {
                this.feet = value;
            }
        }

        public decimal Inch
        {
            get
            {
                return this.inch;
            }
            set
            {
                this.inch = value;
            }
        }

        public decimal Gram
        {
            get
            {
                return this.gram;
            }
            set
            {
                this.gram = value;
            }
        }

        public decimal Meter
        {
            get
            {
                return this.meter;
            }
            set
            {
                this.meter = value;
            }
        }

        public decimal Centimeter
        {
            get
            {
                return this.centimeter;
            }
            set
            {
                this.centimeter = value;
            }
        }
        public decimal Kilogram
        {
            get
            {
                return this.kilogram;
            }
            set
            {
                this.kilogram = value;
            }
        }
    }
}


