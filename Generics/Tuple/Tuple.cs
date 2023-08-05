using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuple
{
    public class Tuple<TKey, TValue>
    {
        public Tuple()
        {
            DictionaryOfElements = new Dictionary<TKey, TValue>();
        }

        public Dictionary<TKey, TValue> DictionaryOfElements { get; set; }

        public void AddElements(TKey element1, TValue element2)
        {
            DictionaryOfElements.Add(element1, element2);
        }

        public void PrintResult()
        {
            foreach (var item in DictionaryOfElements)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}