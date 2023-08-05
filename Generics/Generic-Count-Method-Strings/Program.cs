using GenericCountMethodStrings;

namespace GenericCountMethodStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var list = new Box<string>();

            for (int i = 0; i < n; i++)
            {
                list.AddString(Console.ReadLine());
            }

            Console.WriteLine(list.CompareCount(Console.ReadLine()));
        }
    }
}