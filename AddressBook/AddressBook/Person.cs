using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO.Compression;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace AddressBookNew
{
    public class Person
    {
        public string firstName, lastName, address, city, state, zip, phoneNumber;
        bool duplicate;
        List<Person> PersonData = new List<Person>();
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

        public bool CheckDuplicate(string firstName)
        {
            foreach (Person person in PersonData)
            {
                if (firstName.Equals(person.firstName))
                {
                    Console.WriteLine("Records already exists");
                    duplicate = true;
                }
                else
                {
                    Console.WriteLine("Record not found");
                    duplicate = false;

                }
            }
            return false;
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
                // CheckDuplicate(firstName);
                if (duplicate == false)
                {
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
        }

        public void DisplayPerson()
        {
            foreach (Person persons in PersonData)
            {
                Console.WriteLine("First Name:" + persons.GetFirstName());
                Console.WriteLine("Last Name:" + persons.GetLastName());
                Console.WriteLine("Address:" + persons.GetAddress());
                Console.WriteLine("State:" + persons.GetState());
                Console.WriteLine("City:" + persons.GetCity());
                Console.WriteLine("Zip:" + persons.Getzip());
                Console.WriteLine("Phone number:" + persons.GetPhoneNumber());

            }
        }

        public void EditPerson()
        {
            Console.WriteLine("Enter the name of person");
            string name = Console.ReadLine();
            Person editPerson = SearchPerson(name);

            Console.WriteLine("Enter choice: 1.Address 2.City 3.State 4.Zip 5.Phone Number 6.exit");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter the address");
                    String address = Console.ReadLine();
                    editPerson.SetAddress(address);
                    break;
                case 2:
                    Console.WriteLine("Enter the city");
                    String city = Console.ReadLine();
                    editPerson.SetCity(city);
                    break;
                case 3:
                    Console.WriteLine("Enter the state");
                    String state = Console.ReadLine();
                    editPerson.SetState(state);
                    break;
                case 4:
                    Console.WriteLine("Enter the zip");
                    String zip = Console.ReadLine();
                    editPerson.SetZip(zip);
                    break;
                case 5:
                    Console.WriteLine("Enter the phone number");
                    String phoneNumber = Console.ReadLine();
                    editPerson.SetPhoneNumber(phoneNumber);
                    break;
                case 6:
                    break;
            }
        }

        public Person SearchPerson(string name)
        {
            foreach (Person person in PersonData)
            {
                if (person.GetFirstName().Equals(name))
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
        public void SortByName()
        {
            Sort sortName = new Sort();
            PersonData.Sort(sortName);
            Console.WriteLine("Persons After sorting");
            foreach (Person person in PersonData)
            {
                Console.WriteLine("First Name = {0}, Last Name = {1},  Address = {2}, City = {3}, State = {4}, Zip = {5}, Phone Number={6}",
                    person.firstName, person.lastName, person.address, person.city, person.state, person.zip, person.phoneNumber);
            }
            Console.ReadKey();
        }

        public void SortByCity()
        {
            Sortbycity sortName = new Sortbycity();
            PersonData.Sort(sortName);
            Console.WriteLine("Persons After sorting");
            foreach (Person person in PersonData)
            {
                Console.WriteLine("First Name = {0}, Last Name = {1},  Address = {2}, City = {3}, State = {4}, Zip = {5}, Phone Number={6}",
                    person.firstName, person.lastName, person.address, person.city, person.state, person.zip, person.phoneNumber);
            }
            Console.ReadKey();
        }

        public void SortByState()
        {
            Sortbystate sortName = new Sortbystate();
            PersonData.Sort(sortName);
            Console.WriteLine("Persons After sorting");
            foreach (Person person in PersonData)
            {
                Console.WriteLine("First Name = {0}, Last Name = {1},  Address = {2}, City = {3}, State = {4}, Zip = {5}, Phone Number={6}",
                    person.firstName, person.lastName, person.address, person.city, person.state, person.zip, person.phoneNumber);
            }
            Console.ReadKey();
        }

        public void SortByZip()
        {
            Sortbyzip sortName = new Sortbyzip();
            PersonData.Sort(sortName);
            Console.WriteLine("Persons After sorting");
            foreach (Person person in PersonData)
            {
                Console.WriteLine("First Name = {0}, Last Name = {1},  Address = {2}, City = {3}, State = {4}, Zip = {5}, Phone Number={6}",
                    person.firstName, person.lastName, person.address, person.city, person.state, person.zip, person.phoneNumber);
            }
            Console.ReadKey();
        }
    }
}