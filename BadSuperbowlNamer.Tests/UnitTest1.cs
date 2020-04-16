using System;
using Xunit;

namespace BadSuperbowlNamer.Tests
{
    public class int_to_roman_numerals
    {
        [Fact]
        public void translating_1_results_in_I ()
        {
            //Arrange
            var number = 1;
            var expectedResult = "I";
            var translator = new Translator();
            //Act
            var actualResult = translator.Translate(number);
            //Assert
            Assert.Equal(expectedResult, actualResult);
        }
        [Fact]
        public void translatting_5_results_in_V()
        {
            //Arrange
            var number = 5;
            var expectedResult = "V";
            var translator = new Translator();
            //Act
            var actualResult = translator.Translate(number);
            //Assert
            Assert.Equal(expectedResult, actualResult);
        }
        [Fact]
        public void translatting_9_results_in_IX()
        {
            //Arrange
            var number = 9;
            var expectedResult = "IX";
            var translator = new Translator();
            //Act
            var actualResult = translator.Translate(number);
            //Assert
            Assert.Equal(expectedResult, actualResult);
        }
        [Fact]
        public void translatting_12_results_in_XII()
        {
            //Arrange
            var number = 12;
            var expectedResult = "XII";
            var translator = new Translator();
            //Act
            var actualResult = translator.Translate(number);
            //Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void translatting_14_results_in_XIV()
        {
            //Arrange
            var number = 14;
            var expectedResult = "XIV";
            var translator = new Translator();
            //Act
            var actualResult = translator.Translate(number);
            //Assert
            Assert.Equal(expectedResult, actualResult);
        }
        [Fact]
        public void translatting_29_results_in_XXIX()
        {
            //Arrange
            var number = 29;
            var expectedResult = "XXIX";
            var translator = new Translator();
            //Act
            var actualResult = translator.Translate(number);
            //Assert
            Assert.Equal(expectedResult, actualResult);
        }
        [Fact]
        public void translatting_44_results_in_XLIV()
        {
            //Arrange
            var number = 44;
            var expectedResult = "XLIV";
            var translator = new Translator();
            //Act
            var actualResult = translator.Translate(number);
            //Assert
            Assert.Equal(expectedResult, actualResult);
        }
    }
}
