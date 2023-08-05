namespace GenericSwapMethodIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var listOfIntegers = new SwapListOfIntegers<string>();

            for (int i = 0; i < n; i++)
            {
                listOfIntegers.AddElement(Console.ReadLine());
            }
            var token = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int firstIndex = token[0];
            int secondIndex = token[1];

            listOfIntegers.Swap(firstIndex, secondIndex);
        }
    }
}