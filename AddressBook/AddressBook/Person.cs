using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook
{
    public class Person 
    {
        private string firstName, lastName, address, city, state;
        private int zip, phoneNumber;
         public string FirstName
         {
            get { return firstName; }
            set { firstName = value; }
         }
         public string LastName
         {
             get { return lastName; }
             set { lastName = value; }
         }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public string City
        {
            get { return city; }
            set { city = value; }
        }

        public string State
        {
            get { return state; }
            set { state = value; }
        }
        public int Zip
        {
            get { return zip; }
            set { zip = value; }
        }
        public int PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

    }
}
