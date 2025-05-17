namespace Calculations
{
    public class Calculator
    {
        public static int SumTwoMin(int[] inputArray)
        {
            try
            {
                if (inputArray.Length == 0)
                    throw new ArgumentException("Массив пуст!", nameof(inputArray));

                int minFirst, minSecond;

                FindTwoMinElements(inputArray, out minFirst, out minSecond);

                return checked(minFirst + minSecond);
                // Если бы был тип double,
                // то можно было бы использовать double.IsInfinity()
            }
            catch (NullReferenceException)
            {
                throw new NullReferenceException("Массив null!");
            }
            catch (IndexOutOfRangeException)
            {
                throw new IndexOutOfRangeException("В массиве должно быть минимум 2 элемента!");
            }
            catch (OverflowException)
            {
                throw new OverflowException("Произошло переполнение!");
            }
            
        }

        private static void FindTwoMinElements(int[] inputArray, 
            out int minFirst, out int minSecond)
        {
            if (inputArray.Length < 2)
                throw new IndexOutOfRangeException();
            minFirst = int.MaxValue;
            minSecond = int.MaxValue;
            foreach (int item in inputArray)
            {
                if (item < minFirst)
                {
                    minSecond = minFirst;
                    minFirst = item;
                }
                else if (item < minSecond)
                {
                    minSecond = item;
                }
            }
        }
    }
}