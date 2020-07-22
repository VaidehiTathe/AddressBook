using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace AddressBook
{
    public class Person
    {
        private string firstName, lastName, address, city, state,zip,phoneNumber;
        public ArrayList PersonData = new ArrayList();
        int number;
        public Person(string firstName, string lastName, string address, string city, string state, string zip, string phoneNumber)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.city = city;
            this.state = state;
            this.zip = zip;
            this.phoneNumber = phoneNumber;
        }

        public string GetFirstName()
        {
            return this.firstName;
        }
        public string GetLastName()
        {
            return this.lastName;
        }
        public void SetLastName(string lastName)
        {
            this.address = lastName;
        }
        public string GetAddress()
        {
            return this.address;
        }
        public void SetAddress(string address)
        {
            this.address = address;
        }
        public string GetState()
        {
            return this.state;
        }
        public void SetState(string state)
        {
            this.state = state;
        }
        public string GetCity()
        {
            return this.city;
        }
        public void SetCity(string city)
        {
            this.city = city;
        }
        public string Getzip()
        {
            return this.zip;
        }
        public void SetZip(string zip)
        {
            this.zip = zip;
        }
        public string GetPhoneNumber()
        {
            return this.phoneNumber;
        }
        public void SetPhoneNumber(string phoneNumber)
        {
            this.phoneNumber = phoneNumber;
        }


        public Person()
        {

        }

       

        public void AddPerson()
        {
            Console.WriteLine("Enter total number of people that you want to add:");
            int totalnumber = Convert.ToInt32(Console.ReadLine());
            for (number = 1; number <= totalnumber; number++)
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
                string zip = Console.ReadLine();

                Console.WriteLine("Enter your phoneNumber:");
                string phoneNumber = Console.ReadLine();

                PersonData.Add(new Person(firstName, lastName, address, city, state, zip, phoneNumber));
            }
        }

        public void DisplayPerson()
        {
            foreach (Person persons in PersonData)
            {
                Console.WriteLine(persons.GetFirstName());
                Console.WriteLine(persons.GetLastName());
                Console.WriteLine(persons.GetAddress());
                Console.WriteLine(persons.GetState());
                Console.WriteLine(persons.GetCity());
                Console.WriteLine(persons.Getzip());
                Console.WriteLine(persons.GetPhoneNumber());
               
            }
        }

        public void EditPerson()
        {
            Person editPerson = new Person("", "", "", "", "", "","");
            Console.WriteLine("Enter the name of person");
            firstName = Console.ReadLine();
            foreach (Person person in PersonData)
            {
                if (person.GetFirstName().Equals(firstName))
                {
                    editPerson = person;
                }
                Console.WriteLine("Enter the address");
                String address = Console.ReadLine();
                editPerson.SetAddress(address);
                Console.WriteLine("Enter the city");
                String city = Console.ReadLine();
                editPerson.SetCity(city);
                Console.WriteLine("Enter the state");
                String state = Console.ReadLine();
                editPerson.SetState(state);
                Console.WriteLine("Enter the zip");
                String zip = Console.ReadLine();
                editPerson.SetZip(zip);
                Console.WriteLine("Enter the phone number");
                String phoneNumber = Console.ReadLine();
                editPerson.SetPhoneNumber(phoneNumber);
            }
        }

        public Person SearchPerson(string name)
        {
            foreach (Person person in PersonData)
            {
                if(person.GetFirstName().Equals(name))
                {
                    return person;
                }
            }
            return null;
        }
        public void DeletePerson()
        {
            Console.WriteLine("Enter the user name which you want to delete:");
            string name = Console.ReadLine();
            Person deletePerson = SearchPerson(name);
            PersonData.Remove(deletePerson);
            Console.WriteLine("User deleted successfully");
        }

    }
}
