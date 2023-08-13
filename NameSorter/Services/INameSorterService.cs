using System;
using System.Collections.Generic;
using System.Text;

namespace NameSorter
{
    public interface INameSorterService
    {
        List<Person> SortNames(List<Person> names);
    }
}
