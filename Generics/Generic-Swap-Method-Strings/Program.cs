namespace GenericSwapMethodStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var listOfStrings = new SwapListOfStrings<string>();

            for (int i = 0; i < n; i++)
            {
                listOfStrings.AddElement(Console.ReadLine());
            }
            var token = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int firstIndex = token[0];
            int secondIndex = token[1];

            listOfStrings.Swap(firstIndex, secondIndex);
        }
    }
}