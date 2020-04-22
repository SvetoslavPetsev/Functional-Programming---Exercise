using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._Predicate_Party_
{
    class Program
    {
        static void Main()
        {
            List<string> peoples = Console.ReadLine().Split().ToList();
            string input;

            Func<string, string, bool> lengthFilter = (name, length) => name.Length == int.Parse(length);
            Func<string, string, bool> startFilter = (name, start) => name.StartsWith(start);
            Func<string, string, bool> endFilter = (name, end) => name.EndsWith(end);
            Func<string, string, bool> containsFilter = (name, substring) => name.Contains(substring);

            List<string> filterList = new List<string>();

            while ((input = Console.ReadLine()) != "Print")
            {
                string[] info = input.Split(";");
                string action = info[0];
                string filter = $"{info[1]};{info[2]}";
                if (action == "Add filter")
                {
                    filterList.Add(filter);
                }

                else if (action == "Remove filter")
                {
                    filterList.Remove(filter);
                }
            }
            foreach (var filter in filterList)
            {
                string[] filterArgs = filter.Split(";");
                string type = filterArgs[0];
                string param = filterArgs[1];
                if (type == "Length")
                {
                    peoples = peoples.Where(name => !lengthFilter(name, param)).ToList();
                }
                else if (type == "Starts with")
                {
                    peoples = peoples.Where(name => !startFilter(name, param)).ToList();
                }
                else if (type == "Ends with")
                {
                    peoples = peoples.Where(name => !endFilter(name, param)).ToList();
                }
                else if (type == "Contains")
                {
                    peoples = peoples.Where(name => !containsFilter(name, param)).ToList();
                }
            }
            Console.WriteLine(string.Join(" ", peoples));
        }
    }
}
