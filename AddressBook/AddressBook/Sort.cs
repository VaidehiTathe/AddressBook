using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookNew
{
    public class Sort : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            return x.firstName.CompareTo(y.firstName);
        }
    }
}
