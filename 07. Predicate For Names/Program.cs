using System;
using System.Linq;

namespace _07._Predicate_For_Names
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            string[] names = Console.ReadLine().Split();
            
            Predicate<string> smallOrEqual = x => x.Length <= number;

            foreach (var name in names)
            {
                if (smallOrEqual(name))
                {
                    Console.WriteLine(name);
                }
            }
        }
    }
}
