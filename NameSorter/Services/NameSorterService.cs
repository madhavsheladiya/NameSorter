using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace NameSorter
{
    public class NameSorterService : INameSorterService
    {
        public List<Person> SortNames(List<Person> names)
        {
            names.Sort(new NameComparer());
            return names;
        }

        internal ICollection SortNames(List<string> unsortedNames)
        {
            throw new NotImplementedException();
        }
    }
}   
