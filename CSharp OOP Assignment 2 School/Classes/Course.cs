using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_OOP_Assignment_2_School.Classes
{
    internal class Course
    {
        public string CourseID { get; set; }
        public string Name { get; set; }
        public Teacher Teacher { get; set; }
        public List<Student> Students { get; set; }
        public Course() 
        {
            
        }
        public Course(string courseID, string name, Teacher teacher)
        {
            CourseID = courseID;
            Name = name;
            Teacher = teacher;
            Students = new List<Student>();
        }


    }
}
