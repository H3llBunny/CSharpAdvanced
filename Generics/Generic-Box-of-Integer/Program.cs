namespace GenericBoxOfInteger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var element = new Box<int>(int.Parse(Console.ReadLine()));
                Console.WriteLine(element.ToString());
            }
        }
    }
}