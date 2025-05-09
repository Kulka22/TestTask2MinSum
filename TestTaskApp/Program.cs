namespace TestTaskApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }

    public class Summator
    {
        public static double SumTwoMin(double[] inputArray)
        {
            // сортировка прямой вставкой, если кол-во элементов не превышает 16
            // иначе - быстрая сортировка
            // примерно такой способ вроде как используется в встроенных методах сортировки
            if (inputArray == null)
                throw new ArgumentNullException(nameof(inputArray), "Массив null!");
            if (inputArray.Length < 2)
                throw new ArgumentException("В массиве недостаточно элементов!");
            if (inputArray.Length > 16)
                QuickSort(inputArray, 0, inputArray.Length - 1);
            else
                DirectInsertionSort(inputArray);
            return inputArray[0] + inputArray[1];
        }

        private static void DirectInsertionSort(double[] inputArray)
        {
            for (int i = 1; i < inputArray.Length; i++)
            {
                if (inputArray[i - 1] < inputArray[i])
                    continue;
                for (int j = i; j > 0; j--)
                {
                    if (inputArray[j - 1] > inputArray[j])
                        Swap(ref inputArray[j], ref inputArray[j - 1]);
                    else
                        break;
                }
            }
        }

        private static void QuickSort(double[] arr, int left, int right)
        {
            if (left > right)
                return;
            double pivot = arr[(left + right) / 2];
            int i = left;
            int j = right;
            while (i <= j)
            {
                while (arr[i] < pivot)
                    i++;
                while (arr[j] > pivot)
                    j--;
                if (i <= j)
                    Swap(ref arr[i++], ref arr[j--]);
            }
            QuickSort(arr, left, j);
            QuickSort(arr, i, right);
        }

        private static void Swap(ref double a, ref double b)
        {
            double temp = a;
            a = b;
            b = temp;
        }
    }
}
