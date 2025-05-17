using Calculations;

namespace TestTaskApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] arr = { int.MaxValue, int.MaxValue };
            //int[] arr = null;
            int[] arr = { int.MinValue };
            //int[] arr = { 2, 3, -9, 7, 19};
            //int[] arr = Array.Empty<int>();
            Console.WriteLine(Calculator.SumTwoMin(arr));
            Console.WriteLine();
        }
    }
}
