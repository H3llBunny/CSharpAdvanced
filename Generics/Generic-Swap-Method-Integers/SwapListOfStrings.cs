using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericSwapMethodIntegers
{
    public class SwapListOfIntegers<T>
    {
        public SwapListOfIntegers()
        {
            List = new List<T>();
        }

        public List<T> List { get; set; }

        public void AddElement(T element)
        {
            List.Add(element);
        }

        public void Swap(int firstIndex, int secondIndex)
        {
            var firstElement = List[secondIndex];
            List[secondIndex] = List[firstIndex];
            List[firstIndex] = firstElement;

            foreach (var str in List)
            {
                Console.WriteLine($"{str.GetType().FullName}: {str}");
            }
        }
    }
}
