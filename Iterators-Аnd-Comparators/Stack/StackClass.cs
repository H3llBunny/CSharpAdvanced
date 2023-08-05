using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomStack
{
    public class StackClass<T> : IEnumerable<T>
    {
        private Stack<T> elemenets;

        public StackClass(T[] elements)
        {
            this.elemenets = new Stack<T>(elements);
        }

        public void Push(T[] numbers)
        {
            foreach (var num in numbers)
            {
                elemenets.Push(num);
            }
        }

        public T Pop()
        {
            if (elemenets.Count == 0)
            {
                throw new ArgumentException("No elements");
            }
            else
            {
                return elemenets.Pop();
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in elemenets)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
