using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CSharp_OOP_Assignment_2_School.Classes
{
    internal class School
    {
        public string Name { get; set; }
        public List<Student> Students { get; set; }
        public Dictionary<string, Course> Courses { get; set; }
        public List<Teacher> Teachers { get; set; }
        public List<Grade> Grades { get; set; } 
        public School() 
        {
            Students = new List<Student> { };
            Courses = new Dictionary<string, Course> { };
            Teachers = new List<Teacher> { };
            Grades = new List<Grade> { };
        }
        public School(string name)
        {
            Name = name;
            Students = new List<Student> { };
            Courses = new Dictionary<string, Course> { };
            Teachers = new List<Teacher> { };
            Grades = new List<Grade> { };
        }
        
        public bool HasCourse(Course course)
        {
            foreach (var c in Courses)
            {
                if (course.CourseID == c.Value.CourseID)
                    return true;
            }
            return false;
        }
        public void AddCourse(Course course)
        {
            try
            {
            foreach (var c in Courses)
            { 
                if (Courses.ContainsKey(course.CourseID))
                    throw new Exception($"{course.CourseID} already exist!");
                else if (course.CourseID == null)
                    throw new Exception("This course is missing a CourseID!");
            }
            Courses.Add(course.CourseID, course);
            }
            catch (Exception e) { WriteLine(e.Message); }
        }
        public void AddTeacher(Teacher teacher)
        {
            try
            {
            foreach (var t in Teachers)
            {
                if (t.TeacherID == teacher.TeacherID)
                    throw new Exception("This teacher already exist.");
            }
            Teachers.Add(teacher);
            }
            catch (Exception e) { WriteLine(e.Message); }
        }
        public void RemoveCourse(Course course)
        {
            try
            {
            foreach(var c in Courses.Keys)
            {
                if (course.CourseID != c)
                    throw new Exception($"{course.CourseID} doesn't exist!");
            }
            Courses.Remove(course.CourseID);
            }
            catch (Exception e) { WriteLine(e.Message); }
        }
        public bool IsSchoolEnrolled(Student student)
        {
            foreach (var s in Students)
            {
                if (student.StudentID == s.StudentID)
                    return true;
            }
            return false;
        }
        public bool IsCourseEnrolled(Course course,Student student)
        {
            foreach (var c in course.Students)
            {
                if (student.StudentID == c.StudentID)
                    return true;
            }
            return false;
        }
        public void EnrollCourse(Course course, Student student)
        {
            try
            {
            if (IsCourseEnrolled(course, student) == true)
                throw new Exception($"{student.FirstName} {student.LastName} is already enrolled to {course.Name}!");
            else if (IsSchoolEnrolled(student) == false)
                throw new Exception($"{student.FirstName} {student.LastName} is not enrolled in this school!");
            else if (student == null)
                throw new Exception($"This student doesn't exist!");
            else
                course.Students.Add(student);
            }
            catch (Exception e) { WriteLine(e.Message); }
        }
        public void EnrollSchool(Student student)
        {
            if (IsSchoolEnrolled(student) == true)
                throw new Exception($"{student.FirstName} {student.LastName} with ID: [{student.StudentID}] is already enrolled!");
            else
                Students.Add(student);
        }
        public void WithdrawFromSchool(Student student)
        {
            try
            {
            foreach (var s in Students)
            {
                if (IsSchoolEnrolled(student) == true)
                    Students.Remove(student);
                else
                    throw new Exception("This student is not enrolled here!");
            }
            }
            catch (Exception e) { WriteLine(e.Message); }
        }
        public void WithdrawFromCourse(Course course, Student student)
        {
            try
            {
            if (IsSchoolEnrolled(student) == false)
            {
                throw new Exception("This student is not enrolled here!");
            }
            else if (HasCourse(course) == false)
            {
                throw new Exception("This course does not exist!");
            }
            else if (IsCourseEnrolled(course, student) == false)
            {
                throw new Exception($"{student.FirstName} {student.LastName} is not enrolled in this course!");
            }
            course.Students.Remove(student);
            }
            catch (Exception e) { WriteLine(e.Message); }
        }
        public void SetGrade(Course course, Student student, Grade grade)
        {
            try
            {
            foreach (var g in Grades)
            {
                if (g.Course.CourseID == course.CourseID && g.Student.StudentID == student.StudentID)
                    g.Grading = grade.Grading;
            }

            if (IsSchoolEnrolled(student) == false)
                throw new Exception("This student is not enrolled here!");

            else if (HasCourse(course) == false)
                throw new Exception("This course does not exist!");
            else
                Grades.Add(grade);
            }
            catch (Exception e) { WriteLine(e.Message); }
        }
        public void RemoveGrade(Course course,Student student)
        {
            try
            {
            foreach (var g in Grades)
            {
                if (g.Course.CourseID == course.CourseID && g.Student.StudentID == student.StudentID)
                {
                    int index = Grades.FindIndex(g => g.Course.CourseID == course.CourseID && g.Student.StudentID == student.StudentID);
                    Grades.RemoveAt(index);
                }
                else
                    throw new Exception($"Could not find grade for {student.FirstName} {student.LastName} in the {course.Name} course!");
            }
            }
            catch (Exception e) { WriteLine(e.Message); }
        }
        public void GetGrades(Student student)
        {
            try
            {
            foreach(var g in Grades)
            {
                if (g.Student.StudentID == student.StudentID)
                    WriteLine($"Course: {g.Course.CourseID}\tTeacher: {g.Course.Teacher} Grade:{g.Grading} ID:{g.GradeID}");
                else
                    throw new Exception("This student doesn't have any current grades!");
            }
            }
            catch (Exception e) { WriteLine(e.Message); }
        }

    }
}
