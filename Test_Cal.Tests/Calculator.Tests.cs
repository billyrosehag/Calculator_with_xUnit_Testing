using System;
using Xunit;

namespace Test_Cal.Tests
{
    public class CalculatorShould
    {

        //Addition()
        [Theory]
        [InlineData(1, 3, 4)]
        [InlineData((-4), (-4), -8)]
        [InlineData(5, 5,10)]
        [InlineData(50,5,55)]
        [InlineData(3,3, 6)]
        [InlineData(200000000,1, 200000001)]
        public void AdditionShouldAdd(double numb1, double numb2, double expected)
        {
            double actual = Calculator.Addition(numb1, numb2);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void AddTogetherNumbersFromDoubleArray()
        {
            double[] testArray = new double[] { 5, 2, 20, 6, 19 };
            double[] testArray2 = new double[] { 70, -25 };

            double expected = 5 + 2 + 20 + 6 + 19;
            double expected2 = 70 + -25;
  
            double actual = Calculator.Addition(testArray);
            double actual2 = Calculator.Addition(testArray2);

            Assert.Equal(expected,actual);
            Assert.Equal(expected2, actual2);
        }
       
        [Fact]
        public void ReturnZeroWhenArrayIsEmpty()
        {
            double[] testArray = new double[0];

            double expected = 0;

            Assert.Equal(expected, Calculator.Addition(testArray));
            Assert.Equal(expected, Calculator.Subtraction(testArray));
        }
        [Fact]
        public void ReturnZeroWhenArrayIsNull()
        {
            double[] testArray = new double[] {double.NaN};

            double expected = 0;

            Assert.Equal(expected, Calculator.Addition(testArray));
            Assert.Equal(expected, Calculator.Subtraction(testArray));
        }

        //Division()
        [Theory]
        [InlineData(2, 2, 1)]
        [InlineData(-4, 1, -4)]
        [InlineData(25, 5, 5)]
        [InlineData(4, 2, 2)]
        [InlineData(15, 3, 5)]
        [InlineData(100, 4, 25)]
        public void Division_DivideNumbers(int numb1, int numb2, int expected)
        {  
            double actual = Calculator.Division(numb1, numb2);

            Assert.Equal(expected, actual);
        }
       
        [Fact]
        public void Division_ExceptionDivideByZeroGivesZero()
        {
            double actual = Calculator.Division(5, 0);

            Assert.Equal(0, actual);
        }
        [Fact]
        public void Division_InfinityChangesToZero()
        {
            double numb1 = 5;
            double numb2 = 0;

            Assert.False(Double.IsInfinity(Calculator.Division(numb1,numb2)));
        }


        //Multiplication
        [Theory]
        [InlineData(2, 2, 4)]
        [InlineData(-4, 3, -12)]
        [InlineData(3, 5, 15)]
        [InlineData(8, 5, 40)]
        [InlineData(60, 2, 120)]
        [InlineData(100, 4, 400)]
        public void MultiplyNumb1withNumb2(int numb1, int numb2, int expected)
        {

            double actual = Calculator.Multiplication(numb1,numb2);

            Assert.Equal(expected, actual);
        }

        //Subtraction()
        [Theory]
        [InlineData(1, 1, 0)]
        [InlineData((-5), 3, -8)]
        [InlineData(25, 8, 17)]
        [InlineData(8, 5, 3)]
        [InlineData(6000, 500, 5500)]
        [InlineData(100, 4, 96)]
        public void SubstractingNumb1WithNumb2(int numb1, int numb2, int expected)
        {
            
            double actual = Calculator.Subtraction(numb1, numb2);

            Assert.Equal(expected, actual);


        }
        
        [Fact]
        public void SubtractNumberFromDoubleArray()
        {
            double[] testArray = new double[] { 50, 5, 20, 6, 19 };
            double[] testArray2 = new double[] { 44, 13 };
            
            double expected = 50 - 5 - 20 - 6 - 19;
            double expected2 = 44 - 13;

            double actual = Calculator.Subtraction(testArray);
            double actual2 = Calculator.Subtraction(testArray2);

            Assert.Equal(expected, actual);
            Assert.Equal(expected2, actual2);
        }
   
        //ArrayCreation()
        [Fact]
        public void GetLengthOfArrayCreation()
        {
            double[] expected = new double[5];
           
            double[] actual = Calculator.ArrayCreation(5,5);

            Assert.Equal(expected.Length, actual.Length);
        }
        [Fact]
        public void GetRandomRangeOfArrayCreation()
        {
            double[] actual = Calculator.ArrayCreation(10, 100);

            Assert.InRange(actual[0],1,99);
        }
    }
}
