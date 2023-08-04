using System;

namespace Date_Modifier
{
     class Program
    {
        static void Main(string[] args)
        {
            string firstDate = Console.ReadLine();
            string secondDate = Console.ReadLine();

            DateModifier dateModifier = new DateModifier();

            int difference = dateModifier.CalculateDateDifferences(firstDate, secondDate);

            Console.WriteLine(difference);
        }
    }
}