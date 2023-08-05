namespace Tuple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dictionaryOfStrings = new Tuple<string, string>();
            var input = Console.ReadLine().Split();
            string name = input[0] + " " + input[1];
            string address = input[2];
            dictionaryOfStrings.AddElements(name, address);

            var dictionaryOfStringAndInt = new Tuple<string, int>();
            var input2 = Console.ReadLine().Split();
            string firstName = input2[0];
            int beers = int.Parse(input2[1]);
            dictionaryOfStringAndInt.AddElements(firstName, beers);

            var dictionaryOfIntandDouble = new Tuple<int, double>();
            var input3 = Console.ReadLine().Split();
            int numberInt = int.Parse(input3[0]);
            double numberDouble = double.Parse(input3[1]);
            dictionaryOfIntandDouble.AddElements(numberInt, numberDouble);

            dictionaryOfStrings.PrintResult();
            dictionaryOfStringAndInt.PrintResult();
            dictionaryOfIntandDouble.PrintResult();
        }
    }
}