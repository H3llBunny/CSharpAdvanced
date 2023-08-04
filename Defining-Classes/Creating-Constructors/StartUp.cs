using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var peopleList = new List<Person>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                var person = new Person(input[0], int.Parse(input[1]));
                peopleList.Add(person);
            }

            var sortedList = peopleList.Where(p => p.Age > 30).OrderBy(p => p.Name);

            foreach (var person in sortedList)
            {
                Console.WriteLine(person.Name + " - " + person.Age);
            }
        }
    }
}