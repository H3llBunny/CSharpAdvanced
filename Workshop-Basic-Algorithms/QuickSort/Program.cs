namespace QuickSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            QuickSort.Sort(numbers);

            Console.WriteLine(string.Join(' ', numbers));
        }
    }
}