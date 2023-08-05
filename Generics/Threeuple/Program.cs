namespace Threeuples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();
            string name = input[0] + " " + input[1];
            string address = input[2];
            string town = input[3];
            var firstInput = new Threeuple<string, string, string>();
            firstInput.AddElements(name, address, town);

            var input2 = Console.ReadLine().Split();
            string firstName = input2[0];
            int litersOfBeer = int.Parse(input2[1]);
            string drunkOrNot = input2[2];
            var secondtInput = new Threeuple<string, int, string>();
            secondtInput.AddElements(firstName, litersOfBeer, drunkOrNot);

            var input3 = Console.ReadLine().Split();
            string theFirstName = input3[0];
            double bankBalance = double.Parse(input3[1]);
            string bankName = input3[2];
            var thirdInput = new Threeuple<string, double, string>();
            thirdInput.AddElements(theFirstName, bankBalance, bankName);

            firstInput.PrintElements();
            secondtInput.PrintSecondInput();
            thirdInput.PrintElements();

        }
    }
}