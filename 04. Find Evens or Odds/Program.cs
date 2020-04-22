using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Find_Evens_or_Odds
{
    class Program
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            string type = Console.ReadLine();

            int min = numbers[0];
            int max = numbers[1];
            List<int> middlePart = new List<int>();

            for (int i = min; i <= max; i++)
            {
                middlePart.Add(i);
            }

            Predicate<int> isOdd = number => number % 2 != 0;
            Predicate<int> isEven = number => number % 2 == 0;

            if (type == "odd")
            {
                middlePart = middlePart.Where(x => isOdd(x)).ToList();
            }
            else if (type == "even")
            {
                middlePart = middlePart.Where(x => isEven(x)).ToList();
            }
            Action<List<int>> print = x => Console.WriteLine(string.Join(" ", middlePart));
            print(middlePart);
        }
    }
}
