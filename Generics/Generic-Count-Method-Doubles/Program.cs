namespace GenericCountMethodDoubles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var listOfDoubles = new Box<double>();

            for (int i = 0; i < n; i++)
            {
                listOfDoubles.AddDouble(double.Parse(Console.ReadLine()));
            }

            Console.WriteLine(listOfDoubles.DoubleCount(double.Parse(Console.ReadLine())));
        }
    }
}