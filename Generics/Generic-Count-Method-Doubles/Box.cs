using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCountMethodDoubles
{
    public class Box<T>
        where T : IComparable
    {
        public Box()
        {
            List = new List<T>();
        }

        public List<T> List { get; set; }

        public void AddDouble(T number)
        {
            List.Add(number);
        }

        public int DoubleCount(double num)
        {
            int count = 0;

            foreach (var number in List)
            {
                if (number.CompareTo(num) > 0)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
