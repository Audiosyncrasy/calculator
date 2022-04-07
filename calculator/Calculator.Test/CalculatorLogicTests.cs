using System;
using calculator;
using Xunit;

namespace Calculator.Test
{
    public class CalculatorLogicTests
    {
        private CalculatorForm _calcForm;

        public CalculatorLogicTests()
        {
            _calcForm = new CalculatorForm();
        }

        [Theory]
        [InlineData(3, 5, 8)]
        [InlineData(-8.5, -3, -11.5)]
        [InlineData(0, 5, 5)]
        public void CalculatorForm_CalcSum_WhenGivenTwoNumbers_ReturnsSum(double num1, double num2, double expected)
        {
            var actual = _calcForm.CalcSum(num1, num2);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(3, 1, 2)]
        [InlineData(-2.255, -1.356, -0.8989999999999998)]
        [InlineData(-1, -3, 2)]
        public void CalculatorForm_CalcDifference_WhenGivenTwoNumbers_ReturnsDifference(double num1, double num2, double expected)
        {
            var actual = _calcForm.CalcDifference(num1, num2);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(3, 1, 3)]
        [InlineData(-4.3, -2.589, 1.6608729239088451)]
        public void CalculatorForm_CalcQuotient_WhenGivenTwoNumbers_ReturnsQuotient(double num1, double num2, double expected)
        {
            var actual = _calcForm.CalcQuotient(num1, num2);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1, 0, double.PositiveInfinity)]
        public void CalculatorForm_CalcQuotient_WhenDividingByZero_ReturnsException(double num1, double num2, double expected)
        {
            var actual = _calcForm.CalcQuotient(num1, num2);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(3, 1, 3)]
        [InlineData(2.356, 5.489, 12.932084)]
        [InlineData(-5, 2, -10)]
        [InlineData(3, 0, 0)]
        public void CalculatorForm_CalcProduct_WhenGivenTwoNumbers_ReturnProduct(double num1, double num2, double expected)
        {
            var actual = _calcForm.CalcProduct(num1, num2);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("1", "0", "1")]
        [InlineData("1", "123", "1231")]
        [InlineData(".", "0", "0.")]
        public void CalculatorForm_ClearZeroAndConcatIntExceptWhenDecimal_ClearsZeroWhenConcatenatingExceptWhenDecimal(string input, string resultsBox, string expected)
        {
            _calcForm.returnResultBox().Text = resultsBox;
            _calcForm.ClearZeroAndConcatIntExceptWhenDecimal(input);

            var actual = _calcForm.returnResultBox().Text;

            Assert.Equal(expected, actual);
        }
    }
}