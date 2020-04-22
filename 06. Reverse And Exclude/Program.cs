using System;
using System.Linq;

namespace _06._Reverse_And_Exclude
{
    class Program
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int n = int.Parse(Console.ReadLine());
            Func<int[], int[]> Reverse = x =>
            {
                int[] y = new int[x.Length];
                for (int i = 0; i < x.Length; i++)
                {
                    y[i] = x[x.Length - 1 - i];
                }
                return y;
            };

            numbers = Reverse(numbers).Where(x => x % n != 0).ToArray();
            Action<int[]> print = x => Console.WriteLine(string.Join(" ", x));
            print(numbers);
        }
    }
}
