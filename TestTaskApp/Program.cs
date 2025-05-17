using Calculations;

namespace TestTaskApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfElements;
            Console.Write("Введите кол-во элементов массива: ");
            countOfElements = int.Parse(Console.ReadLine());

            int[] numbers = new int[countOfElements];

            for (int i = 0; i < countOfElements; i++)
            {
                Console.Write($"Введите {i + 1}-й элемент: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"Сумма двух минимальных элементов массива равна: " +
                $"{Calculator.SumTwoMin(numbers)}");
        }
    }
}
