namespace Employee_System_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Test test = new Test();
            test.Name = "hello";
            Console.WriteLine(test);
        }

        public void AddEmployee(string id)
        {
            if()
        }
    }
    class Employee
    {
        public int Id { get; set; } // PK
        public string Name { get; set; }
        public string Role { get; set; }
        public int Age { get; set; }
    }

    
}
