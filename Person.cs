using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactBookApplication
{
    public class Person
    {
        private string Name;
        private string Surname;
        private string PhoneNumber;
        private string EmailAddress;
        private DateTime DateOfBirth;
        public Person(string name, string surname, string phonenumber, string emailaddress, DateTime dateofBirth)
        {
            this.Name = name;
            this.Surname = surname;
            this.PhoneNumber = phonenumber;
            this.EmailAddress = emailaddress;
            this.DateOfBirth = dateofBirth;
        }

        public void displayData()
        {
            Console.WriteLine("         --Name : " + this.Name + " --Surname : " + this.Surname + " --PhoneNumber : " + this.PhoneNumber+ " -- Birthdate : " + this.DateOfBirth);
        }
        public string getPhoneNumber()
        {
            return this.PhoneNumber;
        }
        public string getName()
        {
            return this.Name;
        }
        public string getSurName()
        {
            return this.Surname;
        }
        public DateTime getDateOfBirth()
        {
            return this.DateOfBirth;
        }
        public string getEmailAddress()
        {
            return this.EmailAddress;
        }


        //Set Functions
        public void setPhoneNumber(string phoneNumber)
        {
            this.PhoneNumber = phoneNumber;
        }
        public void setName(string name)
        {
            this.Name = name;
        }
        public void setSurName(string surname)
        {
            this.Surname = surname;
        }
        public void setDateOfBirth(DateTime birthdate)
        {
            this.DateOfBirth = birthdate;
        }
        public void setEmailAddress(string emailaddress)
        {
            this.EmailAddress = emailaddress;
        }

    }
}
