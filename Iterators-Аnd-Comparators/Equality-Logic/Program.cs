namespace EqualityLogic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sortedSet = new SortedSet<Person>();
            var hashSet = new HashSet<Person>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var command = Console.ReadLine().Split();
                string name = command[0];
                int age = int.Parse(command[1]);
                sortedSet.Add(new Person(name, age));
                hashSet.Add(new Person(name, age));
            }

            Console.WriteLine(sortedSet.Count);
            Console.WriteLine(hashSet.Count);
        }
    }
}