using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CSharp_OOP_Assignment_2_School.Classes
{
    internal class Student : Person
    {
        public Guid StudentID { get; set; }

        public Student()
        {
            StudentID = Guid.NewGuid();
        }
        public Student(string firstName, string lastName, DateTime dateTime) : base(firstName, lastName, dateTime)
        {
            StudentID = Guid.NewGuid();
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateTime;
        }
        public override string ToString()
        {
            return $"Name: {FirstName} {LastName} Date of Birth: {DateOfBirth} StudentID: {StudentID}";
        }
    }
}
