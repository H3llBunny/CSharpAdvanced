using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Threeuples
{
    public class Threeuple<T, T2, T3>
    {
        public Threeuple()
        {
            Tuple = new Tuple<T, T2, T3>(default(T), default(T2), default(T3));
        }

        public Tuple<T, T2, T3> Tuple { get; set; }

        public void AddElements(T element, T2 element2, T3 element3)
        {
            Tuple = new Tuple<T, T2, T3>(element, element2, element3);
        }

        public void PrintElements()
        {
            Console.WriteLine($"{Tuple.Item1.ToString()} -> {Tuple.Item2.ToString()} -> {Tuple.Item3.ToString()}");
        }

        public void PrintSecondInput()
        {
            if (Tuple.Item3.ToString() == "drunk")
            {
                Console.WriteLine($"{Tuple.Item1.ToString()} -> {Tuple.Item2.ToString()} -> True");
            }
            else
            {
                Console.WriteLine($"{Tuple.Item1.ToString()} -> {Tuple.Item2.ToString()} -> False");
            }
        }
    }
}