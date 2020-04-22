using System;
using System.Linq;

namespace _12._TriFunction
{
    class Program
    {
        static void Main()
        {
            int topAscii = int.Parse(Console.ReadLine());
            string[] names = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Func<string, int, bool> isValid = (name, targetNumber) =>
            name.Sum(x => x) >= targetNumber;

            Func<string[], Func<string, int, bool>, string> findNumber = (names, firstValid) =>
            names.FirstOrDefault(x => firstValid(x, topAscii));

            Console.WriteLine(findNumber(names, isValid));
        }
    }
}
