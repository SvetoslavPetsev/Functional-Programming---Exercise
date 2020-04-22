using System;
using System.Collections.Generic;
using System.Linq;


namespace _08._Custom_Comparator
{
    class Program
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Predicate<int> even = x => x % 2 == 0;

            List<int> evenList = new List<int>();
            List<int> oddList = new List<int>();
            List<int> fullList = new List<int>();

            foreach (var number in numbers)
            {
                if (even(number))
                {
                    evenList.Add(number);
                }
                else
                {
                    oddList.Add(number);
                }
            }

            Func<List<int>, List<int>> intSortAccending = forSort =>
            {
                List<int> sorted = new List<int>();
                while (forSort.Any())
                {
                    int minNumber = int.MaxValue;
                    int minNumberIndex = 0;
                    for (int i = 0; i < forSort.Count; i++)
                    {
                        if (forSort[i] < minNumber)
                        {
                            minNumber = forSort[i];
                            minNumberIndex = i;
                        }
                    }
                    forSort.RemoveAt(minNumberIndex);
                    sorted.Add(minNumber);
                }

                return sorted;
            };

            evenList = intSortAccending(evenList).ToList();
            oddList = intSortAccending(oddList).ToList();
            fullList.AddRange(evenList);
            fullList.AddRange(oddList);
            Console.WriteLine(string.Join(" ", fullList));
        }
    }
}
