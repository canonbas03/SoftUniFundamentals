using System.Collections.Generic;
using System.Diagnostics;

namespace _04.Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
                string[] arguments = Console.ReadLine().Split();

                Student newStudent = new Student();
                newStudent.FirstName = arguments[0];
                newStudent.LastName = arguments[1];
                newStudent.Grade = float.Parse(arguments[2]);

                students.Add(newStudent);
            }

            students = students.OrderByDescending(student => student.Grade).ToList();
            foreach (Student student in students)
            {
                Console.WriteLine(student);
            }

        }

        public class Student
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public float Grade { get; set; }

            public override string ToString()
            {
                return $"{FirstName} {LastName}: {Grade:f2}";
            }
        }
    }
}
