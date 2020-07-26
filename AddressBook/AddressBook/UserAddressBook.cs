using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;

namespace AddressBookNew
{
    class UserAddressBook
    {
        static void Main(string[] args)
        {
            Person person = new Person();

            int flag = 0;
            do
            {
                Console.WriteLine("Enter your choice 1.ADD 2.Display 3.Edit 4.Delete 5.SortByName 6.SortByCity 7.SortByState 8.SortByZip 9.Exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        person.AddPerson();
                        break;
                    case 2:
                        person.DisplayPerson();
                        break;
                    case 3:
                        person.EditPerson();
                        break;
                    case 4:
                        person.DeletePerson();
                        break;
                    case 5:
                        person.SortByName();
                        break;
                    case 6:
                        person.SortByCity();
                        break;
                    case 7:
                        person.SortByState();
                        break;
                    case 8:
                        person.SortByZip();
                        break;
                    case 9:
                        flag = 1;
                        break;

                }
            } while (flag == 0);

        }
    }
}