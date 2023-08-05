using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualityLogic
{
    public class Person : IComparable<Person>
    {
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name { get; set; }
        public int Age { get; set; }

        public int CompareTo(Person? other)
        {
            int nameComparison = string.Compare(Name, other.Name, StringComparison.Ordinal);

            if (nameComparison != 0)
                return nameComparison;

            return Age.CompareTo(other.Age);
        }

        public override bool Equals(object? obj)
        {
            if (ReferenceEquals(this, obj))
                return true;

            if (obj is null || GetType() != obj.GetType())
                return false;

            var other = (Person)obj;
            return Name.Equals(other.Name) && Age.Equals(other.Age);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + (Name?.GetHashCode() ?? 0);
                hash = hash * 23 + Age.GetHashCode();
                return hash;
            }
        }
    }
}
