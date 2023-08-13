using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NameSorter
{
    public class Person
    {
        public string FullName { get; private set; }
        public string LastName { get; private set; }
        public string[] GivenNames { get; private set; }

        public Person(string name)
        {
            FullName = name;
            var nameParts = name.Split(' ');
            LastName = nameParts[^1];
            GivenNames = nameParts.Take(nameParts.Length - 1).ToArray();
        }
        public override bool Equals(object obj)
        {
            if (obj is Person other)
            {
                return FullName == other.FullName;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return FullName.GetHashCode();
        }
    }
}


