using Microsoft.VisualStudio.TestPlatform.TestHost;
using Program;
using System.Text;
using System.Text.RegularExpressions;

namespace ConsoleCalculator.Tests
{
    public class CalculatorTests
    {

        public const string multiplyOperation = "m";
        public const string addingOperation = "a";
        public const string subtractionOperation = "s";
        public const string divideOperation = "d";



        [Fact]
        public void ShouldMultiplyTest()
        {
            double a = 10;
            double b = 20;
            double expectedResult = 200;

            double actualResult = Calculator.DoOperation(a, b, multiplyOperation);

            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void ShoiuldAddTest()
        {
            double a = -5;
            double b = 7;
            double expectedResult = 2;

            double actualResult = Calculator.DoOperation(a, b, addingOperation);

            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void ShouldSubtractTest()
        {
            double a = 1000;
            double b = 7;
            double expectedResult = 993;

            double actualResult = Calculator.DoOperation(a, b, subtractionOperation);

            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void ShouldDoDivideTest()
        {
            double a = 1000;
            double b = 10;
            double expectedResult = 100;

            double actualResult = Calculator.DoOperation(a, b, divideOperation);

            Assert.Equal(expectedResult, actualResult);
        }
        [Fact]
        public void ShouldDivideTest_WhenAddedEmpltyCommand()
        {
            double a = 100;
            double b = 223;
            var expectedResult = double.NaN;
            double actualResult = Calculator.DoOperation(a, b, null);

            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void ShouldReturnResultOfAdding()
        {
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            var stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("4");
            stringBuilder.AppendLine("5");
            stringBuilder.AppendLine("m");
            stringBuilder.AppendLine("n");
            var stringReader = new StringReader(stringBuilder.ToString());
            Console.SetIn(stringReader);



            MainProgram.Main(new string[0]);
            var expectedResult = "Console Calculator in C#" +
                                 "------------------------" +
                                 "Type a number, and then press Enter: " +
                                 "Type another number, and then press Enter: " +
                                 "Choose an operator from the following list:" +
                                 "a - Add" +
                                 "s - Subtract" +
                                 "m - Multiply" +
                                 "d - Divide" +
                                 "Your option? " +
                                 "Your result: 20" +
                                 "------------------------" +
                                 "Press 'n' and Enter to close the app, or press any other key and Enter to continue: ";

            Assert.Equal(expectedResult, Regex.Replace(stringWriter.ToString(), @"[\r\t\n]+", string.Empty));

        }
    }
}