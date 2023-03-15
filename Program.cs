using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactBookApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice = 0;
            List<Person> contacts = new List<Person>();
            do
            {
                try
                {
                    Console.WriteLine("\n\nWELCOME CONTACT BOOK APP!\n");
                    Console.WriteLine("----------------------    MENU     ---------------------- ");
                    Console.WriteLine("Please press 1 to add new User");
                    Console.WriteLine("Please press 2 to show contact list");
                    Console.WriteLine("Please press 3 to display birthdate for specific person.");
                    Console.WriteLine("Please press 4 to  edit specific person.");
                    bool result = int.TryParse(Console.ReadLine(), out choice);
                    switch (choice)
                    {
                        case 1:
                            contacts.Add(addPerson());
                            break;
                        case 2:
                            foreach (var person in contacts)
                            {
                                person.displayData();
                            }
                            break;
                        case 3:
                            DisplayBirthDate(contacts);
                            break;
                        case 4:
                            EditPerson(contacts);
                            break;

                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error occured: " + e.ToString());
                }


            } while (true);
        }

        public static Person addPerson()
        {
            Console.WriteLine("Please Enter Name");
            string name = Console.ReadLine();
            Console.WriteLine("Please Enter Surname");
            string lastName = Console.ReadLine();
            Console.WriteLine("Please Enter phone number.");
            string phoneNumber = Console.ReadLine();
            Console.WriteLine("Please Enter emailaddress.");
            string emailaddress = Console.ReadLine();
            Console.WriteLine("Please Enter birthdate. (Expected Fornmat : 05-05-2021)");
            string birthdate = Console.ReadLine();
            Person p = new Person(name, lastName, phoneNumber, emailaddress, Convert.ToDateTime(birthdate));
            return p;
        }
        public static void DisplayBirthDate(List<Person> contacts)
        {
            Console.WriteLine("Please Enter Name of Person to display birthdate.");
            string name = Console.ReadLine();
            Console.WriteLine("\n Birthdate : " + contacts.Find(x => x.getName() == name).getDateOfBirth());

        }
        public static void EditPerson(List<Person> contacts)
        {
            Console.WriteLine("Please Enter Name of Person to edit");
            string name = Console.ReadLine();
            Person p = contacts.Find(x => x.getName() == name);
            Console.WriteLine("Please Enter new Name");
            string newName = Console.ReadLine();
            p.setName(newName);
            Console.WriteLine("Please Enter new Surname");
            string newSurname = Console.ReadLine();
            p.setSurName(newSurname);
            Console.WriteLine("Please Enter new PhoneNumber");
            string newPhoneNumber = Console.ReadLine();
            p.setPhoneNumber(newPhoneNumber);
            Console.WriteLine("Please Enter new Emailaddress");
            string newEmailAddress = Console.ReadLine();
            p.setEmailAddress(newEmailAddress);
            Console.WriteLine("Please Enter new Birthdate. (Expected Fornmat : 05-05-2021)");
            string newBirthdate = Console.ReadLine();
            p.setDateOfBirth(Convert.ToDateTime(newBirthdate));



        }
    }
}
