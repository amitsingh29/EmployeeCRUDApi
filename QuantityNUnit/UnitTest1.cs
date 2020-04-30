using NUnit.Framework;
using QuantityMeasurement;

namespace QuantityNUnit
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GivenValueIn_FeetClassEqualsValueFunction_WhenAnalyse_ReturnEqual()
        {
            UnitCheck feet = new UnitCheck("Feet", 0);
            int result = feet.EqualsValue();
            Feet feet1 = new Feet(0);
            int expected = feet1.ConvertFeetToInch();
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void GivenNullTo_EqualsMethod_WhenAnalyse_ReturnTrue()
        {
            UnitCheck feet = new UnitCheck("Feet");
            bool actual = feet.Equals(null);
            Assert.IsTrue(actual);
        }

        [Test]
        public void GivenReferenceTo_EqualsMethod_WhenAnalyse_ReturnTrue()
        {
            UnitCheck feet = new UnitCheck("Feet");
            bool actual = feet.Equals(feet);
            Assert.IsTrue(actual);
        }

        [Test]
        public void GivenObjectType_WhenAnalyse_ReturnTrue()
        {

            UnitCheck feet = new UnitCheck("Feet");
            bool result = feet.Equals(new UnitCheck());
            Assert.IsTrue(result);
        }

        [Test]
        public void GivenValueToFeetClass_WhenAnalyse_ReturnEqual()
        {
            UnitCheck feet = new UnitCheck("Feet", 5);
            int actual = feet.EqualsValue();
            int expected = 5;
            Assert.AreEqual(expected, actual);
        }


        [Test]
        public void GivenValueIn_InchClassEqualsValueFunction_WhenAnalyse_ReturnEqual()
        {
            UnitCheck inch = new UnitCheck("Inch", 0);
            int actual = inch.EqualsValue();
            int expected = 0;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GivenNullTo_InchClassEqualsMethod_WhenAnalyse_ReturnTrue()
        {
            UnitCheck inch = new UnitCheck("Inch", 0);
            bool actual = inch.Equals(null);
            Assert.IsTrue(actual);
        }

        [Test]
        public void GivenReferenceTo_InchClassEqualsMethod_WhenAnalyse_ReturnTrue()
        {
            UnitCheck inch = new UnitCheck("Inch");
            bool actual = inch.Equals(inch);
            Assert.IsTrue(actual);
        }

        [Test]
        public void GivenObjectTo_InchClassEqualsMethod_WhenAnalyse_ReturnTrue()
        {
            UnitCheck inch = new UnitCheck("Inch");
            bool actual = inch.Equals(new Inch());
            Assert.IsTrue(actual);
        }


        [Test]
        public void GivenValueTo_InchClass_WhenAnalyse_ReturnEqual()
        {
            UnitCheck inch = new UnitCheck(10);
            int actual = inch.EqualsValue();
            int expected = 10;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Give_15_Feet_and_15_Inch_Should_Return_Equal()
        {
            UnitCheck feet = new UnitCheck("Feet", 15);
            int expected = feet.EqualsValue();
            UnitCheck inch = new UnitCheck("Inch", 15);
            int actual = inch.EqualsValue();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Compare_1ft_And_1inch_return_Equal()
        {
            UnitCheck feet = new UnitCheck("Feet", 1);
            int expected = feet.EqualsValue();
            UnitCheck inch = new UnitCheck("Inch", 1);
            int actual = inch.EqualsValue();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Compare_1Feet_NotEqual_to_1_inch_return_False()
        {
            UnitCheck feet = new UnitCheck("Feet", 1);
            int actual = feet.ConvertFeetToInch();
            Inch inch = new Inch(1);
            int expected = inch.CheckInch_Value();
            Assert.AreNotEqual(expected, actual);
        }

        [Test]
        public void Compare_1inch_Not_Equal_to_1ft_return_False()
        {
            UnitCheck inch = new UnitCheck("Inch", 1);
            double actual = inch.ConvertInchToFeet();
            Feet feet = new Feet(1);
            int expected = feet.ConvertFeetToInch();
            Assert.AreNotEqual(expected, actual);
        }

        [Test]
        public void Compare_1Feet_Equal_to_12_inch_return_True()
        {
            UnitCheck feet = new UnitCheck("Feet", 1);
            int actual = feet.ConvertFeetToInch();
            Inch inch = new Inch(12);
            int expected = inch.CheckInch_Value();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Compare_12_inch_Equal_to_1_Feet_return_True()
        {
            UnitCheck inch = new UnitCheck("Inch", 12);
            double actual = inch.ConvertInchToFeet();
            Feet feet = new Feet(1);
            int expected = feet.ConvertFeetToInch();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Compare_1kg_Equal_to_1000gm_return_True()
        {
            UnitCheck kg = new UnitCheck("Kilogram", 1);
            double actual = kg.KgtoGram();
            Gram gm = new Gram(1000);
            int expected = gm.EqualsValue();
            Assert.AreEqual(expected, actual);
        }


        [Test]
        public void Compare_1_Gram_Equal_to_1_Gram_return_True()
        {
            UnitCheck gram = new UnitCheck("Gram", 1);
            double actual = gram.EqualsValue();
            Gram gm = new Gram(1);
            int expected = gm.EqualsValue();
            Assert.AreEqual(expected, actual);
        }
    }
}