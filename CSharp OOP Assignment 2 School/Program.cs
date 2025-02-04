using CSharp_OOP_Assignment_2_School.Classes;
using static System.Console;

namespace CSharp_OOP_Assignment_2_School
{
    internal class Program
    {

        static void Main(string[] args)
        {
            School school = new School("Lilla Skolan");
            Teacher teacher = new Teacher();
            Student student = new Student();
            Grade grade = new Grade();
            Course course = new Course();
            ForegroundColor = ConsoleColor.DarkYellow;
            try
            {
                while (true)
                {
                    Clear();
                    WriteLine("Welcome to Lilla Skolans Administration Program \nChoose below what you want to do\n\n");

                    WriteLine("1. Display all teachers / students / courses");
                    WriteLine("2. Add a teacher / student / course / enroll student to course");
                    WriteLine("3. Withdraw a student / teacher / course");
                    WriteLine("4. Show / Remove / Set grades");
                    WriteLine();
                    Write("Choose an option (1-4) or 0 to exit: ");
                    int option = int.Parse(ReadLine());
                    if (option == 0)
                    {
                        break;
                    }
                    switch (option)
                    {
                        case 1:
                            Clear();
                            WriteLine("1. Display all teachers");
                            WriteLine("2. Display all students");
                            WriteLine("3. Display all courses");
                            WriteLine("\n0. Go back to previous menu");
                            Write("Choose an option (1-3): ");
                            option = int.Parse(ReadLine());
                            if (option == 0)
                            {
                                break;
                            }
                            switch (option)
                            {
                                case 1:
                                    Clear();
                                    DisplayTeachers(school);
                                    WriteLine("\n\n\n Press any key to continue...");
                                    ReadKey();
                                    break;
                                case 2:
                                    Clear();
                                    DisplayStudents(school);
                                    WriteLine("\n\n\n Press any key to continue...");
                                    ReadKey();
                                    break;
                                case 3:
                                    Clear();
                                    DisplayCourses(school);
                                    WriteLine("\n\n\n Press any key to continue...");
                                    ReadKey();
                                    break;
                            }
                            break;
                        case 2:
                            Clear();
                            WriteLine("1. Add a teacher");
                            WriteLine("2. Add a student");
                            WriteLine("3. Add a course");
                            WriteLine("4. Enroll student to course");
                            WriteLine("\n0. Go back to previous menu");
                            Write("Choose an option (1-3): ");
                            option = int.Parse(ReadLine());
                            if (option == 0)
                            {
                                break;
                            }
                            switch (option)
                            {
                                case 1:
                                    Clear();
                                    AddTeacher(school);
                                    WriteLine("\n\n\n Press any key to continue...");
                                    ReadKey();
                                    break;
                                case 2:
                                    Clear();
                                    AddStudent(school);
                                    WriteLine("\n\n\n Press any key to continue...");
                                    ReadKey();
                                    break;
                                case 3:
                                    Clear();
                                    AddCourse(school, teacher);
                                    WriteLine("\n\n\n Press any key to continue...");
                                    ReadKey();
                                    break;
                                case 4:
                                    Clear();
                                    EnrollCourse(school);
                                    WriteLine("\n\n\n Press any key to continue...");
                                    ReadKey();
                                    break;
                            }
                            break;
                        case 3:
                            Clear();
                            WriteLine("1. Withdraw a student");
                            WriteLine("2. Withdraw a teacher");
                            WriteLine("3. Withdraw a course");
                            WriteLine("\n0. Go back to previous menu");
                            Write("Choose an option (1-3): ");
                            option = int.Parse(ReadLine());
                            if (option == 0)
                            {
                                break;
                            }
                            switch (option)
                            {
                                case 1:
                                    Clear();
                                    RemoveStudent(school);
                                    WriteLine("\n\n\n Press any key to continue...");
                                    ReadKey();
                                    break;
                                case 2:
                                    Clear();
                                    RemoveTeacher(school);
                                    WriteLine("\n\n\n Press any key to continue...");
                                    ReadKey();
                                    break;
                                case 3:
                                    Clear();
                                    RemoveCourse(school);
                                    WriteLine("\n\n\n Press any key to continue...");
                                    ReadKey();
                                    break;
                            }
                            break;
                        case 4:
                            Clear();
                            WriteLine("1. Show grades");
                            WriteLine("2. Remove grade");
                            WriteLine("3. Set grade");
                            WriteLine("\n0. Go back to previous menu");
                            Write("Choose an option (1-3): ");
                            option = int.Parse(ReadLine());
                            if (option == 0)
                            {
                                break;
                            }
                            switch (option)
                            {
                                case 1:
                                    Clear();
                                    DisplayGrades(school);
                                    WriteLine("\n\n\n Press any key to continue...");
                                    ReadKey();
                                    break;
                                case 2:
                                    Clear();
                                    RemoveGrade(school);
                                    WriteLine("\n\n\n Press any key to continue...");
                                    ReadKey();
                                    break;
                                case 3:
                                    Clear();
                                    SetGrade(school, course, student);
                                    WriteLine("\n\n\n Press any key to continue...");
                                    ReadKey();
                                    break;
                            }
                            break;
                    }
                }
                WriteLine("\n\n");
                Write("Press any key to exit.");
                ReadKey();
            }
            catch (Exception e) { WriteLine(e.Message); }
        }
        static void DisplayTeachers(School school)
        {
            foreach (var t in school.Teachers)
            {
                WriteLine($"Name: {t.FirstName} {t.LastName}   \tDate of Birth: {t.DateOfBirth.ToShortDateString()}\tTeacherID: {t.TeacherID}");
                if (school.Teachers == null)
                {
                    WriteLine("No teachers are added.");
                    WriteLine("\n\nPress any key to continue...");
                    ReadKey();
                }

            }
        }
        static void DisplayStudents(School school)
        {
            foreach (var s in school.Students)
            {
                WriteLine($"Name: {s.FirstName} {s.LastName}      \tDate of Birth: {s.DateOfBirth.ToShortDateString()}\tStudentID: {s.StudentID}");
                if (school.Students == null)
                {
                    WriteLine("No students are added.");
                    WriteLine("\n\nPress any key to continue...");
                    ReadKey();
                }
            }
        }
        static void DisplayGrades(School school)
        {
            foreach (var g in school.Grades)
            {
                WriteLine($"Course: {g.Course.Name}\tStudent: {g.Student.FirstName} {g.Student.LastName}   \tGrade: {g.Grading}\tGradeID: {g.GradeID} ");
                if (school.Grades == null)
                {
                    WriteLine("No grades are added.");
                    WriteLine("\n\nPress any key to continue...");
                    ReadKey();
                }
            }
        }
        static void DisplayCourses(School school)
        {
            foreach (var c in school.Courses)
            {
                WriteLine($"Course ID: {c.Value.CourseID}   \tCourse Name: {c.Value.Name}    \tTeacher: {c.Value.Teacher.FirstName} {c.Value.Teacher.LastName}      \tStudents in Course: {c.Value.Students.Count}");
                if (school.Courses == null)
                {
                    WriteLine("No courses are added.");
                    WriteLine("\n\nPress any key to continue...");
                    ReadKey();
                }
            }
        }
        static void AddStudent(School school)
        {
            try
            {
                WriteLine("Add a new student");
                Write("First Name: ");
                string fName = ReadLine();
                if (fName == "")
                    throw new Exception("You did not enter a name.");
                Write("Last Name: ");
                string lName = ReadLine();
                if (lName == "")
                    throw new Exception("You did not enter a name.");
                Write("Date of birth: ");
                DateTime birthDate = DateTime.Parse(ReadLine());

                Student student = new Student(fName, lName, birthDate);

                school.EnrollSchool(student);
            }
            catch (Exception e) { WriteLine(e.Message); }
        }
        static void AddTeacher(School school)
        {
            try
            {
                WriteLine("Add a new teacher");
                Write("First Name: ");
                string fName = ReadLine();
                if (fName == "")
                    throw new Exception("You did not enter a name.");
                Write("Last Name: ");
                string lName = ReadLine();
                if (lName == "")
                    throw new Exception("You did not enter a name.");
                Write("Date of birth: ");
                DateTime birthDate = DateTime.Parse(ReadLine());

                Teacher teacher = new Teacher(fName, lName, birthDate);

                school.AddTeacher(teacher);
            }
            catch (Exception e) { WriteLine(e.Message); }
        }
        static void AddCourse(School school, Teacher teacher)
        {
            try
            {
                WriteLine("Add a new course\n");
                WriteLine("This is a list of current courses");
                DisplayCourses(school);
                string cID;
                Write("New Course ID: ");
                cID = ReadLine();
                if (cID == "")
                    throw new Exception("You did not enter a Course ID.");
                Write("New Course Name: ");
                string cName = ReadLine();
                if (cName == "")
                    throw new Exception("You did not enter a Course Name.");
                WriteLine("This is a list of current teachers");
                DisplayTeachers(school);
                Write("Add Teacher to course (use TeacherID): ");
                Guid tID = Guid.Parse(ReadLine());
                foreach (var t in school.Teachers)
                {
                    if (tID == t.TeacherID)
                        teacher = t;
                    else
                        throw new Exception("You did not enter a correct TeacherID.");
                }

                Course course = new Course(cID, cName, teacher);
                school.AddCourse(course);
                WriteLine("\nDo you want to add any students to the course? (y/n): ");
                string addS = ReadLine().ToLower();
                if (addS == "y")
                {

                    while (true)
                    {
                        DisplayStudents(school);
                        Write("Enter StudentID to add student to course: ");
                        Guid sID = Guid.Parse(ReadLine());
                        foreach (var s in school.Students)
                        {
                            if (s.StudentID == sID)
                            {
                                school.EnrollCourse(course, s);
                                WriteLine($"\n{s.FirstName} {s.LastName} has ben added to {course.CourseID}");
                            }
                            else
                                throw new Exception("You did not enter a correct StudentID.");
                        }
                        WriteLine("Do you want to add another student? (y/n): ");
                        addS = ReadLine().ToLower();
                        if (addS == "n")
                            break;
                    }
                }
            }
            catch (Exception e) { WriteLine(e.Message); }
        }
        static void RemoveStudent(School school)
        {
            try
            {
                DisplayStudents(school);
                WriteLine("\n\n");
                Write("Input StudentID to remove student: ");
                Guid sID = Guid.Parse(ReadLine());
                foreach (var s in school.Students)
                {
                    if (s.StudentID == sID)
                    {
                        school.Students.Remove(s);
                        break;
                    }
                    else
                        throw new Exception("That user was not found.");
                }
            }
            catch (Exception e) { WriteLine(e.Message); }
        }
        static void RemoveTeacher(School school)
        {
            try
            {
                DisplayTeachers(school);
                WriteLine("\n\n");
                Write("Input TeacherID to remove user: ");
                Guid sID = Guid.Parse(ReadLine());
                foreach (var s in school.Teachers)
                {
                    if (s.TeacherID == sID)
                    {
                        school.Teachers.Remove(s);
                        break;
                    }
                    else
                        throw new Exception("That user was not found.");
                }
            }
            catch (Exception e) { WriteLine(e.Message); }

        }
        static void RemoveCourse(School school)
        {
            try
            {
                DisplayCourses(school);
                WriteLine("\n\n");
                Write("Input CourseID to remove course: ");
                string cID = ReadLine();
                if (cID == "")
                    throw new Exception("You did not enter a CourseID.");
                var item = school.Courses.First(c => c.Value.CourseID == cID);
                school.Courses.Remove(item.Key);
            }
            catch (Exception e) { WriteLine(e.Message); }

        }
        static void RemoveGrade(School school)
        {
            try
            {
                DisplayGrades(school);
                WriteLine("\n\n");
                Write("Input GradeID to remove grade: ");
                Guid gID = Guid.Parse(ReadLine());
                foreach (var g in school.Grades)
                {
                    if (g.GradeID == gID)
                        school.Grades.Remove(g);

                    else
                        throw new Exception("That grade was not found.");
                }
            }
            catch (Exception e) { WriteLine(e.Message); }
        }
        static void SetGrade(School school, Course course, Student student)
        {
            try
            {
                DisplayCourses(school);
                Write("What course do you want to set a grade in?\nEnter CourseID or Course Name: ");
                string setCourse = ReadLine();
                foreach (var c in school.Courses)
                {
                    if (c.Key == setCourse || c.Value.Name == setCourse)
                    {
                        course = c.Value;
                    }
                    else
                        throw new Exception("You did not enter a valid CourseID.");
                }

                DisplayStudents(school);
                Write("What student do you want to set a grade for?\nEnter StudentID: ");
                Guid sID = Guid.Parse(ReadLine());
                foreach (var s in school.Students)
                {
                    if (sID == s.StudentID)
                    {
                        student = s;
                    }
                    else
                        throw new Exception("You did not enter a valid StudentID.");
                }

                Write("What grade do you want give?\nSet grade (A-F): ");
                Grade.GradeNum grade = Enum.Parse<Grade.GradeNum>(ReadLine().ToUpper());
                if (grade != Grade.GradeNum.A || grade != Grade.GradeNum.B || grade != Grade.GradeNum.C || grade != Grade.GradeNum.D || grade != Grade.GradeNum.E || grade != Grade.GradeNum.F)
                    throw new Exception("You did not enter a valid grade.");
                Grade newgrade = new Grade(course, student, grade);
                school.SetGrade(course, student, newgrade);
            }
            catch (Exception e) { WriteLine(e.Message); }
        }
        static void EnrollCourse(School school)
        {
            try
            {
                DisplayCourses(school);
                Write("What course do you want to add students to?\nEnter cID: ");
                string cID = ReadLine();
                if (cID == "")
                    throw new Exception("You did not enter a cID.");
                foreach (var c in school.Courses)
                {
                    if (c.Value.CourseID == cID)
                    {
                        Course course = c.Value;
                        DisplayStudents(school);
                        Write($"What student do you want to add to {c.Value.Name}?\nEnter StudentID: ");
                        Guid sID = Guid.Parse(ReadLine());
                        foreach (var s in school.Students)
                        {
                            if (s.StudentID == sID)
                            {
                                Student student = s;
                                if (school.IsCourseEnrolled(course, student) == false)
                                {
                                    school.EnrollCourse(course, student);
                                }
                                else
                                    throw new Exception("This student is already enrolled to this class!");
                            }
                            else
                                throw new Exception("This student doesn't exist.");
                        }
                    }
                    else
                        throw new Exception("This course doesn't exist.");
                }
            }
            catch (Exception e) { WriteLine(e.Message); }
        }

    }
}
