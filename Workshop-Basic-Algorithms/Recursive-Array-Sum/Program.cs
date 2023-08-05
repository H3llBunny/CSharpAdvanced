namespace RecursiveArraySum
{
    internal class Program
    {
        static int ArraySum(int[] arr, int index)
        {

            if(index == arr.Length - 1)
            {
                return arr[index];
            }
            else
            {
                return arr[index] + ArraySum(arr, index + 1);
            }
        }

        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int index = int.Parse(Console.ReadLine());
            Console.WriteLine(ArraySum(numbers, index));
        }
    }
}