using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCountMethodStrings
{
    internal class Box<T>
        where T : IComparable<T>
    {
        public List<T> List { get; set; }

        public Box()
        {
            List = new List<T>();
        }

        public void AddString(T element)
        {
            List.Add(element);
        }

        public int CompareCount(T element)
        {
            var count = 0;

            foreach (var item in List)
            {
                if (item.CompareTo(element) > 0)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
