using System.Xml.Linq;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create students
            Student student1 = new Student { Name = "Alice", Birthdate = new DateTime(2000, 1, 1), Salary = 0 };
            Student student2 = new Student { Name = "Bob", Birthdate = new DateTime(2001, 2, 2), Salary = 0 };

            // Create courses
            Course course1 = new Course { Name = "Math", Credits = 3, GradePoints = 4.0f }; // A grade
            Course course2 = new Course { Name = "History", Credits = 3, GradePoints = 3.0f }; // B grade

            // Students enroll in courses
            student1.AddCourse(course1);
            student1.AddCourse(course2);
            student2.AddCourse(course1);

            // Calculate GPA for students
            Console.WriteLine($"{student1.Name}'s GPA: {student1.CalculateGPA()}");
            Console.WriteLine($"{student2.Name}'s GPA: {student2.CalculateGPA()}");

            // Create instructor
            Instructor instructor = new Instructor { Name = "Charles", Birthdate = new DateTime(1980, 3, 3), Salary = 60000, JoinDate = new DateTime(2010, 4, 4) };

            // Calculate experience and salary for the instructor
            Console.WriteLine($"{instructor.Name}'s Experience: {instructor.CalculateExperience()} years");
            Console.WriteLine($"{instructor.Name}'s Salary: {instructor.CalculateSalary()}");

            // Create department
            Department department = new Department { Name = "Science", Head = instructor, Budget = 100000, SchoolYearStart = new DateTime(2022, 9, 1), SchoolYearEnd = new DateTime(2023, 6, 1) };

            // Add courses to the department
            department.OfferedCourses.Add(course1);
            department.OfferedCourses.Add(course2);

            // Set instructor's department and department head status
            instructor.Department = department;
            instructor.IsDepartmentHead = true;
        }
    }
    // Interfaces
    public interface IPersonService
    {
        int CalculateAge();
        decimal CalculateSalary();
    }

    public interface IStudentService : IPersonService
    {
        float CalculateGPA();
    }

    public interface IInstructorService : IPersonService
    {
        int CalculateExperience();
    }

    // Abstraction
    abstract class Person
    {
        // Encapsulation
        public string Name { get; set; }
        public DateTime Birthdate { get; set; }
        public decimal Salary { get; set; }
        public List<string> Addresses { get; private set; }

        public Person()
        {
            Addresses = new List<string>();
        }

        public void AddAddress(string address)
        {
            Addresses.Add(address);
        }
    }

    class Student : Person, IStudentService
    {
        public List<Course> Courses { get; private set; }

        public Student()
        {
            Courses = new List<Course>();
        }

        public void AddCourse(Course course)
        {
            Courses.Add(course);
        }

        public int CalculateAge()
        {
            int age = DateTime.Now.Year - Birthdate.Year;
            return age;
        }

        public decimal CalculateSalary()
        {
            return Salary;
        }

        // Polymorphism
        public float CalculateGPA()
        {
            int totalCredits = 0;
            float totalPoints = 0;

            foreach (Course course in Courses)
            {
                totalCredits += course.Credits;
                totalPoints += course.GradePoints * course.Credits;
            }

            return totalPoints / totalCredits;
        }
    }

    class Instructor : Person, IInstructorService
    {
        public DateTime JoinDate { get; set; }
        public Department Department { get; set; }
        public bool IsDepartmentHead { get; set; }

        public int CalculateAge()
        {
            int age = DateTime.Now.Year - Birthdate.Year;
            return age;
        }

        public decimal CalculateSalary()
        {
            return Salary + CalculateBonus();
        }

        // Polymorphism
        public int CalculateExperience()
        {
            int experience = DateTime.Now.Year - JoinDate.Year;
            return experience;
        }

        private decimal CalculateBonus()
        {
            int experience = CalculateExperience();
            return experience * 1000;
        }
    }

    class Course
    {
        public string Name { get; set; }
        public int Credits { get; set; }
        public float GradePoints { get; set; }
        public List<Student> EnrolledStudents { get; private set; }

        public Course()
        {
            EnrolledStudents = new List<Student>();
        }
    }

    class Department
    {
        public string Name { get; set; }
        public Instructor Head { get; set; }
        public decimal Budget { get; set; }
        public DateTime SchoolYearStart { get; set; }
        public DateTime SchoolYearEnd { get; set; }
        public List<Course> OfferedCourses { get; private set; }

        public Department()
        {
            OfferedCourses = new List<Course>();
        }
    }
}