namespace _05Courses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> courseStudents = new();
            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] arguments = input.Split(" : ");
                string course = arguments[0];
                string student = arguments[1];

                if (!courseStudents.ContainsKey(course))
                {
                    courseStudents[course] = new List<string>();
                }
                courseStudents[course].Add(student);
            }
            foreach (KeyValuePair<string, List<string>> pair in courseStudents)
            {
                Console.WriteLine($"{pair.Key}: {pair.Value.Count}");
                Console.WriteLine(string.Join("\n",pair.Value));
            }
        }
    }
}
