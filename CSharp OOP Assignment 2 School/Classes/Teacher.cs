using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_OOP_Assignment_2_School.Classes
{
    internal class Teacher : Person
    {
        public Guid TeacherID { get; set; }

        public Teacher()
        {
            TeacherID = Guid.NewGuid();
        }
        public Teacher(string firstName, string lastName, DateTime dateTime) : base(firstName, lastName, dateTime)
        {
            TeacherID = Guid.NewGuid();
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateTime;
        }
        public override string ToString()
        {
            return $"Name: {FirstName} {LastName} Date of Birth: {DateOfBirth} TeacherID: {TeacherID}";
        }
    }
}
