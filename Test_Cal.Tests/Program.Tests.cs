using System;
using Xunit;

namespace Test_Cal.Tests
{
    public class ProgramShould
    {
        [Fact]

        //Switch
        public void MultiplyWhenSelectingMultiplicationCase()
        {
            double expected = 50;

            double actual = Program.CalculationChoiceAndResult("*", 5, 10);

            Assert.Equal(expected, actual);


        }
        [Fact]
        public void SubtractWhenSelectingSubtractionCase()
        {
            double expected = 6;

            double actual = Program.CalculationChoiceAndResult("-", 10, 4);

            Assert.Equal(expected, actual);
        }
        [Fact]
        public void DivideWhenSelectingDivisionCase()
        {
            double expected = 25;

            double actual = Program.CalculationChoiceAndResult("/", 50, 2);

            Assert.Equal(expected, actual);
        }
        [Fact]
        public void AddWhenSelectingAdditionCase()
        {
            double expected = 100;

            double actual = Program.CalculationChoiceAndResult("+", 75, 25);

            Assert.Equal(expected, actual);
        }
    }
}