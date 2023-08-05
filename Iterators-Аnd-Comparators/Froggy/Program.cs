namespace Froggy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();

            var stones = new Lake(numbers);

            Console.WriteLine(string.Join(", ", stones));
        }
    }
}