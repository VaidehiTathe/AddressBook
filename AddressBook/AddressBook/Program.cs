using System;

namespace AddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Person person = new Person();
            person.getFirstName = "Vaidehi";
            Console.WriteLine("First name is:" + person.getFirstName);

            person.getLastName = "Tathe";
            Console.WriteLine("Last name is:" + person.getLastName);

            person.getAddress = "Rajgad";
            Console.WriteLine("Address is:" + person.getAddress);

            person.getCity = "Solapur";
            Console.WriteLine("City is:" + person.getCity);

            person.getState = "Maharashtra";
            Console.WriteLine("State is:" + person.getState);

            person.getZip = "413003";
            Console.WriteLine("Zip code is:" + person.getZip);

            person.phoneNumber = 9823458484;
            Console.WriteLine("phoneNumber is:" + person.getphoneNumber);
        }
    }
}
