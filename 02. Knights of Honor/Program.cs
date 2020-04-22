using System;

namespace _02._Knights_of_Honor
{
    class Program
    {
        static void Main()
        {
            string[] names = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);

            Action<string[]> Print = name => Console.WriteLine("Sir " + string.Join(Environment.NewLine + "Sir ", name));

            Print(names);
        }
    }
}
