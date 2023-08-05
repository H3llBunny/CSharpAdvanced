using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxOfStrings
{
    public class Box<T>
    {
        public Box(T type)
        {
            Type = type;
        }

        public T Type { get; set; }

        public override string ToString()
        {
            return $"{Type.GetType().FullName}: {Type}";
        }
    }
}
