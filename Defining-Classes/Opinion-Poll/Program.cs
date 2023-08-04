using System;
using System.Collections.Generic;
using System.Linq;

namespace OpinionPoll
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            var listOfPeople = new List<Person>();

            for (int i = 0; i < N; i++)
            {
                string[] input = Console.ReadLine().Split();
                string name = input[0];
                int age = int.Parse(input[1]);
                listOfPeople.Add(new Person(name, age));
            }

            var sortedListOfPeople = listOfPeople.Where(p => p.Age > 30).OrderBy(p => p.Name);

            foreach (var person in sortedListOfPeople)
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }
        }
    }
}