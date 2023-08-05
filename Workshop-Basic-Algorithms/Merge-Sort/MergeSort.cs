using System;

namespace MergeSort
{
    public class MergeSort<T> where T : IComparable<T>
    {
        private static T[] aux;

        public static void Sort(T[] arr)
        {
            aux = new T[arr.Length];
            Sort(arr, 0, arr.Length - 1);
        }

        private static void Sort(T[] arr, int lo, int hi)
        {
            if (lo >= hi)
            {
                return;
            }
            else
            {
                int mid = lo + (hi - lo) / 2;
                Sort(arr, lo, mid);
                Sort(arr, mid + 1, hi);
                Merge(arr, lo, mid, hi);
            }
        }

        private static void Merge(T[] arr, int lo, int mid, int hi)
        {
            for (int index = lo; index <= hi; index++)
            {
                aux[index] = arr[index];
            }

            int i = lo;
            int j = mid + 1;

            for (int k = lo; k <= hi; k++)
            {
                if (i > mid)
                {
                    arr[k] = aux[j++];
                }
                else if (j > hi)
                {
                    arr[k] = aux[i++];
                }
                else if (IsLess(aux[j], aux[i]))
                {
                    arr[k] = aux[j++];
                }
                else
                {
                    arr[k] = aux[i++];
                }
            }
        }

        private static bool IsLess(T item1, T item2)
        {
            return item1.CompareTo(item2) < 0;
        }
    }
}