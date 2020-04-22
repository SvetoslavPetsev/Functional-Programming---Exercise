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

            while ((input = Console.ReadLine()) != "Party!")
            {
                string[] info = input.Split();

                string action = info[0];
                string[] predicateArg = info.Skip(1).ToArray();

                Predicate<string> predicate = GetPredicate(predicateArg);

                if (action == "Remove")
                {
                    peoples.RemoveAll(predicate);
                }
                else if (action == "Double")
                {
                    for (int i = 0; i < peoples.Count; i++)
                    {
                        string currPeople = peoples[i];
                        if (predicate(currPeople))
                        {
                            peoples.Insert(i + 1, currPeople);
                            i++;
                        }
                    }
                }
            }
            if (peoples.Count != 0)
            {
                Console.WriteLine($"{ string.Join(", ", peoples)} are going to the party!");
            }
            else
            {
                Console.WriteLine($"Nobody is going to the party!");
            }
        }

        static Predicate<string> GetPredicate(string[] predicateArg)
        {
            string predType = predicateArg[0];
            string predParam = predicateArg[1];

            Predicate<string> predicate = null;

            if (predType == "StartsWith")
            {
                predicate = new Predicate<string>(name =>
               {
                   return name.StartsWith(predParam);
               });
            }
            else if (predType == "EndsWith")
            {
                predicate = new Predicate<string>(name =>
                {
                    return name.EndsWith(predParam);
                });
            }
            else if (predType == "Length")
            {
                predicate = new Predicate<string>(name =>
                {
                    return name.Length == int.Parse(predParam);
                });
            }
            return predicate;
        }
    }
}
