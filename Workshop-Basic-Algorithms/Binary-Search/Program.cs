namespace BinarySearch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 };
            int key = 12;
            int index = BinarySearch(arr, key, 0, arr.Length - 1);

            if (index != -1)
            {
                Console.WriteLine("Key found at index: " + index);
            }
            else
            {
                Console.WriteLine("Key not found.");
            }

            int BinarySearch(int[] arr, int key, int start, int end)
            {

                const int KEY_NOT_FOUND = -1; // Define KEY_NOT_FOUND constant

                while (end >= start)
                {
                    int mid = (start + end) / 2;

                    if (arr[mid] < key)
                    {
                        start = mid + 1;
                    }
                    else if (arr[mid] > key)
                    {
                        end = mid - 1;
                    }
                    else
                    {
                        return mid;
                    }
                }
                return KEY_NOT_FOUND;
            }
        }
    }
}