using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook
{
    public class Person 
    {
        private string firstName, lastName, address, city, state;
        private int zip, phoneNumber;
         public string getFirstName
         {
            get { return firstName; }
            set { firstName = value; }
         }
         public string getLastName
         {
             get { return lastName; }
             set { lastName = value; }
         }
        public string getAddress
        {
            get { return address; }
            set { address = value; }
        }

        public string getCity
        {
            get { return city; }
            set { city = value; }
        }

        public string getState
        {
            get { return state; }
            set { state = value; }
        }
        public int getZip
        {
            get { return zip; }
            set { zip = value; }
        }
        public int getPhoneNumber
        {
            get { return phoneNumber; }
            set => phoneNumber = value;
        }

    }
}
