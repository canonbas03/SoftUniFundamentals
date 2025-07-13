namespace _06.StudentAcademy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> studentGrades = new();
            int numRows = int.Parse(Console.ReadLine());
            for (int i = 0; i < numRows; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!studentGrades.ContainsKey(name))
                {
                    studentGrades[name] = new List<double>();
                }
                studentGrades[name].Add(grade);
            }
            foreach(KeyValuePair<string, List<double>> pair in studentGrades)
            {
                double average = pair.Value.Sum() / pair.Value.Count();
                if(average >= 4.5)
                {

                Console.WriteLine($"{pair.Key} -> {average:f2}");
                }
            }
        }
    }
}
