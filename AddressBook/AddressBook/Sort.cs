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

    public class Sortbycity : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            return x.city.CompareTo(y.city);
        }
    }

    public class Sortbystate : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            return x.state.CompareTo(y.state);
        }
    }

    public class Sortbyzip : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            return x.zip.CompareTo(y.zip);
        }
    }


}
