using System;

namespace _01._Action_Print
{
    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split();

            Action<string[]> print = name => Console.WriteLine(string.Join(Environment.NewLine, name));
            
            print(input);

        }
    }
}
