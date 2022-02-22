using calculator;
using Xunit;

namespace Calculator.Test
{
    public class CalculatorLogicTests
    {
        [Theory]
        [InlineData(3, 5, 8)]
        [InlineData(-8, -3, -11)]
        [InlineData(0, 5, 5)]
        public void CalculatorForm_CalcSum_WhenGivenTwoNumbers_ReturnsSum(int num1, int num2, int expected)
        {
            var calcForm = new CalculatorForm();

            var actual = calcForm.CalcSum(num1, num2);

            Assert.Equal(expected, actual);
        }
    }
}