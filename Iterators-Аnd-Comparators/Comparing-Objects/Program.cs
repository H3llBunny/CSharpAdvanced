namespace ComparingObjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command;
            var listOfPeople = new List<Person>();

            while ((command = Console.ReadLine()) != "END")
            {
                var token = command.Split();
                string name = token[0];
                int age = int.Parse(token[1]);
                string town = token[2];

                listOfPeople.Add(new Person(name, age, town));
            }

            int index = int.Parse(Console.ReadLine());

            Person selectedPerson = listOfPeople[index - 1];
            int peopleMatchCount = 0;
            int peopleNoMatchCount = 0;

            foreach (var person in listOfPeople)
            {
                if (selectedPerson.CompareTo(person) == 0)
                {
                    peopleMatchCount++;
                }
                else
                {
                    peopleNoMatchCount++;
                }
            }

            if (peopleMatchCount > 1)
            {
                Console.WriteLine($"{peopleMatchCount} {peopleNoMatchCount} {listOfPeople.Count}");
            }
            else
            {
                Console.WriteLine("No matches");
            }
        }
    }
}