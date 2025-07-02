namespace _05.Students2._0
{
        internal class Program
        {
            static void Main(string[] args)
            {
                List<Student> students = new List<Student>();
                string command;
                while ((command = Console.ReadLine()) != "end")
                {
                    string[] arguments = command.Split();

                    string firstName = arguments[0];
                    string lastName = arguments[1];
                    string age = arguments[2];
                    string homeTown = arguments[3];

                    Student student = new Student();
                    student.firstName = firstName;
                    student.lastName = lastName;
                    student.age = age;
                    student.homeTown = homeTown;
                    students.Add(student);
                }
                string city = Console.ReadLine();

                foreach (Student student in students)
                {
                    if (student.homeTown == city)
                    {
                        Console.WriteLine($"{student.firstName} {student.lastName} is {student.age} years old.");
                    }
                }
            }

            public class Student
            {
                public string firstName { get; set; }
                public string lastName { get; set; }
                public string age { get; set; }
                public string homeTown { get; set; }

            }

        s
        }
   
}
