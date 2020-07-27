using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookNew
{
    public class Sort : IComparer<Person>
    {
        public int Compare(Person person1, Person person2)
        {
            return person1.firstName.CompareTo(person2.firstName);
        }
    }

    public class Sortbycity : IComparer<Person>
    {
        public int Compare(Person person1, Person person2)
        {
            return person1.city.CompareTo(person2.city);
        }
    }

    public class Sortbystate : IComparer<Person>
    {
        public int Compare(Person person1, Person person2)
        {
            return person1.state.CompareTo(person2.state);
        }
    }

    public class Sortbyzip : IComparer<Person>
    {
        public int Compare(Person person1, Person person2)
        {
            return person1.zip.CompareTo(person2.zip);
        }
    }


}
