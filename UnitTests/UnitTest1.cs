using Calculations;

namespace UnitTests
{
    public class UnitTest1
    {

        [Fact]
        public void SumTwoMin_null_throwsNullReferenceException()
        {
            int[] numbers = null;

            var exception = Assert.Throws<NullReferenceException>
                (() => Calculator.SumTwoMin(numbers));

            Assert.Equal("Массив null!", exception.Message);
        }

        [Fact]
        public void SumTwoMin_notEnoughElements_throwsArgumentException()
        {
            int[] numbers = { 7 };

            var exception = Assert.Throws<IndexOutOfRangeException>
                (() => Calculator.SumTwoMin(numbers));

            Assert.Equal("В массиве должно быть минимум 2 элемента!", exception.Message);
        }

        [Fact]
        public void SumTwoMin_emptyArray_throwsArgumentException()
        {
            int[] numbers = Array.Empty<int>();

            var exception = Assert.Throws<ArgumentException>
                (() => Calculator.SumTwoMin(numbers));

            Assert.Equal("Массив пуст! (Parameter 'inputArray')", exception.Message);
        }

        [Fact]
        public void SumTwoMin_overflowMaxArguments_throwsOverflowException()
        {
            int[] numbers = {int.MaxValue, int.MaxValue};

            var exception = Assert.Throws<OverflowException>
                (() => Calculator.SumTwoMin(numbers));

            Assert.Equal("Произошло переполнение!", exception.Message);
        }

        [Fact]
        public void SumTwoMin_overflowMinArguments_throwsOverflowException()
        {
            int[] numbers = { int.MinValue, int.MinValue };

            var exception = Assert.Throws<OverflowException>
                (() => Calculator.SumTwoMin(numbers));

            Assert.Equal("Произошло переполнение!", exception.Message);
        }

        [Fact]
        public void SumTwoMin_normalCase1_expectedResult()
        {
            int[] numbers = { 5, 4, -1, -2, -3 };

            int result = Calculator.SumTwoMin(numbers);

            Assert.Equal(-5, result);
        }

        [Fact]
        public void SumTwoMin_normalCase2_expectedResult()
        {
            int[] numbers = { 8, 7, 6, 5, 4, 3, 2, 1, 0, -1, -2, -3, -4, -5, -6, -7, -8 };

            int result = Calculator.SumTwoMin(numbers);

            Assert.Equal(-15, result);
        }

        [Fact]
        public void SumTwoMin_normalCase3_expectedResult()
        {
            int[] numbers = { 0, 4, -3, 2, 35, 14 };

            int result = Calculator.SumTwoMin(numbers);

            Assert.Equal(-3, result);
        }

        [Fact]
        public void SumTwoMin_normalCase4_expectedResult()
        {
            int[] numbers = { 1, 1, 1, 1, 1, 1, 1 };

            int result = Calculator.SumTwoMin(numbers);

            Assert.Equal(2, result);
        }
    }
}