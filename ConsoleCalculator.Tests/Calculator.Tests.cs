namespace ConsoleCalculator.Tests
{
    public class CalculatorTests
    {

        public const string multiplyOperation = "m";
        public const string addingOperation = "a";
        public const string subtractionOperation = "s";
        public const string divideOperation = "d";



        [Fact]
        public void DoOperationMultiplyTest()
        {
            double a = 10;
            double b = 20;
            double expectedResult = 200;

            double actualResult = Calculator.DoOperation(a, b, multiplyOperation);

            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void DoOperationAddTest()
        {
            double a = -5;
            double b = 7;
            double expectedResult = 2;

            double actualResult = Calculator.DoOperation(a, b, addingOperation);

            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void DoOperationSubtractTest()
        {
            double a = 1000;
            double b = 7;
            double expectedResult = 993;

            double actualResult = Calculator.DoOperation(a, b, subtractionOperation);

            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void DoOperationDivideTest()
        {
            double a = 1000;
            double b = 10;
            double expectedResult = 100;

            double actualResult = Calculator.DoOperation(a, b, divideOperation);

            Assert.Equal(expectedResult, actualResult);
        }

       
    }
}