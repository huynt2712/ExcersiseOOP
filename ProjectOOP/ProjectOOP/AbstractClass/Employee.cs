using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectOOP
{
    public abstract class Employee
    {
        private string empCode;
        private string firstName;
        private string lastName;
        private int age;
        private string phoneNumber;
        private string email;
        public string EmpCode  
        {
            get { return empCode; }
            set { empCode = value; }
        }
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value ; }
        }
        public string LastName  
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public string PhoneNumber
        { 
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public void GetFullName()
        {
            Console.WriteLine($"{FirstName} {LastName}");
        }
        public abstract void GetInformation();
    }
}
