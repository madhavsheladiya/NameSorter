using System;
using System.Collections.Generic;
using System.Text;

namespace NameSorter
{
    public class NameComparer : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            int lastNameComparison = x.LastName.CompareTo(y.LastName);

            if (lastNameComparison == 0)
            {
                return CompareGivenNames(x.GivenNames, y.GivenNames);
            }

            return lastNameComparison;
        }

        private int CompareGivenNames(string[] x, string[] y)
        {
            // Start comparing from the last given name to the first
            int xi = x.Length - 1;
            int yi = y.Length - 1;

            while (xi >= 0 && yi >= 0)
            {
                int comparison = x[xi].CompareTo(y[yi]);

                if (comparison != 0)
                {
                    return comparison;
                }

                xi--;
                yi--;
            }

            // If we've exhausted one of the lists but not the other, the exhausted list should come first
            if (xi < 0 && yi >= 0)
            {
                return -1;
            }
            else if (yi < 0 && xi >= 0)
            {
                return 1;
            }

            // If we've exhausted both lists, they're effectively equal
            return 0;
        }
    }
}
