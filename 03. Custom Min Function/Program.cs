using System;
using System.Linq;

namespace _03._Custom_Min_Function
{
    class Program
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Func<int[], int> getMin = numbers =>
            {
                int min = int.MaxValue;
                foreach (var num in numbers)
                {
                    if (num < min)
                    {
                        min = num;
                    }
                }
                return min;
            };

            Console.WriteLine(getMin(numbers));
        }
    }
}
