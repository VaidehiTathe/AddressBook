using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook
{
    public class Person 
    {
        private string firstName, lastName, address, city, state;
        private int zip, phoneNumber;

         public void AddPerson()
        {
            Console.WriteLine("Enter your first name:");
            string firstName = Console.ReadLine();
           
            Console.WriteLine("Enter your last name:");
            string lastName = Console.ReadLine();
           
            Console.WriteLine("Enter your address:");
            string address = Console.ReadLine();
            
            Console.WriteLine("Enter your city:");
            string city = Console.ReadLine();
           
            Console.WriteLine("Enter your state:");
            string state = Console.ReadLine();
            
            Console.WriteLine("Enter your zip code:");
            int zip = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your phoneNumber:");
            int phoneNumber = Convert.ToInt32(Console.ReadLine());
        
            Console.WriteLine("Person information is:{0} {1} {2} {3} {4} {5} {6}", firstName, lastName, address,city,state,zip,phoneNumber);
        }
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
