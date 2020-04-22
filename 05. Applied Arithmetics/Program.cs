using System;
using System.Linq;

namespace _05._Applied_Arithmetics
{
    class Program
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int .Parse)
                .ToArray();

            Action<int[]> print = numbers => Console.WriteLine(string.Join(" ", numbers));
            
            string command;
            while ((command = Console.ReadLine())!= "end")
            {
                if (command == "add")
                {
                    numbers = Modify(numbers, Add);
                }
                else if (command == "subtract")
                {
                    numbers = Modify(numbers, Subtract);
                }
                else if (command == "multiply")
                {
                    numbers = Modify(numbers, Multiply);
                }
                else if (command == "print")
                {
                    print(numbers);
                }
            }
        }
        public static int[] Modify(int[] numbers, Func<int[], int[]> mod)
        {
            return mod(numbers);
        }
        public static int[] Add(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i]++;
            }
            return numbers;
        }
        public static int[] Subtract(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i]--;
            }
            return numbers;
        }
        public static int[] Multiply(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] *= 2;
            }
            return numbers;
        }
    }
}
