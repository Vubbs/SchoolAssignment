using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_OOP_Assignment_2_School.Classes
{
    internal class Grade
    {
        public Guid GradeID { get; set; }
        public Course Course { get; set; }
        public Student Student { get; set; }
        public DateTime DateAquired { get; set; }
        public GradeNum Grading {  get; set; }
        public enum GradeNum
        {
            A, 
            B, 
            C, 
            D, 
            E, 
            F,
        }
        public Grade() 
        { 
            GradeID = Guid.NewGuid();
            DateAquired = DateTime.Now;
        }
        public Grade(Course course,Student student, GradeNum grade)
        {
            GradeID = Guid.NewGuid();
            Course = course;
            Student = student;
            DateAquired = DateTime.Now;
            Grading = grade;
        }
        public override string ToString()
        {
            switch(Grading)
            {
                case GradeNum.A: return "Exellent! You got an A!";
                case GradeNum.B: return "Good Job! You got a B";
                case GradeNum.C: return "Good! C Grade!";
                case GradeNum.D: return "You passed! D Grade.";
                case GradeNum.E: return "Just made it. E Grade.";
                case GradeNum.F: return "Sorry, you failed. F Grade.";
            }
            return "Something went wrong, this is not a valid grade.";
        }
    }
}
