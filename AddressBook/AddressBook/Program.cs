using System;

namespace AddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Person person = new Person();
            person.FirstName = "Vaidehi";
            Console.WriteLine("First name is:" + person.FirstName);

            person.LastName = "Tathe";
            Console.WriteLine("Last name is:" + person.LastName);

            person.Address = "Rajgad";
            Console.WriteLine("Address is:" + person.Address);

            person.City = "Solapur";
            Console.WriteLine("City is:" + person.City);

            person.State = "Maharashtra";
            Console.WriteLine("State is:" + person.State);

            person.Zip = 413003;
            Console.WriteLine("Zip code is:" + Convert.ToInt32(person.Zip));

            person.PhoneNumber = unchecked((int)9883456765);
            Console.WriteLine("Mobile number is:" + Convert.ToInt32(person.PhoneNumber));
        }
    }
}
