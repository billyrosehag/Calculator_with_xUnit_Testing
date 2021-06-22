using System;
using Xunit;
using Test_Cal;

namespace Test_Cal.Tests
{
    public class FormatingShould
    {
      [Fact]
      public void ReturnSeperatedString()
        {
            Formating sut = new Formating();

            string[] expected = new string[] {"Hello", "You", "Two"};

            string[] actual = sut.StringSeperator("Hello You Two");

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ReturnFalseWhenNutNumbersOrOperators()
        {
            Formating sut = new Formating();

            string[] actual = new string[] { "Is", "Not", "Number" };

            Assert.False(sut.CheckInput(actual));
        }
        [Fact]
        public void ReturnFalseWhenNuStringArrayNot3Long()
        {
            Formating sut = new Formating();

            string[] actual = new string[] { "1", "*", "4", "4" };

            Assert.False(sut.CheckInput(actual));
        }
        [Fact]
        public void ReturnTrueWhenNuStringArrayIsNumberOptNumber()
        {
            Formating sut = new Formating();

            string[] actual = new string[] { "1", "*", "4"};

            Assert.True(sut.CheckInput(actual));
        }




    }
}
