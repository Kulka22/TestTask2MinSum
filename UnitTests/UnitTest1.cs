using TestTaskApp;

namespace UnitTests
{
    public class UnitTest1
    {

        [Fact]
        public void TestNull()
        {
            double[] numbers = null;
            var exception = Assert.Throws<ArgumentNullException>
                (() => Summator.SumTwoMin(numbers));
            Assert.Equal("Массив null! (Parameter 'inputArray')", exception.Message);
        }

        [Fact]
        public void TestNotEnoughElements()
        {
            double[] numbers = new double[1] { 7 };
            var exception = Assert.Throws<ArgumentException>
                (() => Summator.SumTwoMin(numbers));
            Assert.Equal("В массиве недостаточно элементов!", exception.Message);
        }

        [Theory]
        [InlineData(new double[] {5, 4, -1, -2, -3}, -5)]
        [InlineData(new double[] {8, 7, 6, 5, 4, 3, 2, 1, 0, -1, -2, -3, -4, -5, -6, -7, -8}, -15)]
        [InlineData(new double[] { 0, 4, -3, 2, 35, 14 }, -3)]
        [InlineData(new double[] { 0, 0, 0, 0, 0, -4, 0, 11, 0 }, -4)]
        [InlineData(new double[] { 1, 1, 1, 1, 1, 1, 1 }, 2)]
        public void TestNormalCase(double[] number, double expected)
        {
            double result = Summator.SumTwoMin(number);
            Assert.Equal(expected, result);
        }
    }
}