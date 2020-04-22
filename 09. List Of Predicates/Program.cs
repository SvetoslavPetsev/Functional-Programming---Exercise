using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._List_Of_Predicates
{
    class Program
    {
        static void Main()
        {
            int endNumber = int.Parse(Console.ReadLine());
            int[] dividers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            List<Predicate<int>> predicateList = new List<Predicate<int>>();

            foreach (var number in dividers)
            {
                Predicate<int> predicate = x => x % number == 0;
                predicateList.Add(predicate);
            }

            List<int> result = new List<int>();

            for (int i = 1; i <= endNumber; i++)
            {
                bool isValid = true;
                int currNumber = i;
                foreach (var predicate in predicateList)
                {
                    if (!predicate(currNumber))
                    {
                        isValid = false;
                        break;
                    }
                }
                if (isValid)
                {
                    result.Add(currNumber);
                }
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
