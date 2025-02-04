using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_OOP_Assignment_2_School.Classes
{
    internal class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Person()
        {

        }
        public Person(string firstName, string lastName, DateTime dateOfBirth)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
        }
        public int GetAge(Person person)
        {
            DateOfBirth = person.DateOfBirth;
            TimeSpan timeSpan = DateTime.Now - DateOfBirth;
            int ageDays = timeSpan.Days;
            int age = ageDays / 365;

            return age;
        }
    }
}
