using AddressBookNew;
using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook
{
    class AddressBookUtility
    {
        public string firstName, lastName, address, city, state, zip, phoneNumber;
        bool duplicate;
        List<Person> PersonData = new List<Person>();
        int numberOfPerson;

        Dictionary<string, Person> personName = new Dictionary<string, Person>();
        Dictionary<string, Person> personCity = new Dictionary<string, Person>();
        Dictionary<string, Person> personState = new Dictionary<string, Person>();
        Dictionary<string, Person> personZip = new Dictionary<string, Person>();
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
            int totalnumberOfPerson = Convert.ToInt32(Console.ReadLine());

            for (numberOfPerson = 1; numberOfPerson <= totalnumberOfPerson; numberOfPerson++)
            {


                Console.WriteLine("Enter your first name:");
                string firstName = Console.ReadLine();

                Console.WriteLine("Enter your last name:");
                string lastName = Console.ReadLine();
                CheckDuplicate(firstName);
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
                    Person personAdd = new Person();
                    personName.Add(firstName, personAdd);
                    personCity.Add(city, personAdd);
                    personState.Add(state, personAdd);
                    personZip.Add(zip, personAdd);
                }


            }
        }

        public void DisplayPerson()
        {
            foreach (Person persons in PersonData)
            {
                Console.WriteLine("First Name = {0}, Last Name = {1},  Address = {2}, City = {3}, State = {4}, Zip = {5}, Phone Number={6}",
                    persons.firstName, persons.lastName, persons.address, persons.city, persons.state, persons.zip, persons.phoneNumber);
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


        public void ViewCity()
        {
            Console.WriteLine("Enter the city name");
            string city = Console.ReadLine();
            foreach (KeyValuePair<string, Person> cityView in personCity)
            {
                if (cityView.Key == city)
                {

                    Console.WriteLine("City: {0} Person name: {1}", cityView.Key, cityView.Value.firstName);
                }
            }
        }

        public void ViewState()
        {
            Console.WriteLine("Enter the State name");
            string city = Console.ReadLine();
            foreach (KeyValuePair<string, Person> stateView in personCity)
            {
                if (stateView.Key == city)
                {
                    Console.WriteLine("City: {0} Person name: {1}", stateView.Key, stateView.Value.firstName);
                }
            }
        }
    }
}
