namespace RecursiveFactorial
{
    internal class Program
    {

        static long Factorial(int num)
        {
            if (num == 0)
            {
                return 1;
            }

            return num * Factorial(num - 1);
        }

        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine(Factorial(num));
        }
    }
}