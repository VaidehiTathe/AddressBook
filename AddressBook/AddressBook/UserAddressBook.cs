using AddressBook;
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
            AddressBookUtility addressBookUtility = new AddressBookUtility();

            int flag = 0;
            do
            {
                Console.WriteLine("Enter your choice 1.ADD 2.Display 3.Edit 4.Delete 5.SortByName 6.SortByCity 7.SortByState 8.SortByZip 9.View person by city 10.View Person by State 11.Exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        addressBookUtility.AddPerson();
                        break;
                    case 2:
                        addressBookUtility.DisplayPerson();
                        break;
                    case 3:
                        addressBookUtility.EditPerson();
                        break;
                    case 4:
                        addressBookUtility.DeletePerson();
                        break;
                    case 5:
                        addressBookUtility.SortByName();
                        break;
                    case 6:
                        addressBookUtility.SortByCity();
                        break;
                    case 7:
                        addressBookUtility.SortByState();
                        break;
                    case 8:
                        addressBookUtility.SortByZip();
                        break;
                    case 9:
                        addressBookUtility.ViewCity();
                        break;
                    case 10:
                        addressBookUtility.ViewState();
                        break;
                    case 11:
                        flag = 1;
                        break;

                }
            } while (flag == 0);

        }
    }
}