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
        [InlineData(-8, -3, -11)]
        [InlineData(0, 5, 5)]
        public void CalculatorForm_CalcSum_WhenGivenTwoNumbers_ReturnsSum(int num1, int num2, int expected)
        {
            var actual = _calcForm.CalcSum(num1, num2);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("1", "0", "1")]
        [InlineData("1", "123", "1231")]
        public void CalculatorForm_ConcatIntExceptWhenZero_DoesntIncludeZeroWhenConcatenating(string input, string resultsBox, string expected)
        {
            _calcForm.returnResultBox().Text = resultsBox;
            _calcForm.ConcatIntExceptWhenZero(input);

            var actual = _calcForm.returnResultBox().Text;

            Assert.Equal(expected, actual);
        }
    }
}